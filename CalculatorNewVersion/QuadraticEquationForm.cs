using System;
using System.Drawing;
using System.Windows.Forms;

namespace SimpleCalculator
{
    public partial class QuadraticEquationForm : Form
    {
        public QuadraticEquationForm()
        {
            InitializeComponent();
        }

        public string a => tbA.Text;
        public string b => tbB.Text;
        public string c => tbC.Text;

         

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void tbA_KeyPress(object sender, KeyPressEventArgs e)
        {
            //if (!char.IsDigit(e.KeyChar))
            //{
            //    e.Handled = true;
            //    tbA.BackColor = Color.FromArgb(255, 153, 153);
            //    tbA.Text.Trim();
            //}
            //else tbA.BackColor = Color.White;
        }

        private void tbB_KeyPress(object sender, KeyPressEventArgs e)
        {
            //if (!char.IsDigit(e.KeyChar))
            //{
            //    e.Handled = true;
            //    tbB.BackColor = Color.FromArgb(255, 153, 153);
            //    tbB.Text.Trim();
            //}
            //else tbB.BackColor = Color.White;
        }

        private void tbC_KeyPress(object sender, KeyPressEventArgs e)
        {
            //if (!char.IsDigit(e.KeyChar))
            //{
            //    e.Handled = true;
            //    tbC.BackColor = Color.FromArgb(255, 153, 153);
            //    tbC.Text.Trim();
            //}
            //else tbC.BackColor = Color.White;
        }
    }
}
