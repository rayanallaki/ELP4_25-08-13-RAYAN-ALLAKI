namespace projetoFormsPaisEstadoCidade
{
    partial class FrmCadastros
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
            this.btnSalvar = new System.Windows.Forms.Button();
            this.lblCodigo = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.lblCad = new System.Windows.Forms.Label();
            this.lblUltAlt = new System.Windows.Forms.Label();
            this.lblUsuario = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtcodigo
            // 
            this.txtcodigo.Location = new System.Drawing.Point(12, 22);
            // 
            // btnSalvar
            // 
            this.btnSalvar.Location = new System.Drawing.Point(632, 387);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(75, 23);
            this.btnSalvar.TabIndex = 2;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // lblCodigo
            // 
            this.lblCodigo.AutoSize = true;
            this.lblCodigo.Location = new System.Drawing.Point(12, 6);
            this.lblCodigo.Name = "lblCodigo";
            this.lblCodigo.Size = new System.Drawing.Size(40, 13);
            this.lblCodigo.TabIndex = 3;
            this.lblCodigo.Text = "Codigo";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(490, 390);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(68, 20);
            this.textBox1.TabIndex = 4;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(411, 390);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(73, 20);
            this.textBox2.TabIndex = 5;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(331, 389);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(74, 20);
            this.textBox3.TabIndex = 6;
            // 
            // lblCad
            // 
            this.lblCad.AutoSize = true;
            this.lblCad.Location = new System.Drawing.Point(328, 373);
            this.lblCad.Name = "lblCad";
            this.lblCad.Size = new System.Drawing.Size(52, 13);
            this.lblCad.TabIndex = 7;
            this.lblCad.Text = "Data Cad";
            // 
            // lblUltAlt
            // 
            this.lblUltAlt.AutoSize = true;
            this.lblUltAlt.Location = new System.Drawing.Point(408, 374);
            this.lblUltAlt.Name = "lblUltAlt";
            this.lblUltAlt.Size = new System.Drawing.Size(61, 13);
            this.lblUltAlt.TabIndex = 8;
            this.lblUltAlt.Text = "Data Ult Alt";
            // 
            // lblUsuario
            // 
            this.lblUsuario.AutoSize = true;
            this.lblUsuario.Location = new System.Drawing.Point(487, 373);
            this.lblUsuario.Name = "lblUsuario";
            this.lblUsuario.Size = new System.Drawing.Size(43, 13);
            this.lblUsuario.TabIndex = 9;
            this.lblUsuario.Text = "Usuario";
            // 
            // FrmCadastros
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblUsuario);
            this.Controls.Add(this.lblUltAlt);
            this.Controls.Add(this.lblCad);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.lblCodigo);
            this.Controls.Add(this.btnSalvar);
            this.Name = "FrmCadastros";
            this.Text = "Cadastros";
            this.Controls.SetChildIndex(this.btnSair, 0);
            this.Controls.SetChildIndex(this.txtcodigo, 0);
            this.Controls.SetChildIndex(this.btnSalvar, 0);
            this.Controls.SetChildIndex(this.lblCodigo, 0);
            this.Controls.SetChildIndex(this.textBox1, 0);
            this.Controls.SetChildIndex(this.textBox2, 0);
            this.Controls.SetChildIndex(this.textBox3, 0);
            this.Controls.SetChildIndex(this.lblCad, 0);
            this.Controls.SetChildIndex(this.lblUltAlt, 0);
            this.Controls.SetChildIndex(this.lblUsuario, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblCodigo;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label lblCad;
        private System.Windows.Forms.Label lblUltAlt;
        private System.Windows.Forms.Label lblUsuario;
        public System.Windows.Forms.Button btnSalvar;
    }
}
