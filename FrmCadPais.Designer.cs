namespace projetoFormsPaisEstadoCidade
{
    partial class FrmCadPais
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
            this.lblPais = new System.Windows.Forms.Label();
            this.lblSigla = new System.Windows.Forms.Label();
            this.lblDdi = new System.Windows.Forms.Label();
            this.lblMoeda = new System.Windows.Forms.Label();
            this.txtPais = new System.Windows.Forms.TextBox();
            this.txtSigla = new System.Windows.Forms.TextBox();
            this.txtDdi = new System.Windows.Forms.TextBox();
            this.txtMoeda = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lblPais
            // 
            this.lblPais.AutoSize = true;
            this.lblPais.Location = new System.Drawing.Point(132, 6);
            this.lblPais.Name = "lblPais";
            this.lblPais.Size = new System.Drawing.Size(27, 13);
            this.lblPais.TabIndex = 10;
            this.lblPais.Text = "Pais";
            // 
            // lblSigla
            // 
            this.lblSigla.AutoSize = true;
            this.lblSigla.Location = new System.Drawing.Point(199, 4);
            this.lblSigla.Name = "lblSigla";
            this.lblSigla.Size = new System.Drawing.Size(30, 13);
            this.lblSigla.TabIndex = 11;
            this.lblSigla.Text = "Sigla";
            // 
            // lblDdi
            // 
            this.lblDdi.AutoSize = true;
            this.lblDdi.Location = new System.Drawing.Point(256, 4);
            this.lblDdi.Name = "lblDdi";
            this.lblDdi.Size = new System.Drawing.Size(26, 13);
            this.lblDdi.TabIndex = 12;
            this.lblDdi.Text = "DDI";
            // 
            // lblMoeda
            // 
            this.lblMoeda.AutoSize = true;
            this.lblMoeda.Location = new System.Drawing.Point(303, 4);
            this.lblMoeda.Name = "lblMoeda";
            this.lblMoeda.Size = new System.Drawing.Size(40, 13);
            this.lblMoeda.TabIndex = 13;
            this.lblMoeda.Text = "Moeda";
            // 
            // txtPais
            // 
            this.txtPais.Location = new System.Drawing.Point(113, 20);
            this.txtPais.Name = "txtPais";
            this.txtPais.Size = new System.Drawing.Size(71, 20);
            this.txtPais.TabIndex = 14;
            // 
            // txtSigla
            // 
            this.txtSigla.Location = new System.Drawing.Point(190, 20);
            this.txtSigla.Name = "txtSigla";
            this.txtSigla.Size = new System.Drawing.Size(48, 20);
            this.txtSigla.TabIndex = 15;
            // 
            // txtDdi
            // 
            this.txtDdi.Location = new System.Drawing.Point(244, 20);
            this.txtDdi.Name = "txtDdi";
            this.txtDdi.Size = new System.Drawing.Size(47, 20);
            this.txtDdi.TabIndex = 16;
            // 
            // txtMoeda
            // 
            this.txtMoeda.Location = new System.Drawing.Point(297, 21);
            this.txtMoeda.Name = "txtMoeda";
            this.txtMoeda.Size = new System.Drawing.Size(55, 20);
            this.txtMoeda.TabIndex = 17;
            // 
            // FrmCadPais
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtMoeda);
            this.Controls.Add(this.txtDdi);
            this.Controls.Add(this.txtSigla);
            this.Controls.Add(this.txtPais);
            this.Controls.Add(this.lblMoeda);
            this.Controls.Add(this.lblDdi);
            this.Controls.Add(this.lblSigla);
            this.Controls.Add(this.lblPais);
            this.Name = "FrmCadPais";
            this.Text = "Cadastro de Paises";
            this.Controls.SetChildIndex(this.btnSair, 0);
            this.Controls.SetChildIndex(this.txtcodigo, 0);
            this.Controls.SetChildIndex(this.btnSalvar, 0);
            this.Controls.SetChildIndex(this.lblPais, 0);
            this.Controls.SetChildIndex(this.lblSigla, 0);
            this.Controls.SetChildIndex(this.lblDdi, 0);
            this.Controls.SetChildIndex(this.lblMoeda, 0);
            this.Controls.SetChildIndex(this.txtPais, 0);
            this.Controls.SetChildIndex(this.txtSigla, 0);
            this.Controls.SetChildIndex(this.txtDdi, 0);
            this.Controls.SetChildIndex(this.txtMoeda, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblPais;
        private System.Windows.Forms.Label lblSigla;
        private System.Windows.Forms.Label lblDdi;
        private System.Windows.Forms.Label lblMoeda;
        private System.Windows.Forms.TextBox txtPais;
        private System.Windows.Forms.TextBox txtSigla;
        private System.Windows.Forms.TextBox txtDdi;
        private System.Windows.Forms.TextBox txtMoeda;
    }
}
