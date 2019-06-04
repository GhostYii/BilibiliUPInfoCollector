using System;
using System.Collections.Generic;
using System.Windows.Forms;
using BilibiliUPInfoCollector.Data;
using BilibiliUPInfoCollector.Model;

namespace BilibiliUPInfoCollector.UI
{
    public partial class SettingForm : Form
    {
        private List<string[]> areaItems = new List<string[]>()
        {
            //娱乐
            new string[] {"全部", "视频唱见", "舞见", "视频聊天", "才艺", "虚拟主播", "美食", "户外", "手工", "萌宠", "学习", "映评馆", "音乐台"},
            //网游
            new string[] {"全部", "英雄联盟", "APEX", "绝地求生", "守望先锋", "Dota2", "Dota自走棋", "炉石传说", "地下城与勇士", "CS:GO", "魔兽世界"}, 
            //手游
            new string[] {"全部", "王者荣耀", "绝地求生：刺激战场"},
            //绘画
            new string[] {"全部"},
            //电台
            new string[] {"全部"},
            //单机
            new string[] {"全部", "主机游戏", "我的世界"}
        };


        public SettingForm()
        {
            InitializeComponent();
        }

        public void Init(object sender, EventArgs e)
        {
            LiveTypeComboBox.SelectedItem = LiveTypeComboBox.Items[Setting.Default.LiveType - 1];
            AreaTypeComboBox.Items.Clear();
            AreaTypeComboBox.Items.AddRange(areaItems[Setting.Default.LiveType - 1]);
            AreaTypeComboBox.SelectedItem = AreaTypeComboBox.Items[((AreaType)Setting.Default.AreaID).ToAreaTypeComboBoxIndex()];
            HourTextBox.Text = Setting.Default.IntervalHour.ToString();
            MinTextBox.Text = Setting.Default.IntervalMin.ToString();
            SecondTextBox.Text = Setting.Default.IntervalSecond.ToString();
        }

        private void OnLiveTypeComboBoxSelectedIndexChanged(object sender, EventArgs e)
        {
            AreaTypeComboBox.Items.Clear();
            AreaTypeComboBox.Items.AddRange(areaItems[LiveTypeComboBox.SelectedIndex]);
            AreaTypeComboBox.SelectedIndex = 0;
        }

        private void OnIntervalTextChanged(object sender, EventArgs e)
        {
            TextBox tb = sender as TextBox;
            int num = 0;
            try
            {
                num = Convert.ToInt32(tb.Text);
                if (tb.Name.Equals(HourTextBox.Name))
                {
                    Setting.Default.IntervalHour = Convert.ToInt32(tb.Text);
                }
                else if (tb.Name.Equals(MinTextBox.Name))
                {
                    Setting.Default.IntervalMin = Convert.ToInt32(tb.Text);
                }
                else if (tb.Name.Equals(SecondTextBox.Name))
                {
                    Setting.Default.IntervalSecond = Convert.ToInt32(tb.Text);
                }
            }
            catch (FormatException)
            { tb.Text = "0"; }
        }

        private void OnCancelButtonClick(object sender, EventArgs e)
        {
            Close();
        }

        private void OnOKButtonClick(object sender, EventArgs e)
        {
            Setting.Default.LiveType = LiveTypeComboBox.SelectedIndex + 1;
            Setting.Default.AreaID = (int)General.ToAreaTypeByName(AreaTypeComboBox.SelectedItem.ToString());
            Setting.Default.IntervalHour = Convert.ToInt32(HourTextBox.Text);
            Setting.Default.IntervalMin = Convert.ToInt32(MinTextBox.Text);
            Setting.Default.IntervalSecond = Convert.ToInt32(SecondTextBox.Text);

            Setting.Default.Save();
            Close();
        }
    }
}
