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
    public partial class FrmFibonacci: Form
    {
        public FrmFibonacci()
        {
            InitializeComponent();
        }

        private void simpleButton3_Click(object sender, EventArgs e)
        {
            Form1 frm = new Form1();
            frm.Show();
            this.Hide();
        }

        private void btnFib_Click(object sender, EventArgs e)
        {

            if (int.Parse(inputFib.Text) > 11)
            {
                resultFib.Text = "at most 11 series can be shown";

            }
            else {
                string result = fibonacciCalculator(int.Parse(inputFib.Text), 0 , 1);
                resultFib.Text = "1 "+result;
            }
               
        }

        
        public string fibonacciCalculator(int enough, int a, int b) {



            if (enough > 1)
            {
                int c = a + b;


                return c + " " + fibonacciCalculator(enough - 1, b, c);

            }
            else if (enough < 0) {
                return "No recursive of Negatives!";
            }
            else {
                return "";
            }
           
        }

        private void FrmFibonacci_Load(object sender, EventArgs e)
        {

        }
    }
}
