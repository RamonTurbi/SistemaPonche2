namespace SistemaPoncheOficial.Views.ModalidadesContratos
{
    partial class NuevaModalidad
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
            this.label22 = new System.Windows.Forms.Label();
            this.txtNombreModalidad = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.btnRegistrar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Font = new System.Drawing.Font("Times New Roman", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label22.Location = new System.Drawing.Point(104, 20);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(237, 36);
            this.label22.TabIndex = 154;
            this.label22.Text = "Nueva modalidad";
            // 
            // txtNombreModalidad
            // 
            this.txtNombreModalidad.Location = new System.Drawing.Point(70, 105);
            this.txtNombreModalidad.Name = "txtNombreModalidad";
            this.txtNombreModalidad.Size = new System.Drawing.Size(268, 20);
            this.txtNombreModalidad.TabIndex = 153;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(100, 84);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(209, 18);
            this.label11.TabIndex = 152;
            this.label11.Text = "Nombre de nueva modalidad";
            // 
            // btnRegistrar
            // 
            this.btnRegistrar.Location = new System.Drawing.Point(83, 158);
            this.btnRegistrar.Name = "btnRegistrar";
            this.btnRegistrar.Size = new System.Drawing.Size(239, 52);
            this.btnRegistrar.TabIndex = 155;
            this.btnRegistrar.Text = "Registrar";
            this.btnRegistrar.UseVisualStyleBackColor = true;
            this.btnRegistrar.Click += new System.EventHandler(this.BtnRegistrar_Click);
            // 
            // NuevaModalidad
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(408, 255);
            this.Controls.Add(this.btnRegistrar);
            this.Controls.Add(this.label22);
            this.Controls.Add(this.txtNombreModalidad);
            this.Controls.Add(this.label11);
            this.Name = "NuevaModalidad";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Nueva Modalidad";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.TextBox txtNombreModalidad;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button btnRegistrar;
    }
}