namespace GTAVUI
{
    partial class VListViewItemControl
    {
        /// <summary> 
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region 구성 요소 디자이너에서 생성한 코드

        /// <summary> 
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.MainLabel = new System.Windows.Forms.Label();
            this.SubPictureBox = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.SubPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // MainLabel
            // 
            this.MainLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MainLabel.Font = new System.Drawing.Font("에스코어 드림 6 Bold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.MainLabel.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.MainLabel.Location = new System.Drawing.Point(21, 0);
            this.MainLabel.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.MainLabel.Name = "MainLabel";
            this.MainLabel.Size = new System.Drawing.Size(421, 36);
            this.MainLabel.TabIndex = 0;
            this.MainLabel.Text = "VListViewItem";
            this.MainLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.MainLabel.Click += new System.EventHandler(this.uClick);
            this.MainLabel.DoubleClick += new System.EventHandler(this.uDoubleClick);
            // 
            // SubPictureBox
            // 
            this.SubPictureBox.Dock = System.Windows.Forms.DockStyle.Right;
            this.SubPictureBox.Location = new System.Drawing.Point(406, 0);
            this.SubPictureBox.Margin = new System.Windows.Forms.Padding(0);
            this.SubPictureBox.Name = "SubPictureBox";
            this.SubPictureBox.Size = new System.Drawing.Size(36, 36);
            this.SubPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.SubPictureBox.TabIndex = 1;
            this.SubPictureBox.TabStop = false;
            this.SubPictureBox.Click += new System.EventHandler(this.uClick);
            this.SubPictureBox.DoubleClick += new System.EventHandler(this.uDoubleClick);
            // 
            // ListViewItemControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.SubPictureBox);
            this.Controls.Add(this.MainLabel);
            this.Font = new System.Drawing.Font("에스코어 드림 6 Bold", 12F, System.Drawing.FontStyle.Bold);
            this.ForeColor = System.Drawing.Color.White;
            this.Margin = new System.Windows.Forms.Padding(0);
            this.Name = "ListViewItemControl";
            this.Padding = new System.Windows.Forms.Padding(21, 0, 0, 0);
            this.Size = new System.Drawing.Size(442, 36);
            this.Click += new System.EventHandler(this.uClick);
            this.DoubleClick += new System.EventHandler(this.uDoubleClick);
            ((System.ComponentModel.ISupportInitialize)(this.SubPictureBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label MainLabel;
        private System.Windows.Forms.PictureBox SubPictureBox;
    }
}
