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
    public partial class Frm_Guess : Form
    {
        public Frm_Guess()
        {
            InitializeComponent();

        }
        //public static int result, min, max;
        Random rm = new Random();

       
        public void Guess()
        {
            min = 1;
            max = 100;
            result = rm.Next(1, 100);
        }

        private void Frm_Guess_Load(object sender, EventArgs e)
        {
            Guess();
        }



        public void changeLabel1()
        {
            LabShowG.Text = "Too Small!!!" + "\nBetween " + min + "and" + max; 
        }

        public void changeLabel2()
        {
            LabShowG.Text = "Too Large!!!" + "\nBetween " + min + "and" + max;
        }

        public static int result, min, max;

        private void BtnShowAnswer_Click(object sender, EventArgs e)
        {
            MessageBox.Show("answer: " + result);

        }

    
        public void BtnGuess_Click(object sender, EventArgs e)
        {
            Frm_GuessE guessE = new Frm_GuessE();
            guessE.Show();
        }
    }
}
