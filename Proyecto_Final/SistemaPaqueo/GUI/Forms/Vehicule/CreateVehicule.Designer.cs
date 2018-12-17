namespace GUI.Forms.Vehicule
{
    partial class CreateVehicule
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.Txt_Plate = new System.Windows.Forms.TextBox();
            this.Txt_Colour = new System.Windows.Forms.TextBox();
            this.Txt_Model = new System.Windows.Forms.TextBox();
            this.Txt_Description = new System.Windows.Forms.TextBox();
            this.Cmb_Type = new System.Windows.Forms.ComboBox();
            this.Btn_Back = new System.Windows.Forms.Button();
            this.Btn_Register = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(63, 90);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Placa:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(63, 141);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Color:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(63, 188);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Modelo:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(63, 239);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(31, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Tipo:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(63, 281);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(66, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Descripción:";
            // 
            // Txt_Plate
            // 
            this.Txt_Plate.Location = new System.Drawing.Point(189, 82);
            this.Txt_Plate.Name = "Txt_Plate";
            this.Txt_Plate.Size = new System.Drawing.Size(100, 20);
            this.Txt_Plate.TabIndex = 5;
            // 
            // Txt_Colour
            // 
            this.Txt_Colour.Location = new System.Drawing.Point(189, 134);
            this.Txt_Colour.Name = "Txt_Colour";
            this.Txt_Colour.Size = new System.Drawing.Size(100, 20);
            this.Txt_Colour.TabIndex = 6;
            // 
            // Txt_Model
            // 
            this.Txt_Model.Location = new System.Drawing.Point(189, 181);
            this.Txt_Model.Name = "Txt_Model";
            this.Txt_Model.Size = new System.Drawing.Size(100, 20);
            this.Txt_Model.TabIndex = 7;
            // 
            // Txt_Description
            // 
            this.Txt_Description.Location = new System.Drawing.Point(189, 274);
            this.Txt_Description.Name = "Txt_Description";
            this.Txt_Description.Size = new System.Drawing.Size(100, 20);
            this.Txt_Description.TabIndex = 8;
            // 
            // Cmb_Type
            // 
            this.Cmb_Type.FormattingEnabled = true;
            this.Cmb_Type.Location = new System.Drawing.Point(189, 231);
            this.Cmb_Type.Name = "Cmb_Type";
            this.Cmb_Type.Size = new System.Drawing.Size(100, 21);
            this.Cmb_Type.TabIndex = 9;
            // 
            // Btn_Back
            // 
            this.Btn_Back.Location = new System.Drawing.Point(66, 388);
            this.Btn_Back.Name = "Btn_Back";
            this.Btn_Back.Size = new System.Drawing.Size(75, 23);
            this.Btn_Back.TabIndex = 10;
            this.Btn_Back.Text = "Volver";
            this.Btn_Back.UseVisualStyleBackColor = true;
            // 
            // Btn_Register
            // 
            this.Btn_Register.Location = new System.Drawing.Point(210, 388);
            this.Btn_Register.Name = "Btn_Register";
            this.Btn_Register.Size = new System.Drawing.Size(75, 23);
            this.Btn_Register.TabIndex = 11;
            this.Btn_Register.Text = "Registrar";
            this.Btn_Register.UseVisualStyleBackColor = true;
            // 
            // CreateVehicule
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(367, 450);
            this.Controls.Add(this.Btn_Register);
            this.Controls.Add(this.Btn_Back);
            this.Controls.Add(this.Cmb_Type);
            this.Controls.Add(this.Txt_Description);
            this.Controls.Add(this.Txt_Model);
            this.Controls.Add(this.Txt_Colour);
            this.Controls.Add(this.Txt_Plate);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "CreateVehicule";
            this.Text = "CreateVehicule";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox Txt_Plate;
        private System.Windows.Forms.TextBox Txt_Colour;
        private System.Windows.Forms.TextBox Txt_Model;
        private System.Windows.Forms.TextBox Txt_Description;
        private System.Windows.Forms.ComboBox Cmb_Type;
        private System.Windows.Forms.Button Btn_Back;
        private System.Windows.Forms.Button Btn_Register;
    }
}