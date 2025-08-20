namespace projetoFormsPaisEstadoCidade
{
    partial class FrmCadCidades
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
            this.lblCidade = new System.Windows.Forms.Label();
            this.lblDdd = new System.Windows.Forms.Label();
            this.txtCidade = new System.Windows.Forms.TextBox();
            this.txtDdd = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lblCidade
            // 
            this.lblCidade.AutoSize = true;
            this.lblCidade.Location = new System.Drawing.Point(140, 6);
            this.lblCidade.Name = "lblCidade";
            this.lblCidade.Size = new System.Drawing.Size(45, 13);
            this.lblCidade.TabIndex = 10;
            this.lblCidade.Text = "Cidades";
            // 
            // lblDdd
            // 
            this.lblDdd.AutoSize = true;
            this.lblDdd.Location = new System.Drawing.Point(240, 6);
            this.lblDdd.Name = "lblDdd";
            this.lblDdd.Size = new System.Drawing.Size(31, 13);
            this.lblDdd.TabIndex = 11;
            this.lblDdd.Text = "DDD";
            // 
            // txtCidade
            // 
            this.txtCidade.Location = new System.Drawing.Point(121, 22);
            this.txtCidade.Name = "txtCidade";
            this.txtCidade.Size = new System.Drawing.Size(85, 20);
            this.txtCidade.TabIndex = 12;
            // 
            // txtDdd
            // 
            this.txtDdd.Location = new System.Drawing.Point(232, 22);
            this.txtDdd.Name = "txtDdd";
            this.txtDdd.Size = new System.Drawing.Size(50, 20);
            this.txtDdd.TabIndex = 13;
            this.txtDdd.TextChanged += new System.EventHandler(this.textBox5_TextChanged);
            // 
            // FrmCadCidades
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtDdd);
            this.Controls.Add(this.txtCidade);
            this.Controls.Add(this.lblDdd);
            this.Controls.Add(this.lblCidade);
            this.Name = "FrmCadCidades";
            this.Text = "Cadastro de Cidades";
            this.Controls.SetChildIndex(this.btnSair, 0);
            this.Controls.SetChildIndex(this.txtcodigo, 0);
            this.Controls.SetChildIndex(this.btnSalvar, 0);
            this.Controls.SetChildIndex(this.lblCidade, 0);
            this.Controls.SetChildIndex(this.lblDdd, 0);
            this.Controls.SetChildIndex(this.txtCidade, 0);
            this.Controls.SetChildIndex(this.txtDdd, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCidade;
        private System.Windows.Forms.Label lblDdd;
        private System.Windows.Forms.TextBox txtCidade;
        private System.Windows.Forms.TextBox txtDdd;
    }
}
