namespace GUI.Forms
{
    partial class CreateCompany
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
            this.Btn_Back = new System.Windows.Forms.Button();
            this.Btn_Register = new System.Windows.Forms.Button();
            this.Lbl_Name = new System.Windows.Forms.Label();
            this.Lbl_Phone = new System.Windows.Forms.Label();
            this.Txt_Name = new System.Windows.Forms.TextBox();
            this.Txt_Phone = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // Btn_Back
            // 
            this.Btn_Back.Location = new System.Drawing.Point(126, 376);
            this.Btn_Back.Name = "Btn_Back";
            this.Btn_Back.Size = new System.Drawing.Size(75, 23);
            this.Btn_Back.TabIndex = 0;
            this.Btn_Back.Text = "Volver";
            this.Btn_Back.UseVisualStyleBackColor = true;
            this.Btn_Back.Click += new System.EventHandler(this.Btn_Back_Click);
            // 
            // Btn_Register
            // 
            this.Btn_Register.Location = new System.Drawing.Point(332, 376);
            this.Btn_Register.Name = "Btn_Register";
            this.Btn_Register.Size = new System.Drawing.Size(75, 23);
            this.Btn_Register.TabIndex = 1;
            this.Btn_Register.Text = "Registrar";
            this.Btn_Register.UseVisualStyleBackColor = true;
            this.Btn_Register.Click += new System.EventHandler(this.Btn_Register_Click);
            // 
            // Lbl_Name
            // 
            this.Lbl_Name.AutoSize = true;
            this.Lbl_Name.Location = new System.Drawing.Point(84, 120);
            this.Lbl_Name.Name = "Lbl_Name";
            this.Lbl_Name.Size = new System.Drawing.Size(117, 13);
            this.Lbl_Name.TabIndex = 2;
            this.Lbl_Name.Text = "Nombre de la Empresa:";
            // 
            // Lbl_Phone
            // 
            this.Lbl_Phone.AutoSize = true;
            this.Lbl_Phone.Location = new System.Drawing.Point(149, 225);
            this.Lbl_Phone.Name = "Lbl_Phone";
            this.Lbl_Phone.Size = new System.Drawing.Size(52, 13);
            this.Lbl_Phone.TabIndex = 3;
            this.Lbl_Phone.Text = "Telefono:";
            // 
            // Txt_Name
            // 
            this.Txt_Name.Location = new System.Drawing.Point(332, 120);
            this.Txt_Name.Name = "Txt_Name";
            this.Txt_Name.Size = new System.Drawing.Size(181, 20);
            this.Txt_Name.TabIndex = 4;
            // 
            // Txt_Phone
            // 
            this.Txt_Phone.Location = new System.Drawing.Point(332, 217);
            this.Txt_Phone.MaxLength = 8;
            this.Txt_Phone.Name = "Txt_Phone";
            this.Txt_Phone.Size = new System.Drawing.Size(181, 20);
            this.Txt_Phone.TabIndex = 5;
            // 
            // CreateCompany
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(563, 450);
            this.Controls.Add(this.Txt_Phone);
            this.Controls.Add(this.Txt_Name);
            this.Controls.Add(this.Lbl_Phone);
            this.Controls.Add(this.Lbl_Name);
            this.Controls.Add(this.Btn_Register);
            this.Controls.Add(this.Btn_Back);
            this.Name = "CreateCompany";
            this.Text = "Crear Compañia.";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Btn_Back;
        private System.Windows.Forms.Button Btn_Register;
        private System.Windows.Forms.Label Lbl_Name;
        private System.Windows.Forms.Label Lbl_Phone;
        private System.Windows.Forms.TextBox Txt_Name;
        private System.Windows.Forms.TextBox Txt_Phone;
    }
}