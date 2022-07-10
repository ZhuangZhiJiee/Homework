
namespace _0703
{
    partial class Frm_0711
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
            this.Lab_Num1 = new System.Windows.Forms.Label();
            this.TxbN1 = new System.Windows.Forms.TextBox();
            this.Lab_Num2 = new System.Windows.Forms.Label();
            this.TxbN2 = new System.Windows.Forms.TextBox();
            this.Lab_ANW = new System.Windows.Forms.Label();
            this.TxbN3 = new System.Windows.Forms.TextBox();
            this.BtnP = new System.Windows.Forms.Button();
            this.BtnN = new System.Windows.Forms.Button();
            this.BtnT = new System.Windows.Forms.Button();
            this.BtnR = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Lab_Num1
            // 
            this.Lab_Num1.AutoSize = true;
            this.Lab_Num1.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lab_Num1.Location = new System.Drawing.Point(12, 30);
            this.Lab_Num1.Name = "Lab_Num1";
            this.Lab_Num1.Size = new System.Drawing.Size(71, 24);
            this.Lab_Num1.TabIndex = 0;
            this.Lab_Num1.Text = "Num1:";
            // 
            // TxbN1
            // 
            this.TxbN1.Location = new System.Drawing.Point(88, 31);
            this.TxbN1.Name = "TxbN1";
            this.TxbN1.Size = new System.Drawing.Size(75, 22);
            this.TxbN1.TabIndex = 2;
            // 
            // Lab_Num2
            // 
            this.Lab_Num2.AutoSize = true;
            this.Lab_Num2.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lab_Num2.Location = new System.Drawing.Point(12, 91);
            this.Lab_Num2.Name = "Lab_Num2";
            this.Lab_Num2.Size = new System.Drawing.Size(71, 24);
            this.Lab_Num2.TabIndex = 3;
            this.Lab_Num2.Text = "Num2:";
            // 
            // TxbN2
            // 
            this.TxbN2.Location = new System.Drawing.Point(87, 93);
            this.TxbN2.Name = "TxbN2";
            this.TxbN2.Size = new System.Drawing.Size(76, 22);
            this.TxbN2.TabIndex = 4;
            // 
            // Lab_ANW
            // 
            this.Lab_ANW.AutoSize = true;
            this.Lab_ANW.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lab_ANW.Location = new System.Drawing.Point(12, 187);
            this.Lab_ANW.Name = "Lab_ANW";
            this.Lab_ANW.Size = new System.Drawing.Size(84, 24);
            this.Lab_ANW.TabIndex = 5;
            this.Lab_ANW.Text = "Answer:";
            // 
            // TxbN3
            // 
            this.TxbN3.Location = new System.Drawing.Point(102, 190);
            this.TxbN3.Name = "TxbN3";
            this.TxbN3.Size = new System.Drawing.Size(61, 22);
            this.TxbN3.TabIndex = 6;
            // 
            // BtnP
            // 
            this.BtnP.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnP.Location = new System.Drawing.Point(189, 25);
            this.BtnP.Name = "BtnP";
            this.BtnP.Size = new System.Drawing.Size(44, 25);
            this.BtnP.TabIndex = 7;
            this.BtnP.TabStop = false;
            this.BtnP.Text = "+";
            this.BtnP.UseVisualStyleBackColor = true;
            this.BtnP.Click += new System.EventHandler(this.BtnP_Click);
            // 
            // BtnN
            // 
            this.BtnN.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnN.Location = new System.Drawing.Point(189, 61);
            this.BtnN.Name = "BtnN";
            this.BtnN.Size = new System.Drawing.Size(44, 25);
            this.BtnN.TabIndex = 8;
            this.BtnN.TabStop = false;
            this.BtnN.Text = "-";
            this.BtnN.UseVisualStyleBackColor = true;
            this.BtnN.Click += new System.EventHandler(this.BtnN_Click);
            // 
            // BtnT
            // 
            this.BtnT.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnT.Location = new System.Drawing.Point(189, 97);
            this.BtnT.Name = "BtnT";
            this.BtnT.Size = new System.Drawing.Size(44, 25);
            this.BtnT.TabIndex = 9;
            this.BtnT.TabStop = false;
            this.BtnT.Text = "*";
            this.BtnT.UseVisualStyleBackColor = true;
            this.BtnT.Click += new System.EventHandler(this.BtnT_Click);
            // 
            // BtnR
            // 
            this.BtnR.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnR.Location = new System.Drawing.Point(189, 133);
            this.BtnR.Name = "BtnR";
            this.BtnR.Size = new System.Drawing.Size(44, 25);
            this.BtnR.TabIndex = 10;
            this.BtnR.TabStop = false;
            this.BtnR.Text = "/";
            this.BtnR.UseVisualStyleBackColor = true;
            this.BtnR.Click += new System.EventHandler(this.BtnR_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(2, 172);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(356, 12);
            this.label1.TabIndex = 11;
            this.label1.Text = "= = = = = = = = = = = = = = = = = = = = = = =  = = = = = = = = = = = = = = = =";
            // 
            // Frm_0711
            // 
            this.AccessibleRole = System.Windows.Forms.AccessibleRole.Grip;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(267, 271);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BtnR);
            this.Controls.Add(this.BtnT);
            this.Controls.Add(this.BtnN);
            this.Controls.Add(this.BtnP);
            this.Controls.Add(this.TxbN3);
            this.Controls.Add(this.Lab_ANW);
            this.Controls.Add(this.TxbN2);
            this.Controls.Add(this.Lab_Num2);
            this.Controls.Add(this.TxbN1);
            this.Controls.Add(this.Lab_Num1);
            this.Name = "Frm_0711";
            this.Text = "Frm_0711";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Lab_Num1;
        private System.Windows.Forms.TextBox TxbN1;
        private System.Windows.Forms.Label Lab_Num2;
        private System.Windows.Forms.TextBox TxbN2;
        private System.Windows.Forms.Label Lab_ANW;
        private System.Windows.Forms.TextBox TxbN3;
        private System.Windows.Forms.Button BtnP;
        private System.Windows.Forms.Button BtnN;
        private System.Windows.Forms.Button BtnT;
        private System.Windows.Forms.Button BtnR;
        private System.Windows.Forms.Label label1;
    }
}