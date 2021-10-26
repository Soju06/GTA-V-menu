namespace GTAVUI
{
    partial class VListViewControl
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
            this.UFlowLayoutPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.SuspendLayout();
            // 
            // UFlowLayoutPanel
            // 
            this.UFlowLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.UFlowLayoutPanel.Location = new System.Drawing.Point(0, 0);
            this.UFlowLayoutPanel.Margin = new System.Windows.Forms.Padding(0);
            this.UFlowLayoutPanel.Name = "UFlowLayoutPanel";
            this.UFlowLayoutPanel.Size = new System.Drawing.Size(442, 64);
            this.UFlowLayoutPanel.TabIndex = 0;
            // 
            // ListViewControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.Controls.Add(this.UFlowLayoutPanel);
            this.Font = new System.Drawing.Font("에스코어 드림 6 Bold", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.ForeColor = System.Drawing.Color.White;
            this.Margin = new System.Windows.Forms.Padding(0);
            this.MinimumSize = new System.Drawing.Size(442, 32);
            this.Name = "ListViewControl";
            this.Size = new System.Drawing.Size(442, 64);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel UFlowLayoutPanel;
    }
}
