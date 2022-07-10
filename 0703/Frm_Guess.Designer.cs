
namespace _0703
{
    partial class Frm_Guess
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
            this.LabShowG = new System.Windows.Forms.Label();
            this.BtnGuess = new System.Windows.Forms.Button();
            this.BtnShowAnswer = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // LabShowG
            // 
            this.LabShowG.AutoSize = true;
            this.LabShowG.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabShowG.Location = new System.Drawing.Point(81, 41);
            this.LabShowG.Name = "LabShowG";
            this.LabShowG.Size = new System.Drawing.Size(491, 31);
            this.LabShowG.TabIndex = 0;
            this.LabShowG.Text = "Please Select A Number between 1 to 100";
            // 
            // BtnGuess
            // 
            this.BtnGuess.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnGuess.Location = new System.Drawing.Point(97, 197);
            this.BtnGuess.Name = "BtnGuess";
            this.BtnGuess.Size = new System.Drawing.Size(134, 54);
            this.BtnGuess.TabIndex = 1;
            this.BtnGuess.Text = "Guess";
            this.BtnGuess.UseVisualStyleBackColor = true;
            this.BtnGuess.Click += new System.EventHandler(this.BtnGuess_Click);
            // 
            // BtnShowAnswer
            // 
            this.BtnShowAnswer.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnShowAnswer.Location = new System.Drawing.Point(357, 197);
            this.BtnShowAnswer.Name = "BtnShowAnswer";
            this.BtnShowAnswer.Size = new System.Drawing.Size(187, 54);
            this.BtnShowAnswer.TabIndex = 2;
            this.BtnShowAnswer.Text = "Show Answer";
            this.BtnShowAnswer.UseVisualStyleBackColor = true;
            this.BtnShowAnswer.Click += new System.EventHandler(this.BtnShowAnswer_Click);
            // 
            // Frm_Guess
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(677, 394);
            this.Controls.Add(this.BtnShowAnswer);
            this.Controls.Add(this.BtnGuess);
            this.Controls.Add(this.LabShowG);
            this.Name = "Frm_Guess";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Frm_Guess_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button BtnGuess;
        private System.Windows.Forms.Button BtnShowAnswer;
        public System.Windows.Forms.Label LabShowG;
    }
}