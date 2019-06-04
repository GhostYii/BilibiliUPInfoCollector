using System.Windows.Forms;
using BilibiliUPInfoCollector.Data;
using System.Threading;
using BilibiliUPInfoCollector.Model;

namespace BilibiliUPInfoCollector.UI
{
    public partial class ManualCollectForm : Form
    {
        public ManualCollectForm()
        {
            InitializeComponent();
        }

        public void Start()
        {
            ManualCollectAsync mc = new ManualCollectAsync();
            mc.UIStepDelegate += ProgressBarUpdate;
            mc.UIProgressBarValueSetDelegate += ProgressBarValueSet;
            mc.UITipTextDelegate += ProcessUpdate;
            mc.UICountTextDelegate += CountUpdate;
            mc.TaskCallBack += Accomplish;

            mcThread = new Thread(new ThreadStart(mc.Invoke));
            mcThread.IsBackground = true;
            mcThread.Start();
        }

        private void ProgressBarUpdate(int step)
        {
            if (InvokeRequired)
            {
                Invoke(new IntDelegate(delegate (int s)
                {
                    ProgressBar.Value = s;
                }), step);
            }
            else
                ProgressBar.Value = step;
        }

        private void ProgressBarValueSet(int value)
        {
            if (InvokeRequired)
            {
                Invoke(new IntDelegate(delegate (int s)
                {
                    ProgressBar.Minimum = 1;
                    ProgressBar.Maximum = s;
                }), value);
            }
            else
            {
                ProgressBar.Minimum = 1;
                ProgressBar.Maximum = value;
            }               
        }

        private void ProcessUpdate(string str)
        {
            if (InvokeRequired)
            {
                Invoke(new StringDelegate(delegate (string s)
                {
                    ProcessLabel.Text = s;
                }), str);
            }
            else
                ProcessLabel.Text = str;
        }

        private void CountUpdate(string str)
        {
            if (InvokeRequired)
            {
                Invoke(new StringDelegate(delegate (string s)
                {
                    CountLabel.Text = s;
                }), str);
            }
            else
                CountLabel.Text = str;
        }

        private void Accomplish()
        {
            if (InvokeRequired)
            {
                Invoke(new VoidDelegate(delegate ()
                {
                    ProcessLabel.Text = "采集完成！";
                }));
            }
            else
                ProcessLabel.Text = "采集完成！";
            DialogResult = DialogResult.OK;
        }

        private void OnFormClosing(object sender, FormClosingEventArgs e)
        {
            if (mcThread != null && mcThread.IsAlive)
            {
                mcThread.Abort();
            }
            Dispose();
        }
    }
}
