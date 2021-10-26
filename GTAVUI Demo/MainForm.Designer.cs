namespace GTAVUI_Demo
{
    partial class MainForm
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

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.HSize = new System.Windows.Forms.TrackBar();
            this.label1 = new System.Windows.Forms.Label();
            this.ScrollValue = new System.Windows.Forms.TrackBar();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SelectHeaderUp = new System.Windows.Forms.Button();
            this.SelectHeaderDown = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.FolderMode = new System.Windows.Forms.ComboBox();
            this.sSelect = new System.Windows.Forms.ComboBox();
            this.LabelMode = new System.Windows.Forms.ComboBox();
            this.sEnabled = new System.Windows.Forms.ComboBox();
            this.sText = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.OpacityBar = new System.Windows.Forms.TrackBar();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.DescriptionUsed = new System.Windows.Forms.ComboBox();
            this.DescriptionText = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.DescriptionHSize = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.HSize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ScrollValue)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.OpacityBar)).BeginInit();
            this.SuspendLayout();
            // 
            // HSize
            // 
            this.HSize.LargeChange = 2;
            this.HSize.Location = new System.Drawing.Point(12, 24);
            this.HSize.Maximum = 20;
            this.HSize.Minimum = 1;
            this.HSize.Name = "HSize";
            this.HSize.Size = new System.Drawing.Size(422, 45);
            this.HSize.TabIndex = 0;
            this.HSize.TickStyle = System.Windows.Forms.TickStyle.Both;
            this.HSize.Value = 3;
            this.HSize.Scroll += new System.EventHandler(this.HSizeScroll);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 12);
            this.label1.TabIndex = 1;
            this.label1.Text = "HSize:";
            // 
            // ScrollValue
            // 
            this.ScrollValue.LargeChange = 2;
            this.ScrollValue.Location = new System.Drawing.Point(12, 87);
            this.ScrollValue.Maximum = 20;
            this.ScrollValue.Minimum = 1;
            this.ScrollValue.Name = "ScrollValue";
            this.ScrollValue.Size = new System.Drawing.Size(422, 45);
            this.ScrollValue.TabIndex = 0;
            this.ScrollValue.TickStyle = System.Windows.Forms.TickStyle.Both;
            this.ScrollValue.Value = 3;
            this.ScrollValue.Scroll += new System.EventHandler(this.ScrollValueScroll);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 12);
            this.label2.TabIndex = 2;
            this.label2.Text = "ScrollValue:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(10, 198);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 12);
            this.label3.TabIndex = 2;
            this.label3.Text = "SelectHeader:";
            // 
            // SelectHeaderUp
            // 
            this.SelectHeaderUp.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.SelectHeaderUp.Location = new System.Drawing.Point(12, 213);
            this.SelectHeaderUp.Name = "SelectHeaderUp";
            this.SelectHeaderUp.Size = new System.Drawing.Size(71, 32);
            this.SelectHeaderUp.TabIndex = 3;
            this.SelectHeaderUp.Text = "Up";
            this.SelectHeaderUp.UseVisualStyleBackColor = true;
            this.SelectHeaderUp.Click += new System.EventHandler(this.SelectHeaderUpClick);
            // 
            // SelectHeaderDown
            // 
            this.SelectHeaderDown.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.SelectHeaderDown.Location = new System.Drawing.Point(89, 213);
            this.SelectHeaderDown.Name = "SelectHeaderDown";
            this.SelectHeaderDown.Size = new System.Drawing.Size(71, 32);
            this.SelectHeaderDown.TabIndex = 3;
            this.SelectHeaderDown.Text = "Down";
            this.SelectHeaderDown.UseVisualStyleBackColor = true;
            this.SelectHeaderDown.Click += new System.EventHandler(this.SelectHeaderDownClick);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.DescriptionUsed);
            this.groupBox1.Controls.Add(this.FolderMode);
            this.groupBox1.Controls.Add(this.sSelect);
            this.groupBox1.Controls.Add(this.LabelMode);
            this.groupBox1.Controls.Add(this.sEnabled);
            this.groupBox1.Controls.Add(this.DescriptionHSize);
            this.groupBox1.Controls.Add(this.DescriptionText);
            this.groupBox1.Controls.Add(this.sText);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Location = new System.Drawing.Point(12, 251);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(422, 243);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Edit Item";
            // 
            // FolderMode
            // 
            this.FolderMode.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.FolderMode.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.FolderMode.FormattingEnabled = true;
            this.FolderMode.Items.AddRange(new object[] {
            "True",
            "False"});
            this.FolderMode.Location = new System.Drawing.Point(333, 127);
            this.FolderMode.Name = "FolderMode";
            this.FolderMode.Size = new System.Drawing.Size(83, 20);
            this.FolderMode.TabIndex = 3;
            // 
            // sSelect
            // 
            this.sSelect.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.sSelect.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.sSelect.FormattingEnabled = true;
            this.sSelect.Items.AddRange(new object[] {
            "True",
            "False"});
            this.sSelect.Location = new System.Drawing.Point(333, 101);
            this.sSelect.Name = "sSelect";
            this.sSelect.Size = new System.Drawing.Size(83, 20);
            this.sSelect.TabIndex = 3;
            // 
            // LabelMode
            // 
            this.LabelMode.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.LabelMode.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.LabelMode.FormattingEnabled = true;
            this.LabelMode.Items.AddRange(new object[] {
            "True",
            "False"});
            this.LabelMode.Location = new System.Drawing.Point(333, 75);
            this.LabelMode.Name = "LabelMode";
            this.LabelMode.Size = new System.Drawing.Size(83, 20);
            this.LabelMode.TabIndex = 3;
            // 
            // sEnabled
            // 
            this.sEnabled.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.sEnabled.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.sEnabled.FormattingEnabled = true;
            this.sEnabled.Items.AddRange(new object[] {
            "True",
            "False"});
            this.sEnabled.Location = new System.Drawing.Point(333, 49);
            this.sEnabled.Name = "sEnabled";
            this.sEnabled.Size = new System.Drawing.Size(83, 20);
            this.sEnabled.TabIndex = 3;
            // 
            // sText
            // 
            this.sText.Location = new System.Drawing.Point(53, 22);
            this.sText.Name = "sText";
            this.sText.Size = new System.Drawing.Size(363, 21);
            this.sText.TabIndex = 0;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 130);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(76, 12);
            this.label8.TabIndex = 2;
            this.label8.Text = "FolderMode:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 104);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(51, 12);
            this.label7.TabIndex = 2;
            this.label7.Text = "sSelect:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 78);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(72, 12);
            this.label6.TabIndex = 2;
            this.label6.Text = "LabelMode:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 52);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(62, 12);
            this.label5.TabIndex = 2;
            this.label5.Text = "sEnabled:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 27);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 12);
            this.label4.TabIndex = 2;
            this.label4.Text = "sText:";
            // 
            // button1
            // 
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.button1.Location = new System.Drawing.Point(367, 247);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(57, 24);
            this.button1.TabIndex = 3;
            this.button1.Text = "Update";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.UpdateClick);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(12, 135);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(52, 12);
            this.label9.TabIndex = 2;
            this.label9.Text = "Opacity:";
            // 
            // OpacityBar
            // 
            this.OpacityBar.LargeChange = 2;
            this.OpacityBar.Location = new System.Drawing.Point(14, 150);
            this.OpacityBar.Maximum = 100;
            this.OpacityBar.Minimum = 1;
            this.OpacityBar.Name = "OpacityBar";
            this.OpacityBar.Size = new System.Drawing.Size(422, 45);
            this.OpacityBar.TabIndex = 0;
            this.OpacityBar.TickStyle = System.Windows.Forms.TickStyle.Both;
            this.OpacityBar.Value = 90;
            this.OpacityBar.Scroll += new System.EventHandler(this.OpacityScroll);
            // 
            // button2
            // 
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.button2.Location = new System.Drawing.Point(304, 247);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(57, 24);
            this.button2.TabIndex = 3;
            this.button2.Text = "Delete";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.DeleteClick);
            // 
            // button3
            // 
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.button3.Location = new System.Drawing.Point(241, 246);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(57, 24);
            this.button3.TabIndex = 3;
            this.button3.Text = "Add";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.AddClick);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(6, 155);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(101, 12);
            this.label10.TabIndex = 2;
            this.label10.Text = "DescriptionUsed:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(6, 185);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(97, 12);
            this.label11.TabIndex = 2;
            this.label11.Text = "DescriptionText:";
            // 
            // DescriptionUsed
            // 
            this.DescriptionUsed.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.DescriptionUsed.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.DescriptionUsed.FormattingEnabled = true;
            this.DescriptionUsed.Items.AddRange(new object[] {
            "True",
            "False"});
            this.DescriptionUsed.Location = new System.Drawing.Point(333, 154);
            this.DescriptionUsed.Name = "DescriptionUsed";
            this.DescriptionUsed.Size = new System.Drawing.Size(83, 20);
            this.DescriptionUsed.TabIndex = 3;
            // 
            // DescriptionText
            // 
            this.DescriptionText.Location = new System.Drawing.Point(109, 181);
            this.DescriptionText.Name = "DescriptionText";
            this.DescriptionText.Size = new System.Drawing.Size(307, 21);
            this.DescriptionText.TabIndex = 0;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(6, 212);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(105, 12);
            this.label12.TabIndex = 2;
            this.label12.Text = "DescriptionHSize:";
            // 
            // DescriptionHSize
            // 
            this.DescriptionHSize.Location = new System.Drawing.Point(333, 208);
            this.DescriptionHSize.MaxLength = 10;
            this.DescriptionHSize.Name = "DescriptionHSize";
            this.DescriptionHSize.Size = new System.Drawing.Size(83, 21);
            this.DescriptionHSize.TabIndex = 0;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(446, 506);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.SelectHeaderDown);
            this.Controls.Add(this.SelectHeaderUp);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.OpacityBar);
            this.Controls.Add(this.ScrollValue);
            this.Controls.Add(this.HSize);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "GTAVUI Demo";
            this.TopMost = true;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ClosingForm);
            ((System.ComponentModel.ISupportInitialize)(this.HSize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ScrollValue)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.OpacityBar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TrackBar HSize;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TrackBar ScrollValue;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button SelectHeaderUp;
        private System.Windows.Forms.Button SelectHeaderDown;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox sText;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox LabelMode;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox sSelect;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox FolderMode;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox sEnabled;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TrackBar OpacityBar;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox DescriptionUsed;
        private System.Windows.Forms.TextBox DescriptionText;
        private System.Windows.Forms.TextBox DescriptionHSize;
        private System.Windows.Forms.Label label12;
    }
}

