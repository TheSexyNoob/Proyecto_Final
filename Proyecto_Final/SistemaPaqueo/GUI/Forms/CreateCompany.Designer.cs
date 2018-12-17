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
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.Lbl_Name = new System.Windows.Forms.Label();
            this.Lbl_Phone = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(126, 376);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Volver";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(332, 376);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 1;
            this.button2.Text = "Registrar";
            this.button2.UseVisualStyleBackColor = true;
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
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(332, 120);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(181, 20);
            this.textBox1.TabIndex = 4;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(332, 217);
            this.textBox2.MaxLength = 8;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(181, 20);
            this.textBox2.TabIndex = 5;
            // 
            // CreateCompany
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(563, 450);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.Lbl_Phone);
            this.Controls.Add(this.Lbl_Name);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Name = "CreateCompany";
            this.Text = "Crear Compañia.";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label Lbl_Name;
        private System.Windows.Forms.Label Lbl_Phone;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
    }
}