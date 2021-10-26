using GTAVUI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GTAVUI_Demo
{
    public partial class MainForm : Form
    {
        private VListViewForm GTAVUIForm = new VListViewForm();
        public MainForm()
        {
            InitializeComponent();
            Screen screens = Screen.PrimaryScreen;
            GTAVUIForm.Show();
            GTAVUIForm.Location = new Point(screens.WorkingArea.Location.X + 12, screens.WorkingArea.Location.Y + 12);
            Random random = new Random();
            GTAVUIForm.View.Add(new VListViewItem("GTAVUI", true, true));
            GTAVUIForm.View.Add(new VListViewItem("", false));
            GTAVUIForm.View.Add(new VListViewItem("Setting", true, true));
            for (int i = 0; i < 30; i++)
            {
                int f = random.Next(0, 6);
                if (f == 0)
                    GTAVUIForm.View.Add(new VListViewItem(string.Format("Item #{0}", i)));
                else if (f == 1)
                    GTAVUIForm.View.Add(new VListViewItem(string.Format("Disable Item #{0}", i), false));
                else if (f == 2)
                    GTAVUIForm.View.Add(new VListViewItem(string.Format("Label Item #{0}", i), true, false, true));
                else if (f == 3)
                    GTAVUIForm.View.Add(new VListViewItem(string.Format("Folder Item #{0}", i), true, true));
                else if (f == 4)
                    GTAVUIForm.View.Add(new VListViewItem(string.Format("Label Folder Item #{0}", i), true, true, true));
                else if (f == 5)
                    GTAVUIForm.View.Add(new VListViewItem(string.Format("Disable Folder Item #{0}", i), false, true));
            }
            GTAVUIForm.View.Add(new VListViewItem(string.Format("Version : {0}", Assembly.GetExecutingAssembly().GetName().Version), false));
            GTAVUIForm.View.HSize = 4;
            ScrollValue.Maximum = GTAVUIForm.View.Count;
            HSize.Value = GTAVUIForm.View.HSize;
            OpacityBar.Value = (int)(GTAVUIForm.Opacity * 100);
            ScrollValue.Minimum = 0;
            ScrollValue.Value = 0;
            GTAVUIForm.View.ItemChanged += ItemChanged;
        }

        private void ItemChanged(object sender, EventArgs e)
        {
            VListViewItem item = (VListViewItem)sender;
            if(item != null)
            {
                sText.Text = item.Text;
                _sEnabled = item.Enabled;
                _sSelect = item.Select;
                _LabelMode = item.LabelMode;
                _FolderMode = item.FolderMode;
                _DescriptionUsed = item.DescriptionUsed;
                DescriptionText.Text = item.DescriptionText;
                DescriptionText.Text = item.DescriptionText;
                DescriptionHSize.Text = item.DescriptionHSize.ToString();
            }
        }

        private void HSizeScroll(object sender, EventArgs e)
        {
            GTAVUIForm.View.HSize = HSize.Value;
        }

        private void ScrollValueScroll(object sender, EventArgs e)
        {
            GTAVUIForm.View.ScrollValue = ScrollValue.Value;
        }

        private void SelectHeaderUpClick(object sender, EventArgs e)
        {
            GTAVUIForm.View.SelectHeader += 1;
        }

        private void SelectHeaderDownClick(object sender, EventArgs e)
        {
            GTAVUIForm.View.SelectHeader -= 1;
        }

        private void ClosingForm(object sender, FormClosingEventArgs e)
        {
            GTAVUIForm.Close();
            if (GTAVUIForm != null)
                GTAVUIForm.Dispose();
        }
        private bool _sEnabled
        {
            get
            {
                return GetBoolen(sEnabled.SelectedIndex);
            }
            set
            {
                sEnabled.SelectedIndex = GetInt(value);
            }
        }
        private bool _LabelMode
        {
            get
            {
                return GetBoolen(LabelMode.SelectedIndex);
            }
            set
            {
                LabelMode.SelectedIndex = GetInt(value);
            }
        }
        private bool _sSelect
        {
            get
            {
                return GetBoolen(sSelect.SelectedIndex);
            }
            set
            {
                sSelect.SelectedIndex = GetInt(value);
            }
        }
        private bool _FolderMode
        {
            get
            {
                return GetBoolen(FolderMode.SelectedIndex);
            }
            set
            {
                FolderMode.SelectedIndex = GetInt(value);
            }
        }
        private bool _DescriptionUsed
        {
            get
            {
                return GetBoolen(DescriptionUsed.SelectedIndex);
            }
            set
            {
                DescriptionUsed.SelectedIndex = GetInt(value);
            }
        }

        private bool GetBoolen(int value)
        {
            return value == 0;
        }
        private int GetInt(bool value)
        {
            return value ? 0 : 1;
        }

        private void UpdateClick(object sender, EventArgs e)
        {
            try
            {
                VListViewItem item = new VListViewItem(sText.Text, _sEnabled, _FolderMode, _LabelMode, _sSelect, _DescriptionUsed, DescriptionText.Text, int.Parse(DescriptionHSize.Text));
                GTAVUIForm.View.Items[GTAVUIForm.View.SelectIndex] = item;
                GTAVUIForm.View.SelectItem = item;
                GTAVUIForm.FRefresh();
            }
            catch (Exception ex){ MessageBox.Show(ex.ToString()); }
        }

        private void OpacityScroll(object sender, EventArgs e)
        {
            GTAVUIForm.Opacity = OpacityBar.Value * 0.01;
        }

        private void DeleteClick(object sender, EventArgs e)
        {
            int i = GTAVUIForm.View.SelectIndex;
            if(i != -1)
            {
                GTAVUIForm.View.Items.RemoveAt(GTAVUIForm.View.SelectIndex);
                GTAVUIForm.FRefresh();
            }
        }

        private void AddClick(object sender, EventArgs e)
        {
            try
            {
                GTAVUIForm.View.Insert(new VListViewItem(sText.Text, _sEnabled, _FolderMode, _LabelMode, _sSelect, _DescriptionUsed, DescriptionText.Text, int.Parse(DescriptionHSize.Text)), 1);
                GTAVUIForm.FRefresh();
            }
            catch (Exception ex) { MessageBox.Show(ex.ToString()); }
        }
    }
}
