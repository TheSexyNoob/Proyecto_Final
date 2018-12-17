namespace GUI.Forms.User
{
    partial class CreateClient
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
            this.Btn_Close = new System.Windows.Forms.Button();
            this.Btn_Register = new System.Windows.Forms.Button();
            this.Txt_ID = new System.Windows.Forms.TextBox();
            this.Txt_Name = new System.Windows.Forms.TextBox();
            this.Lbl_ID = new System.Windows.Forms.Label();
            this.Lbl_Name = new System.Windows.Forms.Label();
            this.Cmb_Company = new System.Windows.Forms.ComboBox();
            this.Lbl_Company = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Btn_Close
            // 
            this.Btn_Close.Location = new System.Drawing.Point(54, 382);
            this.Btn_Close.Name = "Btn_Close";
            this.Btn_Close.Size = new System.Drawing.Size(75, 23);
            this.Btn_Close.TabIndex = 0;
            this.Btn_Close.Text = "Cerrar";
            this.Btn_Close.UseVisualStyleBackColor = true;
            this.Btn_Close.Click += new System.EventHandler(this.Btn_Close_Click);
            // 
            // Btn_Register
            // 
            this.Btn_Register.Location = new System.Drawing.Point(188, 382);
            this.Btn_Register.Name = "Btn_Register";
            this.Btn_Register.Size = new System.Drawing.Size(75, 23);
            this.Btn_Register.TabIndex = 1;
            this.Btn_Register.Text = "Registrar";
            this.Btn_Register.UseVisualStyleBackColor = true;
            this.Btn_Register.Click += new System.EventHandler(this.Btn_Register_Click);
            // 
            // Txt_ID
            // 
            this.Txt_ID.Location = new System.Drawing.Point(163, 75);
            this.Txt_ID.Name = "Txt_ID";
            this.Txt_ID.Size = new System.Drawing.Size(100, 20);
            this.Txt_ID.TabIndex = 2;
            // 
            // Txt_Name
            // 
            this.Txt_Name.Location = new System.Drawing.Point(163, 139);
            this.Txt_Name.Name = "Txt_Name";
            this.Txt_Name.Size = new System.Drawing.Size(100, 20);
            this.Txt_Name.TabIndex = 3;
            // 
            // Lbl_ID
            // 
            this.Lbl_ID.AutoSize = true;
            this.Lbl_ID.Location = new System.Drawing.Point(43, 81);
            this.Lbl_ID.Name = "Lbl_ID";
            this.Lbl_ID.Size = new System.Drawing.Size(43, 13);
            this.Lbl_ID.TabIndex = 4;
            this.Lbl_ID.Text = "Cedula:";
            // 
            // Lbl_Name
            // 
            this.Lbl_Name.AutoSize = true;
            this.Lbl_Name.Location = new System.Drawing.Point(46, 145);
            this.Lbl_Name.Name = "Lbl_Name";
            this.Lbl_Name.Size = new System.Drawing.Size(47, 13);
            this.Lbl_Name.TabIndex = 5;
            this.Lbl_Name.Text = "Nombre:";
            // 
            // Cmb_Company
            // 
            this.Cmb_Company.FormattingEnabled = true;
            this.Cmb_Company.Location = new System.Drawing.Point(163, 217);
            this.Cmb_Company.Name = "Cmb_Company";
            this.Cmb_Company.Size = new System.Drawing.Size(100, 21);
            this.Cmb_Company.TabIndex = 6;
            // 
            // Lbl_Company
            // 
            this.Lbl_Company.AutoSize = true;
            this.Lbl_Company.Location = new System.Drawing.Point(49, 224);
            this.Lbl_Company.Name = "Lbl_Company";
            this.Lbl_Company.Size = new System.Drawing.Size(51, 13);
            this.Lbl_Company.TabIndex = 7;
            this.Lbl_Company.Text = "Empresa:";
            // 
            // CreateClient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(299, 450);
            this.Controls.Add(this.Lbl_Company);
            this.Controls.Add(this.Cmb_Company);
            this.Controls.Add(this.Lbl_Name);
            this.Controls.Add(this.Lbl_ID);
            this.Controls.Add(this.Txt_Name);
            this.Controls.Add(this.Txt_ID);
            this.Controls.Add(this.Btn_Register);
            this.Controls.Add(this.Btn_Close);
            //this.Name = "CreateClient";
            this.Text = "Crear CLiente";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Btn_Close;
        private System.Windows.Forms.Button Btn_Register;
        private System.Windows.Forms.TextBox Txt_ID;
        private System.Windows.Forms.TextBox Txt_Name;
        private System.Windows.Forms.Label Lbl_ID;
        private System.Windows.Forms.Label Lbl_Name;
        private System.Windows.Forms.ComboBox Cmb_Company;
        private System.Windows.Forms.Label Lbl_Company;
    }
}