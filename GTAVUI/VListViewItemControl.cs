using System;
using System.Drawing;
using System.Windows.Forms;

namespace GTAVUI
{
    public partial class VListViewItemControl : UserControl
    {
        public event EventHandler sClick;
        public event EventHandler sDoubleClick;

        public VListViewItemControl()
        {
            InitializeComponent();
        }

        public VListViewItemControl(VListViewItem item)
        {
            InitializeComponent();
            Item = item;
        }
        public VListViewItem Item
        {
            get
            {
                return new VListViewItem(MainLabel.Text, Guid,_enabled, _folderMode, _labelMode, _select, _descriptionUsed, _descriptionText, _descriptionHSize, sTag);
            }
            set
            {
                if(value != null)
                {
                    Guid = value.Guid;
                    sText = value.Text;
                    _enabled = value.Enabled;
                    _labelMode = value.LabelMode;
                    _folderMode = value.FolderMode;
                    _select = value.Select;
                    _descriptionUsed = value.DescriptionUsed;
                    _descriptionText = value.DescriptionText;
                    _descriptionHSize = value.DescriptionHSize;
                    sTag = value.Tag;
                    IRefresh();
                }
            }
        }

        public object sTag { get; set; }
        public Guid Guid { get; private set; }
        public string sText
        {
            get
            {
                return MainLabel.Text;
            }
            set
            {
                MainLabel.Text = value;
            }
        }
        private bool _descriptionUsed = false;
        private string _descriptionText;
        private int _descriptionHSize = 1;
        private bool _select = false;
        private bool _enabled = true;
        private bool _labelMode = false;
        private bool _folderMode = false;
        public bool sSelect
        {
            get
            {
                return _select;
            }
            set
            {
                _select = value;
                IRefresh();
            }
        }
        public bool FolderMode
        {
            get
            {
                return _folderMode;
            }
            set
            {
                _folderMode = value;
                IRefresh();
            }
        }

        public bool sEnabled
        {
            get
            {
                return _enabled;
            }
            set
            {
                _enabled = value;
                IRefresh();
            }
        }

        public bool LabelMode
        {
            get
            {
                return _labelMode;
            }
            set
            {
                _labelMode = value;
                IRefresh();
            }
        }

        public void IRefresh()
        {
            if (_folderMode)
                ImageMode(_select ? (_labelMode || !_enabled ? 1 : 2) : 1);
            else
                ImageMode(0);
            SetBackColor(_select ? (_labelMode || !_enabled ? 2 : 1) : 0);
            if (_enabled)
            {
                if (!_labelMode)
                    SetColor(_select ? 1 : 0);
            }
            else if (!_enabled)
                SetColor(2);
            if (_labelMode)
                SetColor(3);
        }

        private void SetColor(int i)
        {
            switch (i)
            {
                case 0:
                    ForeColor = Color.FromArgb(255, 255, 255);
                    break;
                case 1:
                    ForeColor = Color.FromArgb(0, 0, 0);
                    break;
                case 2:
                    ForeColor = Color.FromArgb(153, 152, 153);
                    break;
                case 3:
                    ForeColor = Color.FromArgb(255, 162, 60);
                    break;
                default:
                    break;
            }
        }

        private void SetBackColor(int select)
        {
            switch (select)
            {
                case 1:
                    BackColor = Color.FromArgb(255, 255, 255);
                    ForeColor = Color.FromArgb(0, 0, 0);
                    break;
                case 0:
                    BackColor = Color.FromArgb(0, 0, 0);
                    break;
                case 2:
                    BackColor = Color.FromArgb(48, 48, 48);
                    break;
                default:
                    break;
            }
        }

        private void ImageMode(int i)
        {
            if (SubPictureBox.Image != null)
            {
                SubPictureBox.Image.Dispose();
                SubPictureBox.Image = null;
            }
            switch (i)
            {
                case 0:
                    SubPictureBox.Visible = false;
                    break;
                case 1:
                    SubPictureBox.Visible = true;
                    SubPictureBox.Image = Properties.Resources.gotoWhite;
                    break;
                case 2:
                    SubPictureBox.Visible = true;
                    SubPictureBox.Image = Properties.Resources.gotoBlack;
                    break;
                default:
                    break;
            }
        }

        private void uClick(object sender, EventArgs e)
        {
            sClick?.Invoke(this, e);
        }

        private void uDoubleClick(object sender, EventArgs e)
        {
            sDoubleClick?.Invoke(this, e);
        }
    }
}
