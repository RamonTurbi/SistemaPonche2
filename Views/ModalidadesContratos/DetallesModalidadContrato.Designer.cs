namespace SistemaPoncheOficial.Views.ModalidadesContratos
{
    partial class DetallesModalidadContrato
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
            this.btnConfirmEdit = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.txtIdModalidad = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnEditar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Font = new System.Drawing.Font("Times New Roman", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label22.Location = new System.Drawing.Point(108, 9);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(237, 36);
            this.label22.TabIndex = 158;
            this.label22.Text = "Nueva modalidad";
            // 
            // txtNombreModalidad
            // 
            this.txtNombreModalidad.Location = new System.Drawing.Point(92, 88);
            this.txtNombreModalidad.Name = "txtNombreModalidad";
            this.txtNombreModalidad.Size = new System.Drawing.Size(268, 20);
            this.txtNombreModalidad.TabIndex = 157;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(144, 67);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(164, 18);
            this.label11.TabIndex = 156;
            this.label11.Text = "Nombre de modalidad";
            // 
            // btnConfirmEdit
            // 
            this.btnConfirmEdit.Location = new System.Drawing.Point(144, 234);
            this.btnConfirmEdit.Name = "btnConfirmEdit";
            this.btnConfirmEdit.Size = new System.Drawing.Size(150, 52);
            this.btnConfirmEdit.TabIndex = 160;
            this.btnConfirmEdit.Text = "Confirmar Edicion";
            this.btnConfirmEdit.UseVisualStyleBackColor = true;
            this.btnConfirmEdit.Click += new System.EventHandler(this.BtnConfirmEdit_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(300, 234);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(137, 52);
            this.btnEliminar.TabIndex = 161;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.BtnEliminar_Click);
            // 
            // txtIdModalidad
            // 
            this.txtIdModalidad.Location = new System.Drawing.Point(92, 154);
            this.txtIdModalidad.Name = "txtIdModalidad";
            this.txtIdModalidad.ReadOnly = true;
            this.txtIdModalidad.Size = new System.Drawing.Size(268, 20);
            this.txtIdModalidad.TabIndex = 163;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(177, 133);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 18);
            this.label1.TabIndex = 162;
            this.label1.Text = "Id modalidad";
            // 
            // btnEditar
            // 
            this.btnEditar.Location = new System.Drawing.Point(12, 234);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(126, 52);
            this.btnEditar.TabIndex = 159;
            this.btnEditar.Text = "Editar";
            this.btnEditar.UseVisualStyleBackColor = true;
            this.btnEditar.Click += new System.EventHandler(this.BtnEditar_Click);
            // 
            // DetallesModalidadContrato
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(452, 307);
            this.Controls.Add(this.txtIdModalidad);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnConfirmEdit);
            this.Controls.Add(this.btnEditar);
            this.Controls.Add(this.label22);
            this.Controls.Add(this.txtNombreModalidad);
            this.Controls.Add(this.label11);
            this.Name = "DetallesModalidadContrato";
            this.Text = "Detalles de modalidad contrato";
            this.Load += new System.EventHandler(this.DetallesModalidadContrato_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.TextBox txtNombreModalidad;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button btnConfirmEdit;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.TextBox txtIdModalidad;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnEditar;
    }
}