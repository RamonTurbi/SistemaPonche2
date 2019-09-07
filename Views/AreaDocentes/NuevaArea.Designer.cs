namespace SistemaPoncheOficial.Views.AreaDocentes
{
    partial class NuevaArea
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
            this.txtCantidadMaestros = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtCantidadAulas = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txtEncargadoArea = new System.Windows.Forms.TextBox();
            this.txtNombreArea = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnRegistrarArea = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Font = new System.Drawing.Font("Times New Roman", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label22.Location = new System.Drawing.Point(188, 28);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(165, 36);
            this.label22.TabIndex = 158;
            this.label22.Text = "Nueva área ";
            // 
            // txtCantidadMaestros
            // 
            this.txtCantidadMaestros.Location = new System.Drawing.Point(130, 324);
            this.txtCantidadMaestros.Name = "txtCantidadMaestros";
            this.txtCantidadMaestros.Size = new System.Drawing.Size(268, 20);
            this.txtCantidadMaestros.TabIndex = 157;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 14F);
            this.label1.Location = new System.Drawing.Point(172, 300);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(196, 22);
            this.label1.TabIndex = 156;
            this.label1.Text = "Cantidad de maestros";
            // 
            // txtCantidadAulas
            // 
            this.txtCantidadAulas.Location = new System.Drawing.Point(133, 257);
            this.txtCantidadAulas.Name = "txtCantidadAulas";
            this.txtCantidadAulas.Size = new System.Drawing.Size(268, 20);
            this.txtCantidadAulas.TabIndex = 155;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Arial", 14F);
            this.label11.Location = new System.Drawing.Point(186, 233);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(161, 22);
            this.label11.TabIndex = 154;
            this.label11.Text = "Cantidad de aulas";
            // 
            // txtEncargadoArea
            // 
            this.txtEncargadoArea.Location = new System.Drawing.Point(130, 187);
            this.txtEncargadoArea.Name = "txtEncargadoArea";
            this.txtEncargadoArea.Size = new System.Drawing.Size(268, 20);
            this.txtEncargadoArea.TabIndex = 153;
            // 
            // txtNombreArea
            // 
            this.txtNombreArea.Location = new System.Drawing.Point(130, 119);
            this.txtNombreArea.Name = "txtNombreArea";
            this.txtNombreArea.Size = new System.Drawing.Size(268, 20);
            this.txtNombreArea.TabIndex = 152;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 14F);
            this.label2.Location = new System.Drawing.Point(182, 163);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(171, 22);
            this.label2.TabIndex = 159;
            this.label2.Text = "Encargado de área";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 14F);
            this.label3.Location = new System.Drawing.Point(192, 95);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(147, 22);
            this.label3.TabIndex = 160;
            this.label3.Text = "Nombre de área";
            // 
            // btnRegistrarArea
            // 
            this.btnRegistrarArea.Location = new System.Drawing.Point(151, 386);
            this.btnRegistrarArea.Name = "btnRegistrarArea";
            this.btnRegistrarArea.Size = new System.Drawing.Size(239, 52);
            this.btnRegistrarArea.TabIndex = 161;
            this.btnRegistrarArea.Text = "Registrar";
            this.btnRegistrarArea.UseVisualStyleBackColor = true;
            this.btnRegistrarArea.Click += new System.EventHandler(this.BtnRegistrarArea_Click);
            // 
            // NuevaArea
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(541, 487);
            this.Controls.Add(this.btnRegistrarArea);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label22);
            this.Controls.Add(this.txtCantidadMaestros);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtCantidadAulas);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.txtEncargadoArea);
            this.Controls.Add(this.txtNombreArea);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(557, 526);
            this.MinimumSize = new System.Drawing.Size(557, 526);
            this.Name = "NuevaArea";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Nueva área ";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.TextBox txtCantidadMaestros;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtCantidadAulas;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtEncargadoArea;
        private System.Windows.Forms.TextBox txtNombreArea;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnRegistrarArea;
    }
}