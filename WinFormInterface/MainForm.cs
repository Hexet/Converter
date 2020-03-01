using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Input;

namespace WinFormInterface
{
    public interface IMainForm
    {
        string InitialNumber { get; }
        string Result { set; get; }
        int P1 { get; }
        int P2 { get; }
        event EventHandler ExecutClick;
        event EventHandler HistoryClick;
        event EventHandler HelpClick;
    }


    public partial class MainForm : Form, IMainForm
    {
        public MainForm()
        {
            InitializeComponent();
            sourceTextBox.Text = "0";
            butExecut.Click += ButExecut_Click;
            numP1.ValueChanged += NumP1_ValueChanged;
            numP2.ValueChanged += NumP2_ValueChanged;
            trackP1.ValueChanged += TrackP1_ValueChanged;
            trackP2.ValueChanged += TrackP2_ValueChanged;
            butExit.Click += Exit_Click;
            butHistory.Click += ButHistory_Click;
            this.KeyDown += MainForm_KeyDown;
            but0.Click += But0_Click;
            but1.Click += But1_Click;
            but2.Click += But2_Click;
            but3.Click += But3_Click;
            but4.Click += But4_Click;
            but5.Click += But5_Click;
            but6.Click += But6_Click;
            but7.Click += But7_Click;
            but8.Click += But8_Click;
            but9.Click += But9_Click;
            butA.Click += ButA_Click;
            butB.Click += ButB_Click;
            butC.Click += ButC_Click;
            butD.Click += ButD_Click;
            butE.Click += ButE_Click;
            butF.Click += ButF_Click;
            butDel.Click += ButDel_Click;
            butCE.Click += ButCE_Click;
            butPoint.Click += ButPoint_Click;
            butHelp.Click += ButHelp_Click;
        }

        private void ButHelp_Click(object sender, EventArgs e)
        {
            HelpClick(this, null);
        }

        private void ButPoint_Click(object sender, EventArgs e)
        {
            if (sourceTextBox.Text == "0")
                sourceTextBox.Text = "0.";
            else
                if (!sourceTextBox.Text.Contains("."))
                    sourceTextBox.Text += ".";
        }

        private void ButCE_Click(object sender, EventArgs e)
        {
            sourceTextBox.Text = "0";
            resultTextBox.Text = "0";
        }

        private void ButDel_Click(object sender, EventArgs e)
        {
            if (sourceTextBox.Text != String.Empty)
            {
                sourceTextBox.Text = sourceTextBox.Text.Substring(0, sourceTextBox.Text.Length - 1);
                if (sourceTextBox.Text == String.Empty)
                    sourceTextBox.Text = "0";
            }
        }

        private void ButF_Click(object sender, EventArgs e)
        {
            if (sourceTextBox.Text == "0")
                sourceTextBox.Text = String.Empty;
            sourceTextBox.Text += 'F';
        }

        private void ButE_Click(object sender, EventArgs e)
        {
            if (sourceTextBox.Text == "0")
                sourceTextBox.Text = String.Empty;
            sourceTextBox.Text += 'E';
        }

        private void ButD_Click(object sender, EventArgs e)
        {
            if (sourceTextBox.Text == "0")
                sourceTextBox.Text = String.Empty;
            sourceTextBox.Text += 'D';
        }

        private void ButC_Click(object sender, EventArgs e)
        {
            if (sourceTextBox.Text == "0")
                sourceTextBox.Text = String.Empty;
            sourceTextBox.Text += 'C';
        }

        private void ButB_Click(object sender, EventArgs e)
        {
            if (sourceTextBox.Text == "0")
                sourceTextBox.Text = String.Empty;
            sourceTextBox.Text += 'B';
        }

        private void ButA_Click(object sender, EventArgs e)
        {
            if (sourceTextBox.Text == "0")
                sourceTextBox.Text = String.Empty;
            sourceTextBox.Text += 'A';
        }

        private void But9_Click(object sender, EventArgs e)
        {
            if (sourceTextBox.Text == "0")
                sourceTextBox.Text = String.Empty;
            sourceTextBox.Text += 9;
        }

        private void But8_Click(object sender, EventArgs e)
        {
            if (sourceTextBox.Text == "0")
                sourceTextBox.Text = String.Empty;
            sourceTextBox.Text += 8;
        }

        private void But7_Click(object sender, EventArgs e)
        {
            if (sourceTextBox.Text == "0")
                sourceTextBox.Text = String.Empty;
            sourceTextBox.Text += 7;
        }

        private void But6_Click(object sender, EventArgs e)
        {
            if (sourceTextBox.Text == "0")
                sourceTextBox.Text = String.Empty;
            sourceTextBox.Text += 6;
        }

