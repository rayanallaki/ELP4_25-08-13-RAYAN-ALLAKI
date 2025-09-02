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
            this.lblCodigoPais = new System.Windows.Forms.Label();
            this.lblPais = new System.Windows.Forms.Label();
            this.txtCodigoPais = new System.Windows.Forms.TextBox();
            this.txtPais = new System.Windows.Forms.TextBox();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnSalvar
            // 
            this.btnSalvar.TabIndex = 4;
            // 
            // txtcodigo
            // 
            this.txtcodigo.TabIndex = 15;
            // 
            // btnSair
            // 
            this.btnSair.TabIndex = 5;
            // 
            // lblEstados
            // 
            this.lblEstados.AutoSize = true;
            this.lblEstados.Location = new System.Drawing.Point(111, 7);
            this.lblEstados.Name = "lblEstados";
            this.lblEstados.Size = new System.Drawing.Size(40, 13);
            this.lblEstados.TabIndex = 10;
            this.lblEstados.Text = "Estado";
            this.lblEstados.Click += new System.EventHandler(this.label1_Click);
            // 
            // lblUF
            // 
            this.lblUF.AutoSize = true;
            this.lblUF.Location = new System.Drawing.Point(278, 6);
            this.lblUF.Name = "lblUF";
            this.lblUF.Size = new System.Drawing.Size(21, 13);
            this.lblUF.TabIndex = 11;
            this.lblUF.Text = "UF";
            // 
            // txtEstado
            // 
            this.txtEstado.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtEstado.Location = new System.Drawing.Point(114, 23);
            this.txtEstado.MaxLength = 55;
            this.txtEstado.Name = "txtEstado";
            this.txtEstado.Size = new System.Drawing.Size(154, 20);
            this.txtEstado.TabIndex = 0;
            //this.txtEstado.TextChanged += new System.EventHandler(this.txtEstado_TextChanged);
            // 
            // txtUf
            // 
            this.txtUf.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtUf.Location = new System.Drawing.Point(274, 22);
            this.txtUf.MaxLength = 4;
            this.txtUf.Name = "txtUf";
            this.txtUf.Size = new System.Drawing.Size(47, 20);
            this.txtUf.TabIndex = 1;
            // 
            // lblCodigoPais
            // 
            this.lblCodigoPais.AutoSize = true;
            this.lblCodigoPais.Location = new System.Drawing.Point(324, 6);
            this.lblCodigoPais.Name = "lblCodigoPais";
            this.lblCodigoPais.Size = new System.Drawing.Size(40, 13);
            this.lblCodigoPais.TabIndex = 14;
            this.lblCodigoPais.Text = "Codigo";
            // 
            // lblPais
            // 
            this.lblPais.AutoSize = true;
            this.lblPais.Location = new System.Drawing.Point(382, 6);
            this.lblPais.Name = "lblPais";
            this.lblPais.Size = new System.Drawing.Size(27, 13);
            this.lblPais.TabIndex = 15;
            this.lblPais.Text = "Pais";
            // 
            // txtCodigoPais
            // 
            this.txtCodigoPais.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtCodigoPais.Location = new System.Drawing.Point(327, 22);
            this.txtCodigoPais.MaxLength = 4;
            this.txtCodigoPais.Name = "txtCodigoPais";
            this.txtCodigoPais.Size = new System.Drawing.Size(49, 20);
            this.txtCodigoPais.TabIndex = 2;
            this.txtCodigoPais.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtPais
            // 
            this.txtPais.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtPais.Location = new System.Drawing.Point(382, 22);
            this.txtPais.MaxLength = 55;
            this.txtPais.Name = "txtPais";
            this.txtPais.Size = new System.Drawing.Size(75, 20);
            this.txtPais.TabIndex = 3;
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(463, 22);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(56, 23);
            this.btnBuscar.TabIndex = 18;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // FrmCadEstados
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.txtPais);
            this.Controls.Add(this.txtCodigoPais);
            this.Controls.Add(this.lblPais);
            this.Controls.Add(this.lblCodigoPais);
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
            this.Controls.SetChildIndex(this.lblCodigoPais, 0);
            this.Controls.SetChildIndex(this.lblPais, 0);
            this.Controls.SetChildIndex(this.txtCodigoPais, 0);
            this.Controls.SetChildIndex(this.txtPais, 0);
            this.Controls.SetChildIndex(this.btnBuscar, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblEstados;
        private System.Windows.Forms.Label lblUF;
        private System.Windows.Forms.TextBox txtEstado;
        private System.Windows.Forms.TextBox txtUf;
        private System.Windows.Forms.Label lblCodigoPais;
        private System.Windows.Forms.Label lblPais;
        private System.Windows.Forms.TextBox txtCodigoPais;
        private System.Windows.Forms.TextBox txtPais;
        protected System.Windows.Forms.Button btnBuscar;
    }
}
