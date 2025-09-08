namespace projetoFormsPaisEstadoCidade
{
    partial class frmConsEstados
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
            this.colEstado = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colUF = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colPais = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colCodigoPais = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // ListV
            // 
            this.ListV.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colEstado,
            this.colUF,
            this.colCodigoPais,
            this.colPais});
            // 
            // colEstado
            // 
            this.colEstado.Text = "Estados";
            this.colEstado.Width = 200;
            // 
            // colUF
            // 
            this.colUF.Text = "UF";
            this.colUF.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // colPais
            // 
            this.colPais.DisplayIndex = 3;
            this.colPais.Text = "Pais";
            this.colPais.Width = 200;
            // 
            // colCodigoPais
            // 
            this.colCodigoPais.DisplayIndex = 4;
            this.colCodigoPais.Text = "Codigo Pais";
            // 
            // frmConsEstados
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Name = "frmConsEstados";
            this.Text = "Consulta De Estados";
            this.Load += new System.EventHandler(this.frmConsEstados_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ColumnHeader colEstado;
        private System.Windows.Forms.ColumnHeader colUF;
        private System.Windows.Forms.ColumnHeader colPais;
        private System.Windows.Forms.ColumnHeader colCodigoPais;
    }
}
