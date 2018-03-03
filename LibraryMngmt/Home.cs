using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LibraryMngmt
{
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();  
        }

        void myButton_Click(Object sender, System.EventArgs e)
        {
            MessageBox.Show("Click");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            New_Student newstd = new New_Student();
            this.Hide();
            newstd.ShowDialog();
            this.Close();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button7_Click(object sender, EventArgs e)
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {
            IssuePage issuepage = new IssuePage();
            this.Hide();
            issuepage.ShowDialog();
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Return returnbk = new Return();
            this.Hide();
            returnbk.ShowDialog();
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            NewBook newbk = new NewBook();
            this.Hide();
            newbk.ShowDialog();
            this.Close();
        }
    }
}
