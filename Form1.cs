using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FacFibExp
{
    public partial class Form1: Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void simpleButton3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnFactorial_Click(object sender, EventArgs e)
        {
            FrmFactorial factorial = new FrmFactorial();

            factorial.Show();
            this.Hide();
            
        }

        private void btnExponential_Click(object sender, EventArgs e)
        {
            FrmExponential exponential = new FrmExponential();

            exponential.Show();
            this.Hide();
        }

        private void btnFibonacci_Click(object sender, EventArgs e)
        {
            FrmFibonacci fibonacci = new FrmFibonacci();
            fibonacci.Show();
            this.Hide();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void labelControl2_Click(object sender, EventArgs e)
        {

        }
    }
}
