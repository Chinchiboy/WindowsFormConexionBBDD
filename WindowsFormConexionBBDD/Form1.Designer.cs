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
            this.buttonVerEmpleados = new System.Windows.Forms.Button();
            this.buttonVerDepts = new System.Windows.Forms.Button();
            this.buttonVerTrabajo = new System.Windows.Forms.Button();
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
            this.anadirJob.Location = new System.Drawing.Point(526, 79);
            this.anadirJob.Name = "anadirJob";
            this.anadirJob.Size = new System.Drawing.Size(141, 81);
            this.anadirJob.TabIndex = 5;
            this.anadirJob.Text = "Añadir trabajo";
            this.anadirJob.UseVisualStyleBackColor = true;
            this.anadirJob.Click += new System.EventHandler(this.anadirJob_Click);
            // 
            // buttonVerEmpleados
            // 
            this.buttonVerEmpleados.Location = new System.Drawing.Point(61, 212);
            this.buttonVerEmpleados.Name = "buttonVerEmpleados";
            this.buttonVerEmpleados.Size = new System.Drawing.Size(141, 81);
            this.buttonVerEmpleados.TabIndex = 6;
            this.buttonVerEmpleados.Text = "Ver empleado";
            this.buttonVerEmpleados.UseVisualStyleBackColor = true;
            this.buttonVerEmpleados.Click += new System.EventHandler(this.buttonVerEmpleados_Click);
            // 
            // buttonVerDepts
            // 
            this.buttonVerDepts.Location = new System.Drawing.Point(297, 212);
            this.buttonVerDepts.Name = "buttonVerDepts";
            this.buttonVerDepts.Size = new System.Drawing.Size(141, 81);
            this.buttonVerDepts.TabIndex = 7;
            this.buttonVerDepts.Text = "Ver departamentos";
            this.buttonVerDepts.UseVisualStyleBackColor = true;
            this.buttonVerDepts.Click += new System.EventHandler(this.buttonVerDepts_Click);
            // 
            // buttonVerTrabajo
            // 
            this.buttonVerTrabajo.Location = new System.Drawing.Point(526, 212);
            this.buttonVerTrabajo.Name = "buttonVerTrabajo";
            this.buttonVerTrabajo.Size = new System.Drawing.Size(141, 81);
            this.buttonVerTrabajo.TabIndex = 8;
            this.buttonVerTrabajo.Text = "Ver trabajo";
            this.buttonVerTrabajo.UseVisualStyleBackColor = true;
            this.buttonVerTrabajo.Click += new System.EventHandler(this.buttonVerTrabajo_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonVerTrabajo);
            this.Controls.Add(this.buttonVerDepts);
            this.Controls.Add(this.buttonVerEmpleados);
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
        private System.Windows.Forms.Button buttonVerEmpleados;
        private System.Windows.Forms.Button buttonVerDepts;
        private System.Windows.Forms.Button buttonVerTrabajo;
    }
}

