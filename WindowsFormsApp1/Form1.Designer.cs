namespace WindowsFormsApp1
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.btncadastrar = new System.Windows.Forms.Button();
            this.btnentrar = new System.Windows.Forms.Button();
            this.mtbcpf = new System.Windows.Forms.MaskedTextBox();
            this.lblcpf = new System.Windows.Forms.Label();
            this.lblnome = new System.Windows.Forms.Label();
            this.txbnome = new System.Windows.Forms.TextBox();
            this.ckbsegurança = new System.Windows.Forms.CheckBox();
            this.rdbinformações = new System.Windows.Forms.RadioButton();
            this.txbsenha = new System.Windows.Forms.TextBox();
            this.lblsenha = new System.Windows.Forms.Label();
            this.lblUsuario = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btncadastrar
            // 
            this.btncadastrar.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.btncadastrar.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btncadastrar.Location = new System.Drawing.Point(403, 145);
            this.btncadastrar.Name = "btncadastrar";
            this.btncadastrar.Size = new System.Drawing.Size(172, 59);
            this.btncadastrar.TabIndex = 1;
            this.btncadastrar.Text = "CADASTRAR";
            this.btncadastrar.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.btncadastrar.UseVisualStyleBackColor = false;
            this.btncadastrar.Click += new System.EventHandler(this.ENTRAR_Click);
            // 
            // btnentrar
            // 
            this.btnentrar.BackColor = System.Drawing.SystemColors.ControlText;
            this.btnentrar.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnentrar.Location = new System.Drawing.Point(403, 243);
            this.btnentrar.Name = "btnentrar";
            this.btnentrar.Size = new System.Drawing.Size(172, 60);
            this.btnentrar.TabIndex = 3;
            this.btnentrar.Text = "ENTRAR";
            this.btnentrar.UseVisualStyleBackColor = false;
            this.btnentrar.Click += new System.EventHandler(this.btnentrar_Click);
            // 
            // mtbcpf
            // 
            this.mtbcpf.Location = new System.Drawing.Point(72, 207);
            this.mtbcpf.Name = "mtbcpf";
            this.mtbcpf.Size = new System.Drawing.Size(175, 20);
            this.mtbcpf.TabIndex = 8;
            this.mtbcpf.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.maskedTextBox1_MaskInputRejected);
            // 
            // lblcpf
            // 
            this.lblcpf.AutoSize = true;
            this.lblcpf.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblcpf.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblcpf.Location = new System.Drawing.Point(69, 191);
            this.lblcpf.Name = "lblcpf";
            this.lblcpf.Size = new System.Drawing.Size(27, 13);
            this.lblcpf.TabIndex = 9;
            this.lblcpf.Text = "CPF";
            // 
            // lblnome
            // 
            this.lblnome.AutoSize = true;
            this.lblnome.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblnome.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblnome.Location = new System.Drawing.Point(69, 248);
            this.lblnome.Name = "lblnome";
            this.lblnome.Size = new System.Drawing.Size(39, 13);
            this.lblnome.TabIndex = 10;
            this.lblnome.Text = "NOME";
            this.lblnome.Click += new System.EventHandler(this.label2_Click_1);
            // 
            // txbnome
            // 
            this.txbnome.Location = new System.Drawing.Point(72, 264);
            this.txbnome.Name = "txbnome";
            this.txbnome.Size = new System.Drawing.Size(175, 20);
            this.txbnome.TabIndex = 11;
            // 
            // ckbsegurança
            // 
            this.ckbsegurança.AutoSize = true;
            this.ckbsegurança.Location = new System.Drawing.Point(72, 353);
            this.ckbsegurança.Name = "ckbsegurança";
            this.ckbsegurança.Size = new System.Drawing.Size(275, 17);
            this.ckbsegurança.TabIndex = 12;
            this.ckbsegurança.Text = "voce leu e aceita todos nossos termos de segurança";
            this.ckbsegurança.UseVisualStyleBackColor = true;
            this.ckbsegurança.CheckedChanged += new System.EventHandler(this.ckbsegurança_CheckedChanged);
            // 
            // rdbinformações
            // 
            this.rdbinformações.AutoSize = true;
            this.rdbinformações.Location = new System.Drawing.Point(72, 376);
            this.rdbinformações.Name = "rdbinformações";
            this.rdbinformações.Size = new System.Drawing.Size(347, 17);
            this.rdbinformações.TabIndex = 13;
            this.rdbinformações.TabStop = true;
            this.rdbinformações.Text = "o R.A.S. (Romeu Area System) não tem acesso as suas informações";
            this.rdbinformações.UseVisualStyleBackColor = true;
            this.rdbinformações.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // txbsenha
            // 
            this.txbsenha.Location = new System.Drawing.Point(72, 133);
            this.txbsenha.Name = "txbsenha";
            this.txbsenha.Size = new System.Drawing.Size(175, 20);
            this.txbsenha.TabIndex = 17;
            this.txbsenha.TextChanged += new System.EventHandler(this.txbsenha_TextChanged);
            // 
            // lblsenha
            // 
            this.lblsenha.AutoSize = true;
            this.lblsenha.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblsenha.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblsenha.Location = new System.Drawing.Point(69, 117);
            this.lblsenha.Name = "lblsenha";
            this.lblsenha.Size = new System.Drawing.Size(44, 13);
            this.lblsenha.TabIndex = 16;
            this.lblsenha.Text = "SENHA";
            // 
            // lblUsuario
            // 
            this.lblUsuario.AutoSize = true;
            this.lblUsuario.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblUsuario.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblUsuario.Location = new System.Drawing.Point(69, 57);
            this.lblUsuario.Name = "lblUsuario";
            this.lblUsuario.Size = new System.Drawing.Size(56, 13);
            this.lblUsuario.TabIndex = 14;
            this.lblUsuario.Text = "USUARIO";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(72, 73);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(175, 20);
            this.textBox1.TabIndex = 15;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(969, 555);
            this.Controls.Add(this.txbsenha);
            this.Controls.Add(this.lblsenha);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.lblUsuario);
            this.Controls.Add(this.rdbinformações);
            this.Controls.Add(this.ckbsegurança);
            this.Controls.Add(this.txbnome);
            this.Controls.Add(this.lblnome);
            this.Controls.Add(this.lblcpf);
            this.Controls.Add(this.mtbcpf);
            this.Controls.Add(this.btnentrar);
            this.Controls.Add(this.btncadastrar);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btncadastrar;
        private System.Windows.Forms.Button btnentrar;
        private System.Windows.Forms.MaskedTextBox mtbcpf;
        private System.Windows.Forms.Label lblcpf;
        private System.Windows.Forms.Label lblnome;
        private System.Windows.Forms.TextBox txbnome;
        private System.Windows.Forms.CheckBox ckbsegurança;
        private System.Windows.Forms.RadioButton rdbinformações;
        private System.Windows.Forms.TextBox txbsenha;
        private System.Windows.Forms.Label lblsenha;
        private System.Windows.Forms.Label lblUsuario;
        private System.Windows.Forms.TextBox textBox1;
    }
}

