using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Text;
using System.Runtime.InteropServices;

namespace GTAVUI
{
    public partial class VListViewControl : UserControl
    {
        public event EventHandler ItemSelect;
        public event EventHandler ItemChanged;

        public VListViewItem NullItem = new VListViewItem("", false);
        public List<VListViewItemControl> ControlItems = new List<VListViewItemControl>();

        public VListViewControl()
        {
            InitializeComponent();
            Font = new Font(Utils.Fonts.FontFamilyFromByte(Properties.Resources.SCDream6), 10);
            SetStyle(ControlStyles.DoubleBuffer, true);
            SetStyle(ControlStyles.AllPaintingInWmPaint, true);
            SetStyle(ControlStyles.UserPaint, true);
            UpdateStyles();
        }

        public List<VListViewItem> Items = new List<VListViewItem>();
        public int Count
        {
            get
            {
                return Items.Count;
            }
        }

        private int hSize = 0;

        public int HSize
        {// SizeH 36, Padding 21
            get
            {
                return hSize;
                //return (int)((double)Size.Height / 36);
            }
            set
            {
                hSize = value;
                Size = new Size(Size.Width, 36 * value);
                UFlowLayoutPanel.Visible = false;
                RemoveAll();
                for (int i = 0; i < value; i++)
                {
                    uAdd(NullItem);
                }
                VRefresh();
                UFlowLayoutPanel.Visible = true;
            }
        }

        private void uAdd(VListViewItem item)
        {
            var a = new VListViewItemControl(item);
            UFlowLayoutPanel.Controls.Add(a);
            ControlItems.Add(a);
            a.sDoubleClick += ItemsDoubleClick;
            a.sClick += ItemsClick;
        }

        public void Add(string Text)
        {
            Add(new VListViewItem(Text));
        }

        public void Add(VListViewItem item)
        {
            Items.Add(item);
        }

        private void RemoveAll()
        {
            if(Items.Count > 0)
            {
                foreach (var item in ControlItems)
                {
                    UFlowLayoutPanel.Controls.Remove(item);
                    if (item != null)
                        item.Dispose();
                }
                ControlItems.RemoveRange(0, ControlItems.Count);
                //Items.RemoveRange(0, Items.Count);
            }
        }

        public void RemoveAllItems()
        {
            Items.RemoveRange(0, Items.Count);
            VRefresh();
        }

        public void ResetValue()
        {
            ScrollIndex = 0;
            HSize = hSize;
            ScrollValue = 0;
            VRefresh();
            SelectHeader = 0;
        }

        public int ScrollIndex = 0;

        public void VRefresh()
        {
            if (Items.Count > 0)
            {
                int a = 0;
                for (int i = ScrollIndex; i < ScrollIndex + hSize; i++)
                {
                    VListViewItem item;
                    if (Items.Count - 1 < i)
                    {
                        ScrollValue = Items.Count - hSize;
                        //item = NullItem;
                        break;
                    }
                    else
                        item = Items[i];
                    ControlItems[a].Item = item;
                    a++;
                }
                if(_selectHeader > ControlItems.Count - 1 || _selectHeader < 0)
                    ControlItems[0].sSelect = true;
                else
                    ControlItems[_selectHeader].sSelect = true;
            }
        }

        public int ScrollValue
        {
            get
            {
                return ScrollIndex;
            }
            set
            {
                if (Items.Count > 0 && value > -1 && (Items.Count - hSize + 1 > value || value < ScrollIndex))
                {
                    int a = 0;
                    for (int b = value; b < value + hSize; b++)
                    {
                        VListViewItem item;
                        if (Items.Count - 1 < b)
                            item = NullItem;
                        //return;
                        else
                            item = Items[b];
                        ControlItems[a].Item = item;
                        a++;
                    }
                    ScrollIndex = value;
                }
            }
        }

        private int _selectHeader = 0;
        private int selectHeader
        {
            get { return _selectHeader; }
            set
            {
                _selectHeader = value;
                ItemChanged?.Invoke(SelectItem, null);
            }
        }

        public int SelectHeader
        {
            get
            {
                return selectHeader;
            }
            set
            {

                if (value < 0)
                    ScrollValue -= 1;
                else if (value > ControlItems.Count - 1)
                    ScrollValue += 1;
                int point = value < 0 ? 0 : value > ControlItems.Count - 1 ? ControlItems.Count - 1 : value;
                for (int i = 0; i < ControlItems.Count; i++)
                {
                    ControlItems[i].sSelect = point == i;
                }
                selectHeader = point;
            }
        }

        private void ItemsClick(object sender, EventArgs e)
        {
            VListViewItemControl control = ((VListViewItemControl)sender);
            for (int i = 0; i < ControlItems.Count; i++)
            {
                if (control == ControlItems[i])
                    SelectHeader = i;
            }
            ItemChanged?.Invoke(control.Item, e);
        }

        private void ItemsDoubleClick(object sender, EventArgs e)
        {
            ItemSelect?.Invoke(sender, e);
        }

        public void SetItemSelect()
        {
            VListViewItemControl control = GetSelectItmeControl();
            if(control != null)
                ItemSelect?.Invoke(control, null);
        }

        public VListViewItem SelectItem
        {
            get
            {
                //foreach (var item in ControlItems)
                //{
                //    if (item.sSelect)
                //    {
                //        return item.Item;
                //    }
                //}
                int index = _selectHeader > hSize - 1 ? hSize - 1 : _selectHeader < 0 ? 0 : _selectHeader;
                return ControlItems[index].Item;
            }
            set
            {

                for (int i = 0; i > ControlItems.Count; i++)
                {
                    if (ControlItems[i].sSelect)
                    {
                        ControlItems[i].Item = value;
                    }
                }
            }
        }

        public int SelectIndex
        {
            get
            {
                foreach (var item in ControlItems)
                {
                    if (item.sSelect)
                    {
                        int i = 0;
                        Guid guid = item.Guid;
                        foreach (var vitem in Items)
                        {
                            if (guid == vitem.Guid)
                                return i;
                            i++;
                        }
                        return -1;
                    }
                }
                return -1;
            }
        }

        public VListViewItemControl GetSelectItmeControl()
        {
            foreach (var item in ControlItems)
            {
                if (item.sSelect)
                    return item;
            }
            return null;
        }

        public VListViewItem GetClientIndex(int i)
        {
            return (i < 0 || i > ControlItems.Count - 1) ? null : ControlItems[i].Item;
        }

        public VListViewItem[] GetItems()
        {
            return Items.ToArray();
        }

        public void Insert(VListViewItem item, int va = 0)
        {
            if (Items.Count >= HSize)
                Items.Insert(SelectIndex + va, item);
            else
                Items.Add(item);
            VRefresh();
        }

        public void Insert(int index, VListViewItem item)
        {
            Items.Insert(index, item);
            VRefresh();
        }

        public List<VListViewItem> GetViewItems
        {
            get
            {
                return Items;
            }
        }
    }
}
