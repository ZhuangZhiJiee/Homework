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
    public partial class Frm_0703 : Form
    {
        public Frm_0703()
        {
            InitializeComponent();
        }

        private void BtnHello_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Hello,我是" + TxbName.Text + ",\n英文名字是" + TxbEName.Text +
                ", \n性別是" + TxbGender.Text + ",\n星座是" + TxbCon.Text + ", \n很高興認識你。");
        }

        private void BtnHi_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Hi,我是" + TxbName.Text + ",\n英文名字是" + TxbEName.Text +
                ", \n性別是" + TxbGender.Text + ",\n星座是" + TxbCon.Text + ", \n很高興認識你。");
        }
    }
}
