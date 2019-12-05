namespace Dinastia_Digital
{
    partial class AdminPrincipal
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
            this.label5 = new System.Windows.Forms.Label();
            this.LblNombres = new System.Windows.Forms.Label();
            this.BtnUsuarios = new System.Windows.Forms.Button();
            this.BtnProductos = new System.Windows.Forms.Button();
            this.BtnAfiliados = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(167, 22);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(105, 24);
            this.label5.TabIndex = 0;
            this.label5.Text = "Bienvenido";
            // 
            // LblNombres
            // 
            this.LblNombres.AutoSize = true;
            this.LblNombres.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblNombres.Location = new System.Drawing.Point(288, 22);
            this.LblNombres.Name = "LblNombres";
            this.LblNombres.Size = new System.Drawing.Size(0, 24);
            this.LblNombres.TabIndex = 1;
            // 
            // BtnUsuarios
            // 
            this.BtnUsuarios.Location = new System.Drawing.Point(70, 91);
            this.BtnUsuarios.Name = "BtnUsuarios";
            this.BtnUsuarios.Size = new System.Drawing.Size(87, 31);
            this.BtnUsuarios.TabIndex = 5;
            this.BtnUsuarios.Text = "Usuario";
            this.BtnUsuarios.UseVisualStyleBackColor = true;
            this.BtnUsuarios.Click += new System.EventHandler(this.BtnUsuarios_Click);
            // 
            // BtnProductos
            // 
            this.BtnProductos.Location = new System.Drawing.Point(292, 90);
            this.BtnProductos.Name = "BtnProductos";
            this.BtnProductos.Size = new System.Drawing.Size(87, 31);
            this.BtnProductos.TabIndex = 6;
            this.BtnProductos.Text = "Productos";
            this.BtnProductos.UseVisualStyleBackColor = true;
            // 
            // BtnAfiliados
            // 
            this.BtnAfiliados.Location = new System.Drawing.Point(511, 90);
            this.BtnAfiliados.Name = "BtnAfiliados";
            this.BtnAfiliados.Size = new System.Drawing.Size(109, 32);
            this.BtnAfiliados.TabIndex = 7;
            this.BtnAfiliados.Text = "Afiliados";
            this.BtnAfiliados.UseVisualStyleBackColor = true;
            // 
            // AdminPrincipal
            // 
            this.ClientSize = new System.Drawing.Size(689, 381);
            this.Controls.Add(this.BtnAfiliados);
            this.Controls.Add(this.BtnProductos);
            this.Controls.Add(this.BtnUsuarios);
            this.Controls.Add(this.LblNombres);
            this.Controls.Add(this.label5);
            this.Name = "AdminPrincipal";
            this.Text = "Administrador Principal";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label LblNombres;
        private System.Windows.Forms.Button BtnUsuarios;
        private System.Windows.Forms.Button BtnProductos;
        private System.Windows.Forms.Button BtnAfiliados;
    }
}