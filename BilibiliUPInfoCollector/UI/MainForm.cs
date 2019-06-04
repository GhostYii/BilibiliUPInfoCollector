using System;
using System.Threading;
using System.Windows.Forms;
using BilibiliUPInfoCollector.Data;
using BilibiliUPInfoCollector.Model;

namespace BilibiliUPInfoCollector.UI
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            General.Instance.Init();
            AutoCollectTimer.Interval = Setting.Default.Interval;
            AutoCollectTimer.Tag = "Stop";
            StatuLabel.Text = string.Format("当前状态：采集器已就绪，无自动采集任务。");
            CollectInfoListBox.Items.Clear();
        }

        private void OnManualCollectButtonClick(object sender, EventArgs e)
        {
            ManualCollectButton.Enabled = false;
            StatuLabel.Text = string.Format("当前状态：正在进行第{0}次手动采集任务。", ++General.Instance.collectCount);
            ManualCollectForm mcForm = new ManualCollectForm();
            mcForm.Start();
            DialogResult res = mcForm.ShowDialog();
            if (res == DialogResult.OK)
            {
                CollectInfoListBox.Items.Add(string.Format("[{0}]: 第{1}次手动采集信息成功！共采集到{2}条信息。", DateTime.Now.ToString("yyyy/MM/dd HH:mm:ss"), General.Instance.collectCount, General.Instance.rooms.Count));

                if (AutoCollectTimer.Tag.ToString().Equals("Start"))
                    StatuLabel.Text = string.Format("当前状态：自动采集已开启，下一次自动采集将于{0}启动，在此期间仍然可以手动进行采集。", General.Instance.prevTime.ToString("yyyy/MM/dd HH:mm:ss"));
                else
                    StatuLabel.Text = string.Format("当前状态：采集器已就绪，无自动采集任务。");

                CollectInfoListBox.SelectedIndex = CollectInfoListBox.Items.Count - 1;
                mcForm.Close();
            }
            else if (res == DialogResult.Cancel)
            {
                StatuLabel.Text = string.Format("当前状态：采集器已就绪，第{0}次手动采集任务已被取消。", General.Instance.collectCount--);
                mcForm.Close();
            }
            ManualCollectButton.Enabled = true;
        }

        private void OnAutoCollectButtonClick(object sender, EventArgs e)
        {
            AutoCollectAsync ac = new AutoCollectAsync();
            ac.StatuUpdate += StatuLabelUpdate;

            StatuLabel.Text = string.Format("当前状态：自动采集已开启，下一次自动采集将于{0}启动，在此期间仍然可以手动进行采集。", General.Instance.UpdateCollectTime());
            General.Instance.prevTime = DateTime.Now;
            General.Instance.prevTime = General.Instance.prevTime.AddMilliseconds(Setting.Default.Interval);
            AutoCollectTimer.Interval = Setting.Default.Interval;
            AutoCollectTimer.Tag = "Start";
            AutoCollectTimer.Start();
            StopCollectButton.Enabled = true;
            AutoCollectButton.Enabled = false;

        }

        private void OnMainFormClosing(object sender, FormClosingEventArgs e)
        {
            Properties.Settings.Default.Save();
        }

        private void AutoCollectTimerTick(object sender, EventArgs e)
        {
            AutoCollectTimer.Stop();
            AutoCollectTimer.Tag = "Stop";
            StatuLabel.Text = string.Format("当前状态：正在进行第{0}次自动采集。", ++General.Instance.collectCount);
            AutoCollectAsync ac = new AutoCollectAsync();
            ac.StatuUpdate += StatuLabelUpdate;
            ac.Accomplish += AccomplishCallBack;

            autoCollectThread = new Thread(new ThreadStart(ac.Invoke));
            autoCollectThread.IsBackground = true;
            autoCollectThread.Start();
        }

        private void OnStopCollectButtonClick(object sender, EventArgs e)
        {
            StatuLabel.Text = string.Format("当前状态：采集器已就绪，无自动采集任务。");
            if (autoCollectThread != null)
                autoCollectThread.Abort();
            AutoCollectTimer.Stop();
            AutoCollectTimer.Tag = "Stop";
            StopCollectButton.Enabled = false;
            AutoCollectButton.Enabled = true;
        }

        private void StatuLabelUpdate(string str)
        {
            if (InvokeRequired)
            {
                Invoke(new StringDelegate(delegate (string s)
                {
                    StatuLabel.Text = string.Format("当前状态：{0}", s);
                }), str);
            }
            else
                StatuLabel.Text = string.Format("当前状态：{0}", str);
        }

        private void AccomplishCallBack()
        {
            if (InvokeRequired)
            {
                Invoke(new VoidDelegate(delegate ()
                {
                    StatuLabel.Text = string.Format("当前状态：自动采集已开启，下一次自动采集将于{0}启动，在此期间仍然可以手动进行采集。", General.Instance.UpdateCollectTime());
                    CollectInfoListBox.Items.Add(string.Format("[{0}]: 第{1}次自动采集信息成功！共采集到{2}条信息。", DateTime.Now.ToString("yyyy/MM/dd HH:mm:ss"), General.Instance.collectCount, General.Instance.rooms.Count));
                    CollectInfoListBox.SelectedIndex = CollectInfoListBox.Items.Count - 1;
                    AutoCollectTimer.Start();
                    AutoCollectTimer.Tag = "Start";
                }));
            }
            else
            {
                StatuLabel.Text = string.Format("当前状态：自动采集已开启，下一次自动采集将于{0}启动，在此期间仍然可以手动进行采集。", General.Instance.UpdateCollectTime());
                CollectInfoListBox.Items.Add(string.Format("[{0}]: 第{1}次自动采集信息成功！共采集到{2}条信息。", DateTime.Now.ToString("yyyy/MM/dd HH:mm:ss"), General.Instance.collectCount, General.Instance.rooms.Count));
                CollectInfoListBox.SelectedIndex = CollectInfoListBox.Items.Count - 1;
                AutoCollectTimer.Start();
                AutoCollectTimer.Tag = "Start";
            }
        }

        private void OnSettingButtonClick(object sender, EventArgs e)
        {
            SettingForm sf = new SettingForm();
            sf.ShowDialog();
        }
    }
}
