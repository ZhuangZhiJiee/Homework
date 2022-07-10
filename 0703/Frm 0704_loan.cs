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
    public partial class Frm_0704 : Form
    {
        public Frm_0704()
        {
            InitializeComponent();
        }


        public string money;
        public string year;
        public string rate;
        public string downpay;
            

        private void BtnTP_Click(object sender, EventArgs e)
        {
            money = TxbM.Text;
            year = TxbY.Text;
            rate = Txb_rat.Text;
            downpay = Txb_Pay.Text;

            double a1 = double.Parse(money);
            double a2 = double.Parse(year) * 12;
            double a3 = double.Parse(downpay);
            double a4 = double.Parse(rate) / 100;
            double a5 = a4 / 12;
            double a6 = (Math.Pow((1 + a5), a2) * a5) / (Math.Pow((1 + a5), a2) - 1);
            double a7 = a1 - a3;
            double a8 = Math.Floor(a7 * a6);
            double a9 = Math.Floor(a8 * a2);

            MessageBox.Show("月付" + a9 + "元");
        }

        private void BtnMP_Click(object sender, EventArgs e)
        {
            money = TxbM.Text;
            year = TxbY.Text;
            rate = Txb_rat.Text;
            downpay = Txb_Pay.Text;

            double a1 = double.Parse(money);
            double a2 = double.Parse(year)*12;
            double a3 = double.Parse(downpay);
            double a4 = double.Parse(rate) / 100;
            double a5 = a4 / 12;
            double a6 = (Math.Pow((1 + a5), a2)*a5) / (Math.Pow((1 + a5), a2) - 1);
            double a7 = a1 - a3;
            double a8 = Math.Floor(a7 * a6);

            MessageBox.Show("月付" + a8 + "元");

        }

        public void BtnR_Click(object sender, EventArgs e)
        {
            Frm0704Report report = new Frm0704Report();
            report.Show();

            money = TxbM.Text;
            year = TxbY.Text;
            rate = Txb_rat.Text;
            downpay = Txb_Pay.Text;

            double a1 = double.Parse(money);
            double a2 = double.Parse(year) * 12;
            double a3 = double.Parse(downpay);
            double a4 = double.Parse(rate) / 100;
            double a5 = a4 / 12;
            double a6 = (Math.Pow((1 + a5), a2) * a5) / (Math.Pow((1 + a5), a2) - 1);
            double a7 = a1 - a3;
            double a8 = Math.Floor(a7 * a6);
            double a9 = Math.Floor(a8 * a2);


            report.LabSM.Text = TxbM.Text;
            report.label1.Text = TxbY.Text;
            report.label2.Text = Txb_rat.Text;
            report.label3.Text = a8.ToString();
            report.label4.Text = a9.ToString();


        }
    }
}
