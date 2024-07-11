namespace WindowsFormConexionBBDD
{
    partial class FormAnadirDepartment
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
            this.textBoxNombreDepartamento = new System.Windows.Forms.TextBox();
            this.textBoxLocalizacionDepartamento = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.buttonAnadirDept = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(0, 69);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombre";
            // 
            // textBoxNombreDepartamento
            // 
            this.textBoxNombreDepartamento.Location = new System.Drawing.Point(3, 85);
            this.textBoxNombreDepartamento.Name = "textBoxNombreDepartamento";
            this.textBoxNombreDepartamento.Size = new System.Drawing.Size(100, 20);
            this.textBoxNombreDepartamento.TabIndex = 1;
            // 
            // textBoxLocalizacionDepartamento
            // 
            this.textBoxLocalizacionDepartamento.Location = new System.Drawing.Point(205, 85);
            this.textBoxLocalizacionDepartamento.Name = "textBoxLocalizacionDepartamento";
            this.textBoxLocalizacionDepartamento.Size = new System.Drawing.Size(100, 20);
            this.textBoxLocalizacionDepartamento.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(202, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Localización";
            // 
            // buttonAnadirDept
            // 
            this.buttonAnadirDept.Location = new System.Drawing.Point(3, 145);
            this.buttonAnadirDept.Name = "buttonAnadirDept";
            this.buttonAnadirDept.Size = new System.Drawing.Size(169, 82);
            this.buttonAnadirDept.TabIndex = 4;
            this.buttonAnadirDept.Text = "Añadir";
            this.buttonAnadirDept.UseVisualStyleBackColor = true;
            this.buttonAnadirDept.Click += new System.EventHandler(this.buttonAnadirDept_Click);
            // 
            // FormAnadirDepartment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonAnadirDept);
            this.Controls.Add(this.textBoxLocalizacionDepartamento);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxNombreDepartamento);
            this.Controls.Add(this.label1);
            this.Name = "FormAnadirDepartment";
            this.Text = "FormAnadirDepartment";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxNombreDepartamento;
        private System.Windows.Forms.TextBox textBoxLocalizacionDepartamento;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button buttonAnadirDept;
    }
}