        private void But5_Click(object sender, EventArgs e)
        {
            if (sourceTextBox.Text == "0")
                sourceTextBox.Text = String.Empty;
            sourceTextBox.Text += 5;
        }

        private void But4_Click(object sender, EventArgs e)
        {
            if (sourceTextBox.Text == "0")
                sourceTextBox.Text = String.Empty;
            sourceTextBox.Text += 4;
        }

        private void But3_Click(object sender, EventArgs e)
        {
            if (sourceTextBox.Text == "0")
                sourceTextBox.Text = String.Empty;
            sourceTextBox.Text += 3;
        }

        private void But2_Click(object sender, EventArgs e)
        {
            if (sourceTextBox.Text == "0")
                sourceTextBox.Text = String.Empty;
            sourceTextBox.Text += 2;
        }

        private void But1_Click(object sender, EventArgs e)
        {
            if (sourceTextBox.Text == "0")
                sourceTextBox.Text = String.Empty;
            sourceTextBox.Text += 1;
        }
        private void But0_Click(object sender, EventArgs e)
        {
            if (sourceTextBox.Text != "0")
                sourceTextBox.Text += 0;
        }

        private void MainForm_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
                ExecutClick(butExecut, null);
            if (e.KeyData == Keys.Back && sourceTextBox.Text != String.Empty)
            {
                sourceTextBox.Text = sourceTextBox.Text.Substring(0, sourceTextBox.Text.Length - 1);
                if (sourceTextBox.Text == String.Empty)
                    sourceTextBox.Text = "0";
            }
            if (e.KeyValue > 47 && e.KeyValue < 58 && trackP1.Value > e.KeyValue - 48)
            {
                if (sourceTextBox.Text == "0")
                    sourceTextBox.Text = String.Empty;
                sourceTextBox.Text += e.KeyValue - 48;
            }
            if (e.KeyValue > 64 && e.KeyValue < 71 && trackP1.Value > e.KeyValue - 55)
            {
                if (sourceTextBox.Text == "0")
                    sourceTextBox.Text = String.Empty;
                sourceTextBox.Text += (char)e.KeyValue;
            }
            if (e.KeyData == Keys.OemPeriod)
            {
                if (sourceTextBox.Text == "0")
                    sourceTextBox.Text = String.Empty;
                ButPoint_Click(this, null);
            }
            if (e.KeyData == Keys.Delete)
                ButCE_Click(this, null);
        }

        private void ButHistory_Click(object sender, EventArgs e)
        {
            HistoryClick(this, EventArgs.Empty);
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void TrackP2_ValueChanged(object sender, EventArgs e)
        {
            numP2.Value = trackP2.Value;
        }

        private void TrackP1_ValueChanged(object sender, EventArgs e)
        {
            numP1.Value = trackP1.Value;
            Enabled_Num();
            sourceTextBox.Text = String.Empty;
        }

        private void NumP2_ValueChanged(object sender, EventArgs e)
        {
            trackP2.Value = Convert.ToInt32(numP2.Value);
        }

        private void NumP1_ValueChanged(object sender, EventArgs e)
        {
            trackP1.Value = Convert.ToInt32(numP1.Value);
            Enabled_Num();
            sourceTextBox.Text = String.Empty;
        }

        private void Enabled_Num()
        {
            but2.Enabled = trackP1.Value > 2;
            but3.Enabled = trackP1.Value > 3;
            but4.Enabled = trackP1.Value > 4;
            but5.Enabled = trackP1.Value > 5;
            but6.Enabled = trackP1.Value > 6;
            but7.Enabled = trackP1.Value > 7;
            but8.Enabled = trackP1.Value > 8;
            but9.Enabled = trackP1.Value > 9;
            butA.Enabled = trackP1.Value > 10;
            butB.Enabled = trackP1.Value > 11;
            butC.Enabled = trackP1.Value > 12;
            butD.Enabled = trackP1.Value > 13;
            butE.Enabled = trackP1.Value > 14;
            butF.Enabled = trackP1.Value > 15;
        }

        private void ButExecut_Click(object sender, EventArgs e)
        {
            ExecutClick(this, EventArgs.Empty);
        }

        public string InitialNumber
        {
            get { return sourceTextBox.Text; }
        }

        public string Result
        {
            set { resultTextBox.Text = value; }
            get { return resultTextBox.Text; }
        }

        public int P1
        {
            get { return trackP1.Value; }
        }

        public int P2
        {
            get { return trackP2.Value; }
        }

        public event EventHandler ExecutClick;
        public event EventHandler HistoryClick;
        public event EventHandler HelpClick;
    }
}