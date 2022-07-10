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
    public partial class Frm_0708_Student_Structureform : Form
    {
        public Frm_0708_Student_Structureform()
        {
            InitializeComponent();
        }

        string  Name;
        string highSubject;
        string lowerSubject;
        decimal highscore;
        decimal lowscore;
        decimal Chinesegrade;
        decimal Englishgrade;
        decimal Mathgrade;
        
        private void BtnSave_Click(object sender, EventArgs e)
        {
            
           Name = TxbN.Text;
           Chinesegrade = decimal.Parse(TxbC.Text);
           Englishgrade = decimal.Parse(TxbE.Text);
           Mathgrade = decimal.Parse(TxbM.Text);
        }

        private void BtnShow_Click(object sender, EventArgs e)
        {
        
            LabShow1.Text = "姓名: " + Name + "\n國文: " + Chinesegrade + "分" + "\n英文: " + Englishgrade + "分" + "\n數學: " + Mathgrade + "分";
        }

        private void button1_Click(object sender, EventArgs e)
        {

            decimal[] scores = { Chinesegrade, Englishgrade, Mathgrade};
            Array.Sort(scores);
            highscore = scores[2];
            lowscore = scores[0];

            Dictionary<string, decimal> dict = new Dictionary<string, decimal>();

            dict.Add("國文", Chinesegrade);
            dict.Add("英文", Englishgrade);
            dict.Add("數學", Mathgrade);

            foreach (var val in dict)
            {
 
                if( val.Value == highscore) 
                {
                    highSubject = val.Key;
                }
                if (val.Value == lowscore)
                {
                    lowerSubject = val.Key;
                }
            }
          LabShow2.Text = "最高科目成績為: " + highSubject +":"+  scores[2]+ "分" + "\n最低科目成績為: " + lowerSubject + ":" + scores[0]+ "分";
        }


    }
}
