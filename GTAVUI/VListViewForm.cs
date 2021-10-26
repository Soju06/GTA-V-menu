using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GTAVUI
{
    public partial class VListViewForm : Form
    {
        public Guid Guid { get; set; }
        public event EventHandler EscDown;
        public bool AutoSet { get; set; } = true;
        public int SleepTime { get; set; } = 60;
        private Thread CD;

        public VListViewForm()
        {
            InitializeComponent();
            HookKey.SetHook();
            CD = new Thread(new ThreadStart(CheckData));
            CD.Start();
            sView.ItemChanged += ViewItemChanged;
            FRefresh();
        }

        public void SetDescription(VListViewItem item)
        {
            if(item == null)
            {
                SetDescription(sView.NullItem);
                return;
            }
            DescriptionVisible = item.DescriptionUsed;
            DescriptionText = item.DescriptionText;
            DescriptionHSize = item.DescriptionHSize;
            Size = new Size(sView.Size.Width, sView.Size.Height + (DescriptionVisible ? DescriptionControl.Size.Height + DescriptionInterval : 0));
        }

        private void ViewItemChanged(object sender, EventArgs e)
        {
            if(AutoSet && sender != null)
            {
                SetDescription((VListViewItem)sender);
            }
        }

        public void ResetValue()
        {
            sView.ResetValue();
            SetDescription(sView.SelectItem);
        }

        #region UserEvent

        protected override void WndProc(ref Message m)
        {
            switch (m.Msg)
            {
                case 0x20A:
                    if (m.WParam.ToInt32() == -7864320)
                        sView.SelectHeader += 1;
                    else if (m.WParam.ToInt32() == 7864320)
                        sView.SelectHeader -= 1;
                    break;
            }
            base.WndProc(ref m);
        }

        private void CheckData()
        {
            while (true)
            {
                Thread.Sleep(SleepTime);
                if (HookKey.key != (char)Keys.None)
                {
                    switch (HookKey.key)
                    {
                        case (char)Keys.Up:
                            Invoke(new MethodInvoker(delegate () { sView.SelectHeader -= 1; }));
                            break;
                        case (char)Keys.Down:
                            Invoke(new MethodInvoker(delegate () { sView.SelectHeader += 1; }));
                            break;
                        case (char)Keys.Enter:
                            Invoke(new MethodInvoker(delegate () { sView.SetItemSelect(); }));
                            break;
                        case (char)Keys.Escape:
                            HookKey.key = (char)Keys.None;
                            Invoke(new MethodInvoker(delegate () { EscDown?.Invoke(null, null); }));
                            return;
                    }
                    HookKey.key = (char)Keys.None;
                }
            }
        }

        #endregion

        public void FRefresh()
        {
            sView.VRefresh();
            SetDescription(sView.SelectItem);
        }

        public void RemoveAndAdd(VListViewItem[] items)
        {
            sView.RemoveAllItems();
            sView.ResetValue();
            sView.Items.AddRange(items);
            FRefresh();
            sView.HSize = sView.HSize;
        }

        private void sClosing(object sender, FormClosingEventArgs e)
        {
            CD.Abort();
            CD.Join();
            HookKey.UnHook();
        }

        public bool DescriptionVisible
        {
            get
            {
                return DescriptionControl.Visible;
            }
            set
            {
                DescriptionControl.Visible = value;
            }
        }

        public string DescriptionText
        {
            get
            {
                return DescriptionControl.sText;
            }
            set
            {
                DescriptionControl.sText = value;
            }
        }

        public int DescriptionHSize
        {
            get
            {
                return DescriptionControl.sSize;
            }
            set
            {
                DescriptionControl.sSize = value;
            }
        }

        public void ChangeItem(Guid guid, VListViewItem Item)
        {
            for (int i = 0; i < sView.Items.Count; i++)
            {
                if (sView.Items[i].Guid == guid)
                    sView.Items[i] = Item;
            }
            FRefresh();
        }

        public int DescriptionInterval { get; set; } = 6;

        private void ViewSizeChanged(object sender, EventArgs e)
        {
            Size = new Size(sView.Size.Width, sView.Size.Height + (DescriptionVisible ? DescriptionControl.Size.Height + DescriptionInterval : 0));
        }

        public VListViewControl View { get { return sView; } }

        private void FormVisibleChanged(object sender, EventArgs e)
        {
            if (Visible)
            {
                if (!CD.IsAlive)
                {
                    CD = new Thread(new ThreadStart(CheckData));
                    CD.Start();
                }
                HookKey.SetHook();
            }
            else
                HookKey.UnHook();
        }
    }

    #region HookKey
    public class HookKey
    {
        public static bool EscClose { get; set; } = true;

        [DllImport("user32.dll")]
        private static extern IntPtr SetWindowsHookEx(int idHook, LowLevelKeyProc callback, IntPtr hInstance, uint threadId);
        [DllImport("user32.dll")]
        private static extern bool UnhookWindowsHookEx(IntPtr hInstance);
        [DllImport("user32.dll")]
        private static extern IntPtr CallNextHookEx(IntPtr idHook, int nCode, int wParam, IntPtr lParam);
        [DllImport("kernel32.dll")]
        private static extern IntPtr GetModuleHandle(string lpModuleName);
        private const int WH_KEYBOARD_LL = 13;
        private const int WM_KEYDOWN = 0x100;
        private delegate IntPtr LowLevelKeyProc(int nCode, IntPtr wParam, IntPtr lParam);
        private static LowLevelKeyProc keyboardProc = KeyboardHookProc;
        private static IntPtr keyHook = IntPtr.Zero;
        public static char key;

        public static void SetHook()
        {
            if (keyHook == IntPtr.Zero)
            {
                using (Process curProcess = Process.GetCurrentProcess())
                using (ProcessModule curModule = curProcess.MainModule)
                {
                    keyHook = SetWindowsHookEx(WH_KEYBOARD_LL, keyboardProc, GetModuleHandle(curModule.ModuleName), 0);
                }
            }
        }

        public static void UnHook()
        {
            UnhookWindowsHookEx(keyHook);
            keyHook = IntPtr.Zero;
        }

        private static IntPtr KeyboardHookProc(int code, IntPtr wParam, IntPtr lParam)
        {
            if (code >= 0 && (int)wParam == WM_KEYDOWN)
            {
                char a = Convert.ToChar(Marshal.ReadInt32(lParam)); ;
                if (a == (char)Keys.Up || a == (char)Keys.Down || a == (char)Keys.Enter || EscClose && a == (char)Keys.Escape)
                {
                    key = a;
                    return (IntPtr)1; //Cancel
                }
            }
            return CallNextHookEx(keyHook, code, (int)wParam, lParam);
        }
    }
    #endregion
}
