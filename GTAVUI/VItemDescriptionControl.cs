using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GTAVUI
{
    public partial class VItemDescriptionControl : UserControl
    {
        public VItemDescriptionControl()
        {
            InitializeComponent();
            Font = new Font(Utils.Fonts.FontFamilyFromByte(Properties.Resources.NotoSansKR_Bold), 12);
        }

        public string sText
        {
            get
            {
                return DescriptionLabel.Text;
            }
            set
            {
                DescriptionLabel.Text = value;
            }
        }

        public int FSize { get; set; } = 24;

        public int sSize
        {
            get
            {
                return (Size.Height - (Padding.Top + Padding.Bottom)) / FSize;
            }
            set
            {
                Size = new Size(Size.Width, (FSize * value) + Padding.Top + Padding.Bottom);
            }
        }

        public VListViewItem SetItem
        {
            set
            {
                Visible = value.DescriptionUsed;
                sText = value.DescriptionText;
                sSize = value.DescriptionHSize;
            }
        }
    }
}
