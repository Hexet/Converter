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
    public interface IInfoForm
    {
        string TextBox { set; }
        string NameForm { set; }
        void ShowForm();
    }
    public partial class InfoForm : Form, IInfoForm
    {
        public InfoForm()
        {
            InitializeComponent();
            
        }

        public string TextBox
        {
            set { textBox.Text = value; }
        }

        public string NameForm
        {
            set { this.Text = value; }
        }

        public void ShowForm()
        {
            this.Show();
        }
    }
}
