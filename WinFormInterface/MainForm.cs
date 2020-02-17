using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormInterface
{
    public interface IMainForm
    {
        string InitialNumber { get; }
        string Result { set; }
        int P1 { get; }
        int P2 { get; }
        event EventHandler ExecutClick;
    }

    public partial class MainForm : Form, IMainForm
    {
        public MainForm()
        {
            InitializeComponent();
            butExecut.Click += ButExecut_Click;
            numP1.ValueChanged += NumP1_ValueChanged;
            numP2.ValueChanged += NumP2_ValueChanged;
            trackP1.ValueChanged += TrackP1_ValueChanged;
            trackP2.ValueChanged += TrackP2_ValueChanged;
        }

        private void TrackP2_ValueChanged(object sender, EventArgs e)
        {
            numP2.Value = trackP2.Value;
        }

        private void TrackP1_ValueChanged(object sender, EventArgs e)
        {
            numP1.Value = trackP1.Value;
        }

        private void NumP2_ValueChanged(object sender, EventArgs e)
        {
            trackP2.Value = Convert.ToInt32(numP2.Value);
        }

        private void NumP1_ValueChanged(object sender, EventArgs e)
        {
            trackP1.Value = Convert.ToInt32(numP1.Value);
        }

        private void ButExecut_Click(object sender, EventArgs e)
        {
            if (ExecutClick != null) ExecutClick(this, EventArgs.Empty);
        }

        public string InitialNumber
        {
            get { return sourceTextBox.Text; }
        }

        public string Result
        {
            set { resultTextBox.Text = value; }
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

    }
}
