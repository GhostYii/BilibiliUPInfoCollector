namespace BilibiliUPInfoCollector.UI
{
    partial class SettingForm
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
            this.LiveAreaGroupBox = new System.Windows.Forms.GroupBox();
            this.AreaTypeLabel = new System.Windows.Forms.Label();
            this.LiveTypeLabel = new System.Windows.Forms.Label();
            this.AreaTypeComboBox = new System.Windows.Forms.ComboBox();
            this.LiveTypeComboBox = new System.Windows.Forms.ComboBox();
            this.IntervalGroupBox = new System.Windows.Forms.GroupBox();
            this.SecondLabel = new System.Windows.Forms.Label();
            this.MinLabel = new System.Windows.Forms.Label();
            this.HourLabel = new System.Windows.Forms.Label();
            this.SecondTextBox = new System.Windows.Forms.TextBox();
            this.MinTextBox = new System.Windows.Forms.TextBox();
            this.HourTextBox = new System.Windows.Forms.TextBox();
            this.OKButton = new System.Windows.Forms.Button();
            this.CancelSettingButton = new System.Windows.Forms.Button();
            this.LiveAreaGroupBox.SuspendLayout();
            this.IntervalGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // LiveAreaGroupBox
            // 
            this.LiveAreaGroupBox.Controls.Add(this.AreaTypeLabel);
            this.LiveAreaGroupBox.Controls.Add(this.LiveTypeLabel);
            this.LiveAreaGroupBox.Controls.Add(this.AreaTypeComboBox);
            this.LiveAreaGroupBox.Controls.Add(this.LiveTypeComboBox);
            this.LiveAreaGroupBox.Location = new System.Drawing.Point(13, 13);
            this.LiveAreaGroupBox.Name = "LiveAreaGroupBox";
            this.LiveAreaGroupBox.Size = new System.Drawing.Size(226, 90);
            this.LiveAreaGroupBox.TabIndex = 0;
            this.LiveAreaGroupBox.TabStop = false;
            this.LiveAreaGroupBox.Text = "采集分区设置";
            // 
            // AreaTypeLabel
            // 
            this.AreaTypeLabel.AutoSize = true;
            this.AreaTypeLabel.Font = new System.Drawing.Font("SimSun", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.AreaTypeLabel.Location = new System.Drawing.Point(31, 60);
            this.AreaTypeLabel.Name = "AreaTypeLabel";
            this.AreaTypeLabel.Size = new System.Drawing.Size(56, 16);
            this.AreaTypeLabel.TabIndex = 3;
            this.AreaTypeLabel.Text = "子分区";
            // 
            // LiveTypeLabel
            // 
            this.LiveTypeLabel.AutoSize = true;
            this.LiveTypeLabel.Font = new System.Drawing.Font("SimSun", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.LiveTypeLabel.Location = new System.Drawing.Point(31, 32);
            this.LiveTypeLabel.Name = "LiveTypeLabel";
            this.LiveTypeLabel.Size = new System.Drawing.Size(56, 16);
            this.LiveTypeLabel.TabIndex = 2;
            this.LiveTypeLabel.Text = "主分区";
            // 
            // AreaTypeComboBox
            // 
            this.AreaTypeComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.AreaTypeComboBox.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.AreaTypeComboBox.FormattingEnabled = true;
            this.AreaTypeComboBox.Items.AddRange(new object[] {
            "全部",
            "视频唱见",
            "舞见",
            "视频聊天",
            "才艺",
            "虚拟主播",
            "美食",
            "户外",
            "手工",
            "萌宠",
            "学习",
            "映评馆",
            "音乐台"});
            this.AreaTypeComboBox.Location = new System.Drawing.Point(99, 59);
            this.AreaTypeComboBox.Name = "AreaTypeComboBox";
            this.AreaTypeComboBox.Size = new System.Drawing.Size(121, 20);
            this.AreaTypeComboBox.TabIndex = 1;
            // 
            // LiveTypeComboBox
            // 
            this.LiveTypeComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.LiveTypeComboBox.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.LiveTypeComboBox.FormattingEnabled = true;
            this.LiveTypeComboBox.Items.AddRange(new object[] {
            "娱乐",
            "网游",
            "手游",
            "绘画",
            "电台",
            "单机"});
            this.LiveTypeComboBox.Location = new System.Drawing.Point(99, 30);
            this.LiveTypeComboBox.Name = "LiveTypeComboBox";
            this.LiveTypeComboBox.Size = new System.Drawing.Size(121, 20);
            this.LiveTypeComboBox.TabIndex = 0;
            this.LiveTypeComboBox.SelectedIndexChanged += new System.EventHandler(this.OnLiveTypeComboBoxSelectedIndexChanged);
            // 
            // IntervalGroupBox
            // 
            this.IntervalGroupBox.Controls.Add(this.SecondLabel);
            this.IntervalGroupBox.Controls.Add(this.MinLabel);
            this.IntervalGroupBox.Controls.Add(this.HourLabel);
            this.IntervalGroupBox.Controls.Add(this.SecondTextBox);
            this.IntervalGroupBox.Controls.Add(this.MinTextBox);
            this.IntervalGroupBox.Controls.Add(this.HourTextBox);
            this.IntervalGroupBox.Location = new System.Drawing.Point(245, 13);
            this.IntervalGroupBox.Name = "IntervalGroupBox";
            this.IntervalGroupBox.Size = new System.Drawing.Size(227, 90);
            this.IntervalGroupBox.TabIndex = 1;
            this.IntervalGroupBox.TabStop = false;
            this.IntervalGroupBox.Text = "自动采集间隔";
            // 
            // SecondLabel
            // 
            this.SecondLabel.AutoSize = true;
            this.SecondLabel.Location = new System.Drawing.Point(192, 39);
            this.SecondLabel.Name = "SecondLabel";
            this.SecondLabel.Size = new System.Drawing.Size(17, 12);
            this.SecondLabel.TabIndex = 5;
            this.SecondLabel.Text = "秒";
            // 
            // MinLabel
            // 
            this.MinLabel.AutoSize = true;
            this.MinLabel.Location = new System.Drawing.Point(124, 39);
            this.MinLabel.Name = "MinLabel";
            this.MinLabel.Size = new System.Drawing.Size(17, 12);
            this.MinLabel.TabIndex = 4;
            this.MinLabel.Text = "分";
            // 
            // HourLabel
            // 
            this.HourLabel.AutoSize = true;
            this.HourLabel.Location = new System.Drawing.Point(56, 39);
            this.HourLabel.Name = "HourLabel";
            this.HourLabel.Size = new System.Drawing.Size(17, 12);
            this.HourLabel.TabIndex = 3;
            this.HourLabel.Text = "时";
            // 
            // SecondTextBox
            // 
            this.SecondTextBox.Location = new System.Drawing.Point(146, 35);
            this.SecondTextBox.MaxLength = 2;
            this.SecondTextBox.Name = "SecondTextBox";
            this.SecondTextBox.Size = new System.Drawing.Size(41, 21);
            this.SecondTextBox.TabIndex = 2;
            this.SecondTextBox.Text = "0";
            this.SecondTextBox.TextChanged += new System.EventHandler(this.OnIntervalTextChanged);
            // 
            // MinTextBox
            // 
            this.MinTextBox.Location = new System.Drawing.Point(78, 35);
            this.MinTextBox.MaxLength = 2;
            this.MinTextBox.Name = "MinTextBox";
            this.MinTextBox.Size = new System.Drawing.Size(42, 21);
            this.MinTextBox.TabIndex = 1;
            this.MinTextBox.Text = "0";
            this.MinTextBox.TextChanged += new System.EventHandler(this.OnIntervalTextChanged);
            // 
            // HourTextBox
            // 
            this.HourTextBox.Location = new System.Drawing.Point(16, 35);
            this.HourTextBox.MaxLength = 2;
            this.HourTextBox.Name = "HourTextBox";
            this.HourTextBox.Size = new System.Drawing.Size(35, 21);
            this.HourTextBox.TabIndex = 0;
            this.HourTextBox.Text = "1";
            this.HourTextBox.TextChanged += new System.EventHandler(this.OnIntervalTextChanged);
            // 
            // OKButton
            // 
            this.OKButton.Location = new System.Drawing.Point(245, 117);
            this.OKButton.Name = "OKButton";
            this.OKButton.Size = new System.Drawing.Size(109, 32);
            this.OKButton.TabIndex = 2;
            this.OKButton.Text = "应用";
            this.OKButton.UseVisualStyleBackColor = true;
            this.OKButton.Click += new System.EventHandler(this.OnOKButtonClick);
            // 
            // CancelSettingButton
            // 
            this.CancelSettingButton.Location = new System.Drawing.Point(360, 117);
            this.CancelSettingButton.Name = "CancelSettingButton";
            this.CancelSettingButton.Size = new System.Drawing.Size(109, 32);
            this.CancelSettingButton.TabIndex = 3;
            this.CancelSettingButton.Text = "取消";
            this.CancelSettingButton.UseVisualStyleBackColor = true;
            this.CancelSettingButton.Click += new System.EventHandler(this.OnCancelButtonClick);
            // 
            // SettingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 161);
            this.Controls.Add(this.CancelSettingButton);
            this.Controls.Add(this.OKButton);
            this.Controls.Add(this.IntervalGroupBox);
            this.Controls.Add(this.LiveAreaGroupBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(500, 200);
            this.MinimumSize = new System.Drawing.Size(500, 200);
            this.Name = "SettingForm";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "设置";
            this.Load += new System.EventHandler(this.Init);
            this.LiveAreaGroupBox.ResumeLayout(false);
            this.LiveAreaGroupBox.PerformLayout();
            this.IntervalGroupBox.ResumeLayout(false);
            this.IntervalGroupBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox LiveAreaGroupBox;
        private System.Windows.Forms.GroupBox IntervalGroupBox;
        private System.Windows.Forms.Button OKButton;
        private System.Windows.Forms.Button CancelSettingButton;
        private System.Windows.Forms.ComboBox LiveTypeComboBox;
        private System.Windows.Forms.ComboBox AreaTypeComboBox;
        private System.Windows.Forms.Label AreaTypeLabel;
        private System.Windows.Forms.Label LiveTypeLabel;
        private System.Windows.Forms.Label SecondLabel;
        private System.Windows.Forms.Label MinLabel;
        private System.Windows.Forms.Label HourLabel;
        private System.Windows.Forms.TextBox SecondTextBox;
        private System.Windows.Forms.TextBox MinTextBox;
        private System.Windows.Forms.TextBox HourTextBox;
    }
}