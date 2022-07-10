
namespace _0703
{
    partial class Frm_0704
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.Lab_money = new System.Windows.Forms.Label();
            this.Lab_Year = new System.Windows.Forms.Label();
            this.Lab_rat = new System.Windows.Forms.Label();
            this.Lab_pay = new System.Windows.Forms.Label();
            this.TxbM = new System.Windows.Forms.TextBox();
            this.TxbY = new System.Windows.Forms.TextBox();
            this.Txb_rat = new System.Windows.Forms.TextBox();
            this.Txb_Pay = new System.Windows.Forms.TextBox();
            this.BtnMP = new System.Windows.Forms.Button();
            this.BtnTP = new System.Windows.Forms.Button();
            this.BtnR = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Lab_money
            // 
            this.Lab_money.AutoSize = true;
            this.Lab_money.Font = new System.Drawing.Font("標楷體", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.Lab_money.Location = new System.Drawing.Point(99, 89);
            this.Lab_money.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Lab_money.Name = "Lab_money";
            this.Lab_money.Size = new System.Drawing.Size(114, 21);
            this.Lab_money.TabIndex = 0;
            this.Lab_money.Text = "貸款金額 ";
            // 
            // Lab_Year
            // 
            this.Lab_Year.AutoSize = true;
            this.Lab_Year.Font = new System.Drawing.Font("標楷體", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.Lab_Year.Location = new System.Drawing.Point(99, 171);
            this.Lab_Year.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Lab_Year.Name = "Lab_Year";
            this.Lab_Year.Size = new System.Drawing.Size(115, 21);
            this.Lab_Year.TabIndex = 1;
            this.Lab_Year.Text = "期限(年) ";
            // 
            // Lab_rat
            // 
            this.Lab_rat.AutoSize = true;
            this.Lab_rat.Font = new System.Drawing.Font("標楷體", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.Lab_rat.Location = new System.Drawing.Point(99, 260);
            this.Lab_rat.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Lab_rat.Name = "Lab_rat";
            this.Lab_rat.Size = new System.Drawing.Size(56, 21);
            this.Lab_rat.TabIndex = 2;
            this.Lab_rat.Text = "利率";
            // 
            // Lab_pay
            // 
            this.Lab_pay.AutoSize = true;
            this.Lab_pay.Font = new System.Drawing.Font("標楷體", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.Lab_pay.Location = new System.Drawing.Point(99, 348);
            this.Lab_pay.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Lab_pay.Name = "Lab_pay";
            this.Lab_pay.Size = new System.Drawing.Size(79, 21);
            this.Lab_pay.TabIndex = 3;
            this.Lab_pay.Text = "頭期款";
            // 
            // TxbM
            // 
            this.TxbM.Location = new System.Drawing.Point(279, 89);
            this.TxbM.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.TxbM.Name = "TxbM";
            this.TxbM.Size = new System.Drawing.Size(216, 26);
            this.TxbM.TabIndex = 4;
            this.TxbM.Text = "100000";
            // 
            // TxbY
            // 
            this.TxbY.Location = new System.Drawing.Point(279, 177);
            this.TxbY.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.TxbY.Name = "TxbY";
            this.TxbY.Size = new System.Drawing.Size(216, 26);
            this.TxbY.TabIndex = 5;
            this.TxbY.Text = "2";
            // 
            // Txb_rat
            // 
            this.Txb_rat.Location = new System.Drawing.Point(279, 260);
            this.Txb_rat.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Txb_rat.Name = "Txb_rat";
            this.Txb_rat.Size = new System.Drawing.Size(216, 26);
            this.Txb_rat.TabIndex = 6;
            this.Txb_rat.Text = "10";
            // 
            // Txb_Pay
            // 
            this.Txb_Pay.Location = new System.Drawing.Point(279, 347);
            this.Txb_Pay.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Txb_Pay.Name = "Txb_Pay";
            this.Txb_Pay.Size = new System.Drawing.Size(216, 26);
            this.Txb_Pay.TabIndex = 7;
            this.Txb_Pay.Text = "0";
            // 
            // BtnMP
            // 
            this.BtnMP.Location = new System.Drawing.Point(105, 453);
            this.BtnMP.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.BtnMP.Name = "BtnMP";
            this.BtnMP.Size = new System.Drawing.Size(174, 79);
            this.BtnMP.TabIndex = 8;
            this.BtnMP.Text = "PMT(月付";
            this.BtnMP.UseVisualStyleBackColor = true;
            this.BtnMP.Click += new System.EventHandler(this.BtnMP_Click);
            // 
            // BtnTP
            // 
            this.BtnTP.Location = new System.Drawing.Point(358, 453);
            this.BtnTP.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.BtnTP.Name = "BtnTP";
            this.BtnTP.Size = new System.Drawing.Size(174, 79);
            this.BtnTP.TabIndex = 9;
            this.BtnTP.Text = "總付款";
            this.BtnTP.UseVisualStyleBackColor = true;
            this.BtnTP.Click += new System.EventHandler(this.BtnTP_Click);
            // 
            // BtnR
            // 
            this.BtnR.Location = new System.Drawing.Point(604, 453);
            this.BtnR.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.BtnR.Name = "BtnR";
            this.BtnR.Size = new System.Drawing.Size(174, 79);
            this.BtnR.TabIndex = 10;
            this.BtnR.Text = "Report";
            this.BtnR.UseVisualStyleBackColor = true;
            this.BtnR.Click += new System.EventHandler(this.BtnR_Click);
            // 
            // Frm_0704
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(821, 550);
            this.Controls.Add(this.BtnR);
            this.Controls.Add(this.BtnTP);
            this.Controls.Add(this.BtnMP);
            this.Controls.Add(this.Txb_Pay);
            this.Controls.Add(this.Txb_rat);
            this.Controls.Add(this.TxbY);
            this.Controls.Add(this.TxbM);
            this.Controls.Add(this.Lab_pay);
            this.Controls.Add(this.Lab_rat);
            this.Controls.Add(this.Lab_Year);
            this.Controls.Add(this.Lab_money);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Frm_0704";
            this.Text = "貸款金額試算";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Lab_money;
        private System.Windows.Forms.Label Lab_Year;
        private System.Windows.Forms.Label Lab_rat;
        private System.Windows.Forms.Label Lab_pay;
        private System.Windows.Forms.TextBox TxbM;
        private System.Windows.Forms.TextBox TxbY;
        private System.Windows.Forms.TextBox Txb_rat;
        private System.Windows.Forms.TextBox Txb_Pay;
        private System.Windows.Forms.Button BtnMP;
        private System.Windows.Forms.Button BtnTP;
        private System.Windows.Forms.Button BtnR;
    }
}