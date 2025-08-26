namespace WindowsFormsApp1
{
    partial class Login
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
            this.txbsenha = new System.Windows.Forms.TextBox();
            this.txtsenha = new System.Windows.Forms.Label();
            this.txtcaixa1 = new System.Windows.Forms.TextBox();
            this.txtUsuario = new System.Windows.Forms.Label();
            this.btnentrar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txbsenha
            // 
            this.txbsenha.Location = new System.Drawing.Point(314, 254);
            this.txbsenha.Name = "txbsenha";
            this.txbsenha.Size = new System.Drawing.Size(175, 20);
            this.txbsenha.TabIndex = 11;
            // 
            // txtsenha
            // 
            this.txtsenha.AutoSize = true;
            this.txtsenha.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txtsenha.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.txtsenha.Location = new System.Drawing.Point(311, 237);
            this.txtsenha.Name = "txtsenha";
            this.txtsenha.Size = new System.Drawing.Size(44, 13);
            this.txtsenha.TabIndex = 10;
            this.txtsenha.Text = "SENHA";
            // 
            // txtcaixa1
            // 
            this.txtcaixa1.Location = new System.Drawing.Point(314, 192);
            this.txtcaixa1.Name = "txtcaixa1";
            this.txtcaixa1.Size = new System.Drawing.Size(175, 20);
            this.txtcaixa1.TabIndex = 9;
            // 
            // txtUsuario
            // 
            this.txtUsuario.AutoSize = true;
            this.txtUsuario.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txtUsuario.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.txtUsuario.Location = new System.Drawing.Point(311, 176);
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.Size = new System.Drawing.Size(56, 13);
            this.txtUsuario.TabIndex = 8;
            this.txtUsuario.Text = "USUARIO";
            // 
            // btnentrar
            // 
            this.btnentrar.BackColor = System.Drawing.SystemColors.ControlText;
            this.btnentrar.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnentrar.Location = new System.Drawing.Point(317, 301);
            this.btnentrar.Name = "btnentrar";
            this.btnentrar.Size = new System.Drawing.Size(172, 60);
            this.btnentrar.TabIndex = 12;
            this.btnentrar.Text = "ENTRAR";
            this.btnentrar.UseVisualStyleBackColor = false;
            this.btnentrar.Click += new System.EventHandler(this.btnentrar_Click);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnentrar);
            this.Controls.Add(this.txbsenha);
            this.Controls.Add(this.txtsenha);
            this.Controls.Add(this.txtcaixa1);
            this.Controls.Add(this.txtUsuario);
            this.Name = "Login";
            this.Text = "Login";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txbsenha;
        private System.Windows.Forms.Label txtsenha;
        private System.Windows.Forms.TextBox txtcaixa1;
        private System.Windows.Forms.Label txtUsuario;
        private System.Windows.Forms.Button btnentrar;
    }
}