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
    public partial class FrmFactorial: Form
    {
        public FrmFactorial()
        {
            InitializeComponent();
        }

        private void simpleButton3_Click(object sender, EventArgs e)
        {
            Form1 frm = new Form1();
            frm.Show();
            this.Hide();
        }

        private void btnFac_Click(object sender, EventArgs e)
        {
            int factorialNumber = int.Parse(inputFac.Text);
            display(factorialNumber);
          

        }


        public void display(int givenNumber) {
            if (givenNumber < 0) {
                resultFac.Text = "Negatives are not accepted!";
            }
            else if (givenNumber > 20) {
                resultFac.Text = "only values 0-20 are valid!";
            
            }
            else
            {
                resultFac.Text = factorialCalculator(givenNumber).ToString();
            }
        
        }
        
        public long factorialCalculator(int givenNumber) {

            if (givenNumber == 1 || givenNumber == 0) {
                return 1;
            }
            else {
                return givenNumber * factorialCalculator(givenNumber - 1);
            } 
        }

        private void FrmFactorial_Load(object sender, EventArgs e)
        {

        }
    }
}
