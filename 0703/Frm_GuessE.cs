using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _0703
{
    public partial class Frm_GuessE : Form
    {
        public Frm_GuessE()
        {
            InitializeComponent();
        }

        private void FrmGuessE_Load(object sender, EventArgs e)
        {
        }


        int myguess;

        Frm_Guess frmG = new Frm_Guess();

        public void BtnEnter_Click(object sender, EventArgs e)
        {
            
            myguess = Convert.ToInt32(TxbGuess.Text);


            if (Frm_Guess.result == myguess)
            {
                MessageBox.Show("Congratulations! You got " + myguess);
                this.Close();
                frmG.Guess();
            }
            else if (Frm_Guess.result > myguess)
            {

                Frm_Guess.min = myguess;
                MessageBox.Show("Too Small!!!" + "\nBetween " + Frm_Guess.min + " and " + Frm_Guess.max);
            }
            else 
            {
                Frm_Guess.max = myguess;
                MessageBox.Show("Too Large!!!" + "\nBetween " + Frm_Guess.min +  " and " + Frm_Guess.max);
            }
        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
