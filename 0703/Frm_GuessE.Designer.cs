
namespace _0703
{
    partial class Frm_GuessE
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
            this.LabGShow = new System.Windows.Forms.Label();
            this.TxbGuess = new System.Windows.Forms.TextBox();
            this.BtnEnter = new System.Windows.Forms.Button();
            this.BtnCancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // LabGShow
            // 
            this.LabGShow.AutoSize = true;
            this.LabGShow.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabGShow.Location = new System.Drawing.Point(11, 26);
            this.LabGShow.Name = "LabGShow";
            this.LabGShow.Size = new System.Drawing.Size(281, 31);
            this.LabGShow.TabIndex = 0;
            this.LabGShow.Text = "Please input a number.";
            // 
            // TxbGuess
            // 
            this.TxbGuess.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxbGuess.Location = new System.Drawing.Point(31, 118);
            this.TxbGuess.Name = "TxbGuess";
            this.TxbGuess.Size = new System.Drawing.Size(261, 32);
            this.TxbGuess.TabIndex = 1;
            // 
            // BtnEnter
            // 
            this.BtnEnter.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnEnter.Location = new System.Drawing.Point(323, 27);
            this.BtnEnter.Name = "BtnEnter";
            this.BtnEnter.Size = new System.Drawing.Size(85, 35);
            this.BtnEnter.TabIndex = 2;
            this.BtnEnter.Text = "Enter";
            this.BtnEnter.UseVisualStyleBackColor = true;
            this.BtnEnter.Click += new System.EventHandler(this.BtnEnter_Click);
            // 
            // BtnCancel
            // 
            this.BtnCancel.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnCancel.Location = new System.Drawing.Point(323, 81);
            this.BtnCancel.Name = "BtnCancel";
            this.BtnCancel.Size = new System.Drawing.Size(85, 35);
            this.BtnCancel.TabIndex = 3;
            this.BtnCancel.Text = "Cancel";
            this.BtnCancel.UseVisualStyleBackColor = true;
            this.BtnCancel.Click += new System.EventHandler(this.BtnCancel_Click);
            // 
            // FrmGuessE
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(420, 162);
            this.Controls.Add(this.BtnCancel);
            this.Controls.Add(this.BtnEnter);
            this.Controls.Add(this.TxbGuess);
            this.Controls.Add(this.LabGShow);
            this.Name = "FrmGuessE";
            this.Text = "Guess";
            this.Load += new System.EventHandler(this.FrmGuessE_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LabGShow;
        private System.Windows.Forms.Button BtnCancel;
        public System.Windows.Forms.TextBox TxbGuess;
        public System.Windows.Forms.Button BtnEnter;
    }
}