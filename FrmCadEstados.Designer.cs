namespace projetoFormsPaisEstadoCidade
{
    partial class FrmCadEstados
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
            this.lblEstados = new System.Windows.Forms.Label();
            this.lblUF = new System.Windows.Forms.Label();
            this.txtEstado = new System.Windows.Forms.TextBox();
            this.txtUf = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lblEstados
            // 
            this.lblEstados.AutoSize = true;
            this.lblEstados.Location = new System.Drawing.Point(142, 9);
            this.lblEstados.Name = "lblEstados";
            this.lblEstados.Size = new System.Drawing.Size(40, 13);
            this.lblEstados.TabIndex = 10;
            this.lblEstados.Text = "Estado";
            this.lblEstados.Click += new System.EventHandler(this.label1_Click);
            // 
            // lblUF
            // 
            this.lblUF.AutoSize = true;
            this.lblUF.Location = new System.Drawing.Point(227, 9);
            this.lblUF.Name = "lblUF";
            this.lblUF.Size = new System.Drawing.Size(21, 13);
            this.lblUF.TabIndex = 11;
            this.lblUF.Text = "UF";
            // 
            // txtEstado
            // 
            this.txtEstado.Location = new System.Drawing.Point(130, 21);
            this.txtEstado.Name = "txtEstado";
            this.txtEstado.Size = new System.Drawing.Size(68, 20);
            this.txtEstado.TabIndex = 12;
            // 
            // txtUf
            // 
            this.txtUf.Location = new System.Drawing.Point(215, 21);
            this.txtUf.Name = "txtUf";
            this.txtUf.Size = new System.Drawing.Size(47, 20);
            this.txtUf.TabIndex = 13;
            // 
            // FrmCadEstados
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtUf);
            this.Controls.Add(this.txtEstado);
            this.Controls.Add(this.lblUF);
            this.Controls.Add(this.lblEstados);
            this.Name = "FrmCadEstados";
            this.Text = "Cadastro de Estados";
            this.Controls.SetChildIndex(this.btnSair, 0);
            this.Controls.SetChildIndex(this.txtcodigo, 0);
            this.Controls.SetChildIndex(this.btnSalvar, 0);
            this.Controls.SetChildIndex(this.lblEstados, 0);
            this.Controls.SetChildIndex(this.lblUF, 0);
            this.Controls.SetChildIndex(this.txtEstado, 0);
            this.Controls.SetChildIndex(this.txtUf, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblEstados;
        private System.Windows.Forms.Label lblUF;
        private System.Windows.Forms.TextBox txtEstado;
        private System.Windows.Forms.TextBox txtUf;
    }
}
