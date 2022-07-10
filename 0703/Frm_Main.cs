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
    public partial class Frm_Main : Form
    {
        public Frm_Main()
        {
            InitializeComponent();
        }

        private void Btn0703_Click(object sender, EventArgs e)
        {
            Frm_0703 hel = new Frm_0703();
            hel.Show();
        }

        private void Btn0704_Click(object sender, EventArgs e)
        {
            Frm_0704 Loan = new Frm_0704();
            Loan.Show();
        }

        private void Btn0705_Click(object sender, EventArgs e)
        {
            Frm_0705 POS = new Frm_0705();
            POS.Show();
        }

        private void Btn0708_Click(object sender, EventArgs e)
        {
            Frm_0708_Student_Structureform SS = new Frm_0708_Student_Structureform();
            SS.Show();
        }

        private void Btn0711_Click(object sender, EventArgs e)
        {
            Frm_0711 Cal = new Frm_0711();
            Cal.Show();
        }

        private void BtnGuess_Click(object sender, EventArgs e)
        {
            Frm_Guess Gue = new Frm_Guess();
            Gue.Show();
        }
    }
}
