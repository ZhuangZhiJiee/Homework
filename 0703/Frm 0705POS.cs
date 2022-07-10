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
    public partial class Frm_0705 : Form
    {
        public Frm_0705()
        {
            InitializeComponent();
        }

        int Bcount = 0;
        int Tcount = 0;
        int Wcount = 0;
        int Wicount = 0;
        int totalprice = 0;
        int Btotalprice = 0;
        int Ttotalprice = 0;
        int Wtotalprice = 0;
        int Witotalprice = 0;
        int sum = 0;
        private void BtnB_Click(object sender, EventArgs e)
        {
            Bcount++;
            Btotalprice = Bcount * 120;
            sum = Btotalprice + Ttotalprice + Wtotalprice + Witotalprice;
            Labshow.Text = "NT$ " + sum;
            Labshow2.Text = "啤酒Bear " + "X" + Bcount + ",共" + Bcount * 120 + "元" + "\n龍舌蘭Tequila " + "X" + Tcount + ",共NT$" + Tcount * 180 + "元"
                + "\n威士忌Wisky " + "X" + Wcount + ",共NT$" + Wcount * 350 + "元" + "\n紅酒Wine " + "X" + Wicount + ",共NT$" + Wicount * 320 + "元";
        }

        private void BtnD_Click(object sender, EventArgs e)
        {
            Tcount++;
            Ttotalprice = Tcount * 180;
            sum = Btotalprice + Ttotalprice + Wtotalprice + Witotalprice;
            Labshow.Text = "NT$ " + sum;
            Labshow2.Text = "啤酒Bear " + "X" + Bcount + ",共NT$" + Bcount * 120 + "元" + "\n龍舌蘭Tequila " + "X" + Tcount + ",共NT$" + Tcount * 180 + "元"
                + "\n威士忌Wisky " + "X" + Wcount + ", 共NT$" + Wcount * 350 + "元" + "\n紅酒Wine " + "X" + Wicount + ",共NT$" + Wicount * 320 + "元";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Wcount++;
            Wtotalprice = Wcount * 350;
            sum = Btotalprice + Ttotalprice + Wtotalprice + Witotalprice;
            Labshow.Text = "NT$ " + sum;
            Labshow2.Text = "啤酒Bear " + "X" + Bcount + ",共NT$" + Bcount * 120 + "元" + "\n龍舌蘭Tequila " + "X" + Tcount + ",共NT$" + Tcount * 180 + "元"
                + "\n威士忌Wisky " + "X" + Wcount + ",共NT$" + Wcount * 350 + "元" + "\n紅酒Wine " + "X" + Wicount + ",共NT$" + Wicount * 320 + "元";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Wicount++;
            Witotalprice = Wicount * 320;
            sum = Btotalprice + Ttotalprice + Wtotalprice + Witotalprice;
            Labshow.Text = "NT$ " + sum;
            Labshow2.Text = "啤酒Bear " + "X" + Bcount + ",共NT$" + Bcount * 120 + "元" + "\n龍舌蘭Tequila " + "X" + Tcount + ",共NT$" + Tcount * 180 + "元"
                + "\n威士忌Wisky " + "X" + Wcount + ",共NT$" + Wcount * 350 + "元" + "\n紅酒Wine " + "X" + Wicount + ",共NT$" + Wicount * 320 + "元";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            DialogResult resut = MessageBox.Show("總金額: " + sum, "確認付款", MessageBoxButtons.OKCancel);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            DialogResult resut = MessageBox.Show("總金額: " + sum + "\n折扣後金額: " + sum*0.9 , "確認付款", MessageBoxButtons.OKCancel);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Labshow.Text = "NT$ 0";
            Labshow2.Text = "尚未點餐";
        }
    }
}
