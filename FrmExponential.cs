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
    public partial class FrmExponential: Form
    {
        public FrmExponential()
        {
            InitializeComponent();
        }

        private void simpleButton3_Click(object sender, EventArgs e)
        {
            Form1 frm = new Form1();
            frm.Show();
            this.Hide();
        }

        private void btnExpo_Click(object sender, EventArgs e)
        {

            if (int.Parse(inputExpo.Text) > 10 && int.Parse(inputPower.Text) > 10)
            {
                resultExpo.Text = "Too long!";
            }
            else if (int.Parse(inputExpo.Text) >= 15 && int.Parse(inputPower.Text) > 10)
            {
                resultExpo.Text = "Too long!";
            }
            else if (int.Parse(inputExpo.Text) >= 10 && int.Parse(inputPower.Text) > 25)
            {
                resultExpo.Text = "Too long!";
            }
            else {
                long result = calculateExponential(int.Parse(inputExpo.Text), int.Parse(inputPower.Text));
                resultExpo.Text = result.ToString();
            }
               
        }


        public long calculateExponential(int number, int exponent) {

            if (exponent == 0)
            {
                return 1;
            }
            else {
                return number * calculateExponential(number, exponent - 1);
            
            }
        }

        private void FrmExponential_Load(object sender, EventArgs e)
        {

        }
    }
}
