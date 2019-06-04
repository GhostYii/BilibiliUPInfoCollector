namespace BilibiliUPInfoCollector.UI
{
    partial class MainForm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.ManualCollectButton = new System.Windows.Forms.Button();
            this.LogGroupBox = new System.Windows.Forms.GroupBox();
            this.CollectInfoListBox = new System.Windows.Forms.ListBox();
            this.StatuGroupBox = new System.Windows.Forms.GroupBox();
            this.StatuLabel = new System.Windows.Forms.Label();
            this.ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.QueryUPStatuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.DepCollectionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ImportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ImportAllInfoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ImportSpecialUpInfoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.SettingStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.AboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MainTopMenuStrip = new System.Windows.Forms.MenuStrip();
            this.StopCollectButton = new System.Windows.Forms.Button();
            this.AutoCollectButton = new System.Windows.Forms.Button();
            this.AutoCollectTimer = new System.Windows.Forms.Timer(this.components);
            this.LogGroupBox.SuspendLayout();
            this.StatuGroupBox.SuspendLayout();
            this.MainTopMenuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // ManualCollectButton
            // 
            this.ManualCollectButton.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.ManualCollectButton.Location = new System.Drawing.Point(525, 485);
            this.ManualCollectButton.Name = "ManualCollectButton";
            this.ManualCollectButton.Size = new System.Drawing.Size(127, 48);
            this.ManualCollectButton.TabIndex = 2;
            this.ManualCollectButton.Text = "手动采集";
            this.ManualCollectButton.UseVisualStyleBackColor = true;
            this.ManualCollectButton.Click += new System.EventHandler(this.OnManualCollectButtonClick);
            // 
            // LogGroupBox
            // 
            this.LogGroupBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LogGroupBox.Controls.Add(this.CollectInfoListBox);
            this.LogGroupBox.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.LogGroupBox.Location = new System.Drawing.Point(12, 92);
            this.LogGroupBox.Name = "LogGroupBox";
            this.LogGroupBox.Size = new System.Drawing.Size(640, 387);
            this.LogGroupBox.TabIndex = 1;
            this.LogGroupBox.TabStop = false;
            this.LogGroupBox.Text = "采集信息（双击查看详细采集信息）";
            // 
            // CollectInfoListBox
            // 
            this.CollectInfoListBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.CollectInfoListBox.BackColor = System.Drawing.SystemColors.Control;
            this.CollectInfoListBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.CollectInfoListBox.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.CollectInfoListBox.FormattingEnabled = true;
            this.CollectInfoListBox.ItemHeight = 21;
            this.CollectInfoListBox.Items.AddRange(new object[] {
            "[2019/04/19 16:00:21] : 第1次采集成功！共采集到326个直播间信息。",
            "[2019/04/19 17:00:21] : 第2次采集成功！共采集到297个直播间信息。"});
            this.CollectInfoListBox.Location = new System.Drawing.Point(6, 16);
            this.CollectInfoListBox.Name = "CollectInfoListBox";
            this.CollectInfoListBox.Size = new System.Drawing.Size(628, 336);
            this.CollectInfoListBox.TabIndex = 0;
            // 
            // StatuGroupBox
            // 
            this.StatuGroupBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.StatuGroupBox.Controls.Add(this.StatuLabel);
            this.StatuGroupBox.Location = new System.Drawing.Point(13, 29);
            this.StatuGroupBox.Name = "StatuGroupBox";
            this.StatuGroupBox.Size = new System.Drawing.Size(639, 57);
            this.StatuGroupBox.TabIndex = 3;
            this.StatuGroupBox.TabStop = false;
            this.StatuGroupBox.Text = "状态信息";
            // 
            // StatuLabel
            // 
            this.StatuLabel.AutoSize = true;
            this.StatuLabel.Location = new System.Drawing.Point(19, 22);
            this.StatuLabel.Name = "StatuLabel";
            this.StatuLabel.Size = new System.Drawing.Size(365, 24);
            this.StatuLabel.TabIndex = 0;
            this.StatuLabel.Text = "当前状态：自动采集已启动，下一次采集将于2019/xx/xx xx:xx进行\r\n\r\n";
            // 
            // ToolStripMenuItem
            // 
            this.ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.QueryUPStatuToolStripMenuItem,
            this.DepCollectionToolStripMenuItem,
            this.ImportToolStripMenuItem});
            this.ToolStripMenuItem.Enabled = false;
            this.ToolStripMenuItem.Name = "ToolStripMenuItem";
            this.ToolStripMenuItem.Size = new System.Drawing.Size(44, 21);
            this.ToolStripMenuItem.Text = "工具";
            // 
            // QueryUPStatuToolStripMenuItem
            // 
            this.QueryUPStatuToolStripMenuItem.Name = "QueryUPStatuToolStripMenuItem";
            this.QueryUPStatuToolStripMenuItem.Size = new System.Drawing.Size(173, 22);
            this.QueryUPStatuToolStripMenuItem.Text = "查询UP直播状态...";
            // 
            // DepCollectionToolStripMenuItem
            // 
            this.DepCollectionToolStripMenuItem.Name = "DepCollectionToolStripMenuItem";
            this.DepCollectionToolStripMenuItem.Size = new System.Drawing.Size(173, 22);
            this.DepCollectionToolStripMenuItem.Text = "单独采集UP信息";
            // 
            // ImportToolStripMenuItem
            // 
            this.ImportToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ImportAllInfoToolStripMenuItem,
            this.ImportSpecialUpInfoToolStripMenuItem});
            this.ImportToolStripMenuItem.Name = "ImportToolStripMenuItem";
            this.ImportToolStripMenuItem.Size = new System.Drawing.Size(173, 22);
            this.ImportToolStripMenuItem.Text = "导出";
            // 
            // ImportAllInfoToolStripMenuItem
            // 
            this.ImportAllInfoToolStripMenuItem.Name = "ImportAllInfoToolStripMenuItem";
            this.ImportAllInfoToolStripMenuItem.Size = new System.Drawing.Size(176, 22);
            this.ImportAllInfoToolStripMenuItem.Text = "导出所有采集信息";
            // 
            // ImportSpecialUpInfoToolStripMenuItem
            // 
            this.ImportSpecialUpInfoToolStripMenuItem.Name = "ImportSpecialUpInfoToolStripMenuItem";
            this.ImportSpecialUpInfoToolStripMenuItem.Size = new System.Drawing.Size(176, 22);
            this.ImportSpecialUpInfoToolStripMenuItem.Text = "仅导出指定UP信息";
            // 
            // SettingStripMenuItem
            // 
            this.SettingStripMenuItem.Name = "SettingStripMenuItem";
            this.SettingStripMenuItem.Size = new System.Drawing.Size(44, 21);
            this.SettingStripMenuItem.Text = "设置";
            this.SettingStripMenuItem.Click += new System.EventHandler(this.OnSettingButtonClick);
            // 
            // AboutToolStripMenuItem
            // 
            this.AboutToolStripMenuItem.Enabled = false;
            this.AboutToolStripMenuItem.Name = "AboutToolStripMenuItem";
            this.AboutToolStripMenuItem.Size = new System.Drawing.Size(44, 21);
            this.AboutToolStripMenuItem.Text = "关于";
            // 
            // MainTopMenuStrip
            // 
            this.MainTopMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ToolStripMenuItem,
            this.SettingStripMenuItem,
            this.AboutToolStripMenuItem});
            this.MainTopMenuStrip.Location = new System.Drawing.Point(0, 0);
            this.MainTopMenuStrip.Name = "MainTopMenuStrip";
            this.MainTopMenuStrip.Size = new System.Drawing.Size(664, 25);
            this.MainTopMenuStrip.TabIndex = 2;
            // 
            // StopCollectButton
            // 
            this.StopCollectButton.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.StopCollectButton.Enabled = false;
            this.StopCollectButton.Location = new System.Drawing.Point(265, 485);
            this.StopCollectButton.Name = "StopCollectButton";
            this.StopCollectButton.Size = new System.Drawing.Size(254, 48);
            this.StopCollectButton.TabIndex = 1;
            this.StopCollectButton.Text = "停止自动采集";
            this.StopCollectButton.UseVisualStyleBackColor = true;
            this.StopCollectButton.Click += new System.EventHandler(this.OnStopCollectButtonClick);
            // 
            // AutoCollectButton
            // 
            this.AutoCollectButton.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.AutoCollectButton.Location = new System.Drawing.Point(12, 485);
            this.AutoCollectButton.Name = "AutoCollectButton";
            this.AutoCollectButton.Size = new System.Drawing.Size(247, 48);
            this.AutoCollectButton.TabIndex = 0;
            this.AutoCollectButton.Text = "开始自动采集";
            this.AutoCollectButton.UseVisualStyleBackColor = true;
            this.AutoCollectButton.Click += new System.EventHandler(this.OnAutoCollectButtonClick);
            // 
            // AutoCollectTimer
            // 
            this.AutoCollectTimer.Interval = 1800000;
            this.AutoCollectTimer.Tick += new System.EventHandler(this.AutoCollectTimerTick);
            // 
            // MainForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.ClientSize = new System.Drawing.Size(664, 536);
            this.Controls.Add(this.AutoCollectButton);
            this.Controls.Add(this.StopCollectButton);
            this.Controls.Add(this.StatuGroupBox);
            this.Controls.Add(this.LogGroupBox);
            this.Controls.Add(this.ManualCollectButton);
            this.Controls.Add(this.MainTopMenuStrip);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(680, 250);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Bilibili直播学习区主播信息采集器-Demo";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.OnMainFormClosing);
            this.LogGroupBox.ResumeLayout(false);
            this.StatuGroupBox.ResumeLayout(false);
            this.StatuGroupBox.PerformLayout();
            this.MainTopMenuStrip.ResumeLayout(false);
            this.MainTopMenuStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Threading.Thread autoCollectThread;

        private System.Windows.Forms.Button ManualCollectButton;
        private System.Windows.Forms.GroupBox LogGroupBox;
        private System.Windows.Forms.GroupBox StatuGroupBox;
        private System.Windows.Forms.Label StatuLabel;
        private System.Windows.Forms.ListBox CollectInfoListBox;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem QueryUPStatuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem DepCollectionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ImportToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ImportAllInfoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ImportSpecialUpInfoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem SettingStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem AboutToolStripMenuItem;
        private System.Windows.Forms.MenuStrip MainTopMenuStrip;
        private System.Windows.Forms.Button StopCollectButton;
        private System.Windows.Forms.Button AutoCollectButton;
        private System.Windows.Forms.Timer AutoCollectTimer;
    }
}

