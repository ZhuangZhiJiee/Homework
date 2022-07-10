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
    public partial class Frm_0711 : Form
    {
        public Frm_0711()
        {
            InitializeComponent();
        }

 

        private void BtnP_Click(object sender, EventArgs e)
        {
            int result;
            result = Convert.ToInt32(TxbN1.Text) + Convert.ToInt32(TxbN2.Text);
            TxbN3.Text = result.ToString();
        }

        private void BtnN_Click(object sender, EventArgs e)
        {
            int result;
            result = Convert.ToInt32(TxbN1.Text) - Convert.ToInt32(TxbN2.Text);
            TxbN3.Text = result.ToString();
        }

        private void BtnT_Click(object sender, EventArgs e)
        {
            int result;
            result = Convert.ToInt32(TxbN1.Text) * Convert.ToInt32(TxbN2.Text);
            TxbN3.Text = result.ToString();
        }

        private void BtnR_Click(object sender, EventArgs e)
        {
            int result;
            result = Convert.ToInt32(TxbN1.Text) / Convert.ToInt32(TxbN2.Text);
            TxbN3.Text = result.ToString();
        }
    }
}
