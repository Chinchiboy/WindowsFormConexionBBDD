namespace WindowsFormConexionBBDD
{
    partial class FormAnadirJob
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
            this.textBoxTrabajo = new System.Windows.Forms.TextBox();
            this.buttonAnadirJob = new System.Windows.Forms.Button();
            this.textBoxSalMax = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxSalMin = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 65);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Trabajo";
            // 
            // textBoxTrabajo
            // 
            this.textBoxTrabajo.Location = new System.Drawing.Point(12, 81);
            this.textBoxTrabajo.Name = "textBoxTrabajo";
            this.textBoxTrabajo.Size = new System.Drawing.Size(100, 20);
            this.textBoxTrabajo.TabIndex = 1;
            // 
            // buttonAnadirJob
            // 
            this.buttonAnadirJob.Location = new System.Drawing.Point(73, 184);
            this.buttonAnadirJob.Name = "buttonAnadirJob";
            this.buttonAnadirJob.Size = new System.Drawing.Size(227, 122);
            this.buttonAnadirJob.TabIndex = 2;
            this.buttonAnadirJob.Text = "Añadir trabajo";
            this.buttonAnadirJob.UseVisualStyleBackColor = true;
            this.buttonAnadirJob.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBoxSalMax
            // 
            this.textBoxSalMax.Location = new System.Drawing.Point(265, 81);
            this.textBoxSalMax.Name = "textBoxSalMax";
            this.textBoxSalMax.Size = new System.Drawing.Size(100, 20);
            this.textBoxSalMax.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(265, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Salario máximo";
            // 
            // textBoxSalMin
            // 
            this.textBoxSalMin.Location = new System.Drawing.Point(138, 81);
            this.textBoxSalMin.Name = "textBoxSalMin";
            this.textBoxSalMin.Size = new System.Drawing.Size(100, 20);
            this.textBoxSalMin.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(138, 65);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Salario mínimo";
            // 
            // FormAnadirJob
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.textBoxSalMin);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBoxSalMax);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.buttonAnadirJob);
            this.Controls.Add(this.textBoxTrabajo);
            this.Controls.Add(this.label1);
            this.Name = "FormAnadirJob";
            this.Text = "FormAnadirJob";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxTrabajo;
        private System.Windows.Forms.Button buttonAnadirJob;
        private System.Windows.Forms.TextBox textBoxSalMax;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxSalMin;
        private System.Windows.Forms.Label label3;
    }
}