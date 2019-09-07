namespace SistemaPoncheOficial.Views.Usuarios
{
    partial class DetalleUsuario
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
            this.btnRegistrarUsuario = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnConfirmarEdit = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnRegistrarUsuario
            // 
            this.btnRegistrarUsuario.Location = new System.Drawing.Point(150, 580);
            this.btnRegistrarUsuario.Name = "btnRegistrarUsuario";
            this.btnRegistrarUsuario.Size = new System.Drawing.Size(143, 52);
            this.btnRegistrarUsuario.TabIndex = 114;
            this.btnRegistrarUsuario.Text = "Editar";
            this.btnRegistrarUsuario.UseVisualStyleBackColor = true;
            this.btnRegistrarUsuario.Click += new System.EventHandler(this.BtnRegistrarUsuario_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(261, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(262, 36);
            this.label1.TabIndex = 115;
            this.label1.Text = "Detalles de Usuario";
            // 
            // btnConfirmarEdit
            // 
            this.btnConfirmarEdit.Location = new System.Drawing.Point(315, 580);
            this.btnConfirmarEdit.Name = "btnConfirmarEdit";
            this.btnConfirmarEdit.Size = new System.Drawing.Size(161, 52);
            this.btnConfirmarEdit.TabIndex = 116;
            this.btnConfirmarEdit.Text = "Confirmar Edición";
            this.btnConfirmarEdit.UseVisualStyleBackColor = true;
            this.btnConfirmarEdit.Click += new System.EventHandler(this.BtnConfirmarEdit_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(504, 580);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(130, 52);
            this.button2.TabIndex = 117;
            this.button2.Text = "Eliminar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.Button2_Click);
            // 
            // DetalleUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(785, 644);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btnConfirmarEdit);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnRegistrarUsuario);
            this.Name = "DetalleUsuario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DetalleUsuario";
            this.Load += new System.EventHandler(this.DetalleUsuario_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnRegistrarUsuario;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnConfirmarEdit;
        private System.Windows.Forms.Button button2;
    }
}