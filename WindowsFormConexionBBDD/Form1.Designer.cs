namespace WindowsFormConexionBBDD
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.anadirEmployee = new System.Windows.Forms.Button();
            this.anadirDepartment = new System.Windows.Forms.Button();
            this.anadirJob = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // anadirEmployee
            // 
            this.anadirEmployee.Location = new System.Drawing.Point(61, 79);
            this.anadirEmployee.Name = "anadirEmployee";
            this.anadirEmployee.Size = new System.Drawing.Size(141, 81);
            this.anadirEmployee.TabIndex = 3;
            this.anadirEmployee.Text = "Añadir empleado";
            this.anadirEmployee.UseVisualStyleBackColor = true;
            this.anadirEmployee.Click += new System.EventHandler(this.anadirEmployee_Click);
            // 
            // anadirDepartment
            // 
            this.anadirDepartment.Location = new System.Drawing.Point(297, 79);
            this.anadirDepartment.Name = "anadirDepartment";
            this.anadirDepartment.Size = new System.Drawing.Size(141, 81);
            this.anadirDepartment.TabIndex = 4;
            this.anadirDepartment.Text = "Añadir departamento";
            this.anadirDepartment.UseVisualStyleBackColor = true;
            this.anadirDepartment.Click += new System.EventHandler(this.anadirDepartment_Click);
            // 
            // anadirJob
            // 
            this.anadirJob.Location = new System.Drawing.Point(539, 79);
            this.anadirJob.Name = "anadirJob";
            this.anadirJob.Size = new System.Drawing.Size(141, 81);
            this.anadirJob.TabIndex = 5;
            this.anadirJob.Text = "Añadir trabajo";
            this.anadirJob.UseVisualStyleBackColor = true;
            this.anadirJob.Click += new System.EventHandler(this.anadirJob_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.anadirJob);
            this.Controls.Add(this.anadirDepartment);
            this.Controls.Add(this.anadirEmployee);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }
        #endregion
        private System.Windows.Forms.Button anadirEmployee;
        private System.Windows.Forms.Button anadirDepartment;
        private System.Windows.Forms.Button anadirJob;
    }
}

