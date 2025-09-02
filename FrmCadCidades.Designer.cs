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
            this.lblCodigoEstado = new System.Windows.Forms.Label();
            this.lblEstado = new System.Windows.Forms.Label();
            this.txtCodigoEstado = new System.Windows.Forms.TextBox();
            this.txtEstado = new System.Windows.Forms.TextBox();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnSalvar
            // 
            this.btnSalvar.TabIndex = 5;
            // 
            // txtcodigo
            // 
            this.txtcodigo.TabIndex = 15;
            // 
            // btnSair
            // 
            this.btnSair.Location = new System.Drawing.Point(713, 386);
            this.btnSair.TabIndex = 6;
            // 
            // lblCidade
            // 
            this.lblCidade.AutoSize = true;
            this.lblCidade.Location = new System.Drawing.Point(118, 6);
            this.lblCidade.Name = "lblCidade";
            this.lblCidade.Size = new System.Drawing.Size(45, 13);
            this.lblCidade.TabIndex = 10;
            this.lblCidade.Text = "Cidades";
            // 
            // lblDdd
            // 
            this.lblDdd.AutoSize = true;
            this.lblDdd.Location = new System.Drawing.Point(318, 6);
            this.lblDdd.Name = "lblDdd";
            this.lblDdd.Size = new System.Drawing.Size(31, 13);
            this.lblDdd.TabIndex = 11;
            this.lblDdd.Text = "DDD";
            // 
            // txtCidade
            // 
            this.txtCidade.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtCidade.Location = new System.Drawing.Point(121, 22);
            this.txtCidade.MaxLength = 55;
            this.txtCidade.Name = "txtCidade";
            this.txtCidade.Size = new System.Drawing.Size(179, 20);
            this.txtCidade.TabIndex = 0;
            // 
            // txtDdd
            // 
            this.txtDdd.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtDdd.Location = new System.Drawing.Point(310, 22);
            this.txtDdd.MaxLength = 4;
            this.txtDdd.Name = "txtDdd";
            this.txtDdd.Size = new System.Drawing.Size(50, 20);
            this.txtDdd.TabIndex = 1;
            this.txtDdd.TextChanged += new System.EventHandler(this.textBox5_TextChanged);
            // 
            // lblCodigoEstado
            // 
            this.lblCodigoEstado.AutoSize = true;
            this.lblCodigoEstado.Location = new System.Drawing.Point(365, 6);
            this.lblCodigoEstado.Name = "lblCodigoEstado";
            this.lblCodigoEstado.Size = new System.Drawing.Size(40, 13);
            this.lblCodigoEstado.TabIndex = 14;
            this.lblCodigoEstado.Text = "Codigo";
            // 
            // lblEstado
            // 
            this.lblEstado.AutoSize = true;
            this.lblEstado.Location = new System.Drawing.Point(411, 7);
            this.lblEstado.Name = "lblEstado";
            this.lblEstado.Size = new System.Drawing.Size(40, 13);
            this.lblEstado.TabIndex = 15;
            this.lblEstado.Text = "Estado";
            // 
            // txtCodigoEstado
            // 
            this.txtCodigoEstado.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtCodigoEstado.Location = new System.Drawing.Point(368, 23);
            this.txtCodigoEstado.MaxLength = 4;
            this.txtCodigoEstado.Name = "txtCodigoEstado";
            this.txtCodigoEstado.Size = new System.Drawing.Size(37, 20);
            this.txtCodigoEstado.TabIndex = 2;
            this.txtCodigoEstado.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtEstado
            // 
            this.txtEstado.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtEstado.Location = new System.Drawing.Point(411, 23);
            this.txtEstado.MaxLength = 55;
            this.txtEstado.Name = "txtEstado";
            this.txtEstado.Size = new System.Drawing.Size(97, 20);
            this.txtEstado.TabIndex = 3;
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(514, 23);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(75, 23);
            this.btnBuscar.TabIndex = 4;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // FrmCadCidades
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.txtEstado);
            this.Controls.Add(this.txtCodigoEstado);
            this.Controls.Add(this.lblEstado);
            this.Controls.Add(this.lblCodigoEstado);
            this.Controls.Add(this.txtDdd);
            this.Controls.Add(this.txtCidade);
            this.Controls.Add(this.lblDdd);
            this.Controls.Add(this.lblCidade);
            this.Name = "FrmCadCidades";
            this.Text = "Cadastro de Cidades";
            this.Controls.SetChildIndex(this.lblCidade, 0);
            this.Controls.SetChildIndex(this.lblDdd, 0);
            this.Controls.SetChildIndex(this.txtCidade, 0);
            this.Controls.SetChildIndex(this.txtDdd, 0);
            this.Controls.SetChildIndex(this.lblCodigoEstado, 0);
            this.Controls.SetChildIndex(this.lblEstado, 0);
            this.Controls.SetChildIndex(this.btnSair, 0);
            this.Controls.SetChildIndex(this.txtcodigo, 0);
            this.Controls.SetChildIndex(this.btnSalvar, 0);
            this.Controls.SetChildIndex(this.txtCodigoEstado, 0);
            this.Controls.SetChildIndex(this.txtEstado, 0);
            this.Controls.SetChildIndex(this.btnBuscar, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCidade;
        private System.Windows.Forms.Label lblDdd;
        private System.Windows.Forms.TextBox txtCidade;
        private System.Windows.Forms.TextBox txtDdd;
        private System.Windows.Forms.Label lblCodigoEstado;
        private System.Windows.Forms.Label lblEstado;
        private System.Windows.Forms.TextBox txtCodigoEstado;
        private System.Windows.Forms.TextBox txtEstado;
        private System.Windows.Forms.Button btnBuscar;
    }
}
