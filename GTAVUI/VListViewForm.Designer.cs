namespace GTAVUI
{
    partial class VListViewForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            GTAVUI.VListViewItem vListViewItem2 = new GTAVUI.VListViewItem();
            this.sView = new GTAVUI.VListViewControl();
            this.DescriptionControl = new GTAVUI.VItemDescriptionControl();
            this.SuspendLayout();
            // 
            // sView
            // 
            this.sView.BackColor = System.Drawing.Color.Black;
            this.sView.Dock = System.Windows.Forms.DockStyle.Top;
            this.sView.ForeColor = System.Drawing.Color.White;
            this.sView.HSize = 3;
            this.sView.Location = new System.Drawing.Point(0, 0);
            this.sView.Margin = new System.Windows.Forms.Padding(0);
            this.sView.MinimumSize = new System.Drawing.Size(442, 34);
            this.sView.Name = "sView";
            this.sView.ScrollValue = 0;
            this.sView.SelectHeader = 0;
            this.sView.SelectItem = vListViewItem2;
            this.sView.Size = new System.Drawing.Size(442, 108);
            this.sView.TabIndex = 4;
            this.sView.SizeChanged += new System.EventHandler(this.ViewSizeChanged);
            // 
            // DescriptionControl
            // 
            this.DescriptionControl.BackColor = System.Drawing.Color.Black;
            this.DescriptionControl.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.DescriptionControl.ForeColor = System.Drawing.Color.White;
            this.DescriptionControl.FSize = 24;
            this.DescriptionControl.Location = new System.Drawing.Point(0, 114);
            this.DescriptionControl.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.DescriptionControl.Name = "DescriptionControl";
            this.DescriptionControl.Padding = new System.Windows.Forms.Padding(10);
            this.DescriptionControl.Size = new System.Drawing.Size(442, 68);
            this.DescriptionControl.sSize = 2;
            this.DescriptionControl.sText = "";
            this.DescriptionControl.TabIndex = 3;
            // 
            // VListViewForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(10)))), ((int)(((byte)(9)))));
            this.ClientSize = new System.Drawing.Size(442, 182);
            this.Controls.Add(this.sView);
            this.Controls.Add(this.DescriptionControl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "VListViewForm";
            this.Opacity = 0.86D;
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "VListViewForm";
            this.TopMost = true;
            this.TransparencyKey = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(10)))), ((int)(((byte)(9)))));
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.sClosing);
            this.VisibleChanged += new System.EventHandler(this.FormVisibleChanged);
            this.ResumeLayout(false);

        }

        #endregion
        private VItemDescriptionControl DescriptionControl;
        private VListViewControl sView;
    }
}