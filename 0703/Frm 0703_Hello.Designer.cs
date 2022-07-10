
namespace _0703
{
    partial class Frm_0703
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置受控資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_0703));
            this.Lab_Name = new System.Windows.Forms.Label();
            this.Lab_EName = new System.Windows.Forms.Label();
            this.Lab_gender = new System.Windows.Forms.Label();
            this.Lab_Constellation = new System.Windows.Forms.Label();
            this.TxbName = new System.Windows.Forms.TextBox();
            this.TxbEName = new System.Windows.Forms.TextBox();
            this.TxbGender = new System.Windows.Forms.TextBox();
            this.TxbCon = new System.Windows.Forms.TextBox();
            this.BtnHello = new System.Windows.Forms.Button();
            this.BtnHi = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Lab_Name
            // 
            this.Lab_Name.AutoSize = true;
            this.Lab_Name.BackColor = System.Drawing.Color.Transparent;
            this.Lab_Name.Font = new System.Drawing.Font("新細明體", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.Lab_Name.Location = new System.Drawing.Point(478, 65);
            this.Lab_Name.Name = "Lab_Name";
            this.Lab_Name.Size = new System.Drawing.Size(66, 21);
            this.Lab_Name.TabIndex = 0;
            this.Lab_Name.Text = "姓名 :";
            // 
            // Lab_EName
            // 
            this.Lab_EName.AutoSize = true;
            this.Lab_EName.BackColor = System.Drawing.Color.Transparent;
            this.Lab_EName.Font = new System.Drawing.Font("新細明體", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.Lab_EName.Location = new System.Drawing.Point(400, 120);
            this.Lab_EName.Name = "Lab_EName";
            this.Lab_EName.Size = new System.Drawing.Size(146, 21);
            this.Lab_EName.TabIndex = 1;
            this.Lab_EName.Text = "English Name :";
            // 
            // Lab_gender
            // 
            this.Lab_gender.AutoSize = true;
            this.Lab_gender.BackColor = System.Drawing.Color.Transparent;
            this.Lab_gender.Font = new System.Drawing.Font("新細明體", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.Lab_gender.Location = new System.Drawing.Point(479, 203);
            this.Lab_gender.Name = "Lab_gender";
            this.Lab_gender.Size = new System.Drawing.Size(66, 21);
            this.Lab_gender.TabIndex = 2;
            this.Lab_gender.Text = "性別 :";
            // 
            // Lab_Constellation
            // 
            this.Lab_Constellation.AutoSize = true;
            this.Lab_Constellation.BackColor = System.Drawing.Color.Transparent;
            this.Lab_Constellation.Font = new System.Drawing.Font("新細明體", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.Lab_Constellation.Location = new System.Drawing.Point(478, 272);
            this.Lab_Constellation.Name = "Lab_Constellation";
            this.Lab_Constellation.Size = new System.Drawing.Size(66, 21);
            this.Lab_Constellation.TabIndex = 3;
            this.Lab_Constellation.Text = "星座 :";
            // 
            // TxbName
            // 
            this.TxbName.Location = new System.Drawing.Point(551, 64);
            this.TxbName.Name = "TxbName";
            this.TxbName.Size = new System.Drawing.Size(183, 22);
            this.TxbName.TabIndex = 4;
            // 
            // TxbEName
            // 
            this.TxbEName.Location = new System.Drawing.Point(551, 120);
            this.TxbEName.Name = "TxbEName";
            this.TxbEName.Size = new System.Drawing.Size(183, 22);
            this.TxbEName.TabIndex = 5;
            // 
            // TxbGender
            // 
            this.TxbGender.Location = new System.Drawing.Point(551, 202);
            this.TxbGender.Name = "TxbGender";
            this.TxbGender.Size = new System.Drawing.Size(183, 22);
            this.TxbGender.TabIndex = 6;
            // 
            // TxbCon
            // 
            this.TxbCon.Location = new System.Drawing.Point(551, 272);
            this.TxbCon.Name = "TxbCon";
            this.TxbCon.Size = new System.Drawing.Size(183, 22);
            this.TxbCon.TabIndex = 7;
            // 
            // BtnHello
            // 
            this.BtnHello.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnHello.Location = new System.Drawing.Point(414, 347);
            this.BtnHello.Name = "BtnHello";
            this.BtnHello.Size = new System.Drawing.Size(130, 43);
            this.BtnHello.TabIndex = 8;
            this.BtnHello.Text = "Say Hello";
            this.BtnHello.UseVisualStyleBackColor = true;
            this.BtnHello.Click += new System.EventHandler(this.BtnHello_Click);
            // 
            // BtnHi
            // 
            this.BtnHi.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnHi.Location = new System.Drawing.Point(604, 347);
            this.BtnHi.Name = "BtnHi";
            this.BtnHi.Size = new System.Drawing.Size(130, 43);
            this.BtnHi.TabIndex = 9;
            this.BtnHi.Text = "Say Hi";
            this.BtnHi.UseVisualStyleBackColor = true;
            this.BtnHi.Click += new System.EventHandler(this.BtnHi_Click);
            // 
            // Frm_0703
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.BtnHi);
            this.Controls.Add(this.BtnHello);
            this.Controls.Add(this.TxbCon);
            this.Controls.Add(this.TxbGender);
            this.Controls.Add(this.TxbEName);
            this.Controls.Add(this.TxbName);
            this.Controls.Add(this.Lab_Constellation);
            this.Controls.Add(this.Lab_gender);
            this.Controls.Add(this.Lab_EName);
            this.Controls.Add(this.Lab_Name);
            this.Name = "Frm_0703";
            this.Text = "你好C#";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Lab_Name;
        private System.Windows.Forms.Label Lab_EName;
        private System.Windows.Forms.Label Lab_gender;
        private System.Windows.Forms.Label Lab_Constellation;
        private System.Windows.Forms.TextBox TxbName;
        private System.Windows.Forms.TextBox TxbEName;
        private System.Windows.Forms.TextBox TxbGender;
        private System.Windows.Forms.TextBox TxbCon;
        private System.Windows.Forms.Button BtnHello;
        private System.Windows.Forms.Button BtnHi;
    }
}

