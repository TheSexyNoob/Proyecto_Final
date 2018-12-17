namespace GUI
{
    partial class Login
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
            this.LoginBtn = new System.Windows.Forms.Button();
            this.ExitBtn = new System.Windows.Forms.Button();
            this.Lbl_Code = new System.Windows.Forms.Label();
            this.Lbl_Password = new System.Windows.Forms.Label();
            this.Txt_Code = new System.Windows.Forms.TextBox();
            this.Txt_Password = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // LoginBtn
            // 
            this.LoginBtn.Location = new System.Drawing.Point(85, 238);
            this.LoginBtn.Name = "LoginBtn";
            this.LoginBtn.Size = new System.Drawing.Size(88, 25);
            this.LoginBtn.TabIndex = 0;
            this.LoginBtn.Text = "Login";
            this.LoginBtn.UseVisualStyleBackColor = true;
            this.LoginBtn.Click += new System.EventHandler(this.LoginBtn_Click);
            // 
            // ExitBtn
            // 
            this.ExitBtn.Location = new System.Drawing.Point(263, 238);
            this.ExitBtn.Name = "ExitBtn";
            this.ExitBtn.Size = new System.Drawing.Size(88, 25);
            this.ExitBtn.TabIndex = 1;
            this.ExitBtn.Text = "Exit";
            this.ExitBtn.UseVisualStyleBackColor = true;
            this.ExitBtn.Click += new System.EventHandler(this.ExitBtn_Click);
            // 
            // Lbl_Code
            // 
            this.Lbl_Code.AutoSize = true;
            this.Lbl_Code.Location = new System.Drawing.Point(183, 60);
            this.Lbl_Code.Name = "Lbl_Code";
            this.Lbl_Code.Size = new System.Drawing.Size(35, 13);
            this.Lbl_Code.TabIndex = 2;
            this.Lbl_Code.Text = "Code:";
            // 
            // Lbl_Password
            // 
            this.Lbl_Password.AutoSize = true;
            this.Lbl_Password.Location = new System.Drawing.Point(183, 143);
            this.Lbl_Password.Name = "Lbl_Password";
            this.Lbl_Password.Size = new System.Drawing.Size(56, 13);
            this.Lbl_Password.TabIndex = 3;
            this.Lbl_Password.Text = "Password:";
            // 
            // Txt_Code
            // 
            this.Txt_Code.AcceptsTab = true;
            this.Txt_Code.Location = new System.Drawing.Point(263, 57);
            this.Txt_Code.MaxLength = 4;
            this.Txt_Code.Name = "Txt_Code";
            this.Txt_Code.Size = new System.Drawing.Size(123, 20);
            this.Txt_Code.TabIndex = 4;
            // 
            // Txt_Password
            // 
            this.Txt_Password.Location = new System.Drawing.Point(263, 140);
            this.Txt_Password.MaxLength = 20;
            this.Txt_Password.Name = "Txt_Password";
            this.Txt_Password.Size = new System.Drawing.Size(123, 20);
            this.Txt_Password.TabIndex = 5;
            this.Txt_Password.UseSystemPasswordChar = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(23, 57);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(115, 103);
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(440, 311);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.Txt_Password);
            this.Controls.Add(this.Txt_Code);
            this.Controls.Add(this.Lbl_Password);
            this.Controls.Add(this.Lbl_Code);
            this.Controls.Add(this.ExitBtn);
            this.Controls.Add(this.LoginBtn);
            this.Name = "Login";
            this.Text = "Login";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button LoginBtn;
        private System.Windows.Forms.Button ExitBtn;
        private System.Windows.Forms.Label Lbl_Code;
        private System.Windows.Forms.Label Lbl_Password;
        private System.Windows.Forms.TextBox Txt_Code;
        private System.Windows.Forms.TextBox Txt_Password;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}