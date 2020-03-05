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
using System.Text.RegularExpressions;

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
            resultTextBox.Text = "0";
            butExecut.Click += ButExecut_Click;
            numP1.ValueChanged += NumP1_ValueChanged;
            numP2.ValueChanged += NumP2_ValueChanged;
            trackP1.ValueChanged += TrackP1_ValueChanged;
            trackP2.ValueChanged += TrackP2_ValueChanged;
            butExit.Click += Exit_Click;
            butHistory.Click += ButHistory_Click;
            this.KeyDown += MainForm_KeyDown;
            but0.Click += But_Click;
            but1.Click += But_Click;
            but2.Click += But_Click;
            but3.Click += But_Click;
            but4.Click += But_Click;
            but5.Click += But_Click;
            but6.Click += But_Click;
            but7.Click += But_Click;
            but8.Click += But_Click;
            but9.Click += But_Click;
            butA.Click += But_Click;
            butB.Click += But_Click;
            butC.Click += But_Click;
            butD.Click += But_Click;
            butE.Click += But_Click;
            butF.Click += But_Click;
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

        private void But_Click(object sender, EventArgs e)
        {
            if (sourceTextBox.Text == "0")
                sourceTextBox.Text = String.Empty;
            sourceTextBox.Text += (sender as Button).Text;
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
            sourceTextBox.Text = "0";
        }

        private void NumP2_ValueChanged(object sender, EventArgs e)
        {
            trackP2.Value = Convert.ToInt32(numP2.Value);
        }

        private void NumP1_ValueChanged(object sender, EventArgs e)
        {
            trackP1.Value = Convert.ToInt32(numP1.Value);
            Enabled_Num();
            sourceTextBox.Text = "0";
        }

        private void Enabled_Num()
        {
            var numberRegex = new Regex(@"[2-9]");
            var symbolRegex = new Regex(@"^[A-F]$");
            foreach (Button b in this.Controls.OfType<Button>())
            {
                if (numberRegex.IsMatch(b.Text))
                    b.Enabled = trackP1.Value > b.Text[0] - 48;

                else if (symbolRegex.IsMatch(b.Text))
                    b.Enabled = trackP1.Value > b.Text[0] - 55;
            }
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