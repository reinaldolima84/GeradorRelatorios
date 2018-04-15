namespace GeradorRelatorios
{
    partial class frmGeradorRelatorios
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmGeradorRelatorios));
            this.btnSelecionar = new System.Windows.Forms.Button();
            this.txtCaminhoSQL = new System.Windows.Forms.TextBox();
            this.lstConsultaSQL = new System.Windows.Forms.ListBox();
            this.pbProgessao = new System.Windows.Forms.ProgressBar();
            this.dtgDados = new System.Windows.Forms.DataGridView();
            this.lblProgressao = new System.Windows.Forms.Label();
            this.btnExportar = new System.Windows.Forms.Button();
            this.btnExecutarConsulta = new System.Windows.Forms.Button();
            this.ofdCaminhoSQL = new System.Windows.Forms.OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.dtgDados)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSelecionar
            // 
            this.btnSelecionar.Location = new System.Drawing.Point(12, 12);
            this.btnSelecionar.Name = "btnSelecionar";
            this.btnSelecionar.Size = new System.Drawing.Size(75, 23);
            this.btnSelecionar.TabIndex = 0;
            this.btnSelecionar.Text = "Selecionar";
            this.btnSelecionar.UseVisualStyleBackColor = true;
            this.btnSelecionar.Click += new System.EventHandler(this.btnSelecionar_Click);
            // 
            // txtCaminhoSQL
            // 
            this.txtCaminhoSQL.Location = new System.Drawing.Point(93, 14);
            this.txtCaminhoSQL.Name = "txtCaminhoSQL";
            this.txtCaminhoSQL.Size = new System.Drawing.Size(731, 20);
            this.txtCaminhoSQL.TabIndex = 1;
            // 
            // lstConsultaSQL
            // 
            this.lstConsultaSQL.FormattingEnabled = true;
            this.lstConsultaSQL.Location = new System.Drawing.Point(12, 41);
            this.lstConsultaSQL.Name = "lstConsultaSQL";
            this.lstConsultaSQL.Size = new System.Drawing.Size(812, 95);
            this.lstConsultaSQL.TabIndex = 2;
            // 
            // pbProgessao
            // 
            this.pbProgessao.Location = new System.Drawing.Point(12, 142);
            this.pbProgessao.Name = "pbProgessao";
            this.pbProgessao.Size = new System.Drawing.Size(812, 23);
            this.pbProgessao.TabIndex = 3;
            // 
            // dtgDados
            // 
            this.dtgDados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgDados.Location = new System.Drawing.Point(12, 171);
            this.dtgDados.Name = "dtgDados";
            this.dtgDados.Size = new System.Drawing.Size(1057, 437);
            this.dtgDados.TabIndex = 4;
            // 
            // lblProgressao
            // 
            this.lblProgressao.AutoSize = true;
            this.lblProgressao.Location = new System.Drawing.Point(831, 143);
            this.lblProgressao.Name = "lblProgressao";
            this.lblProgressao.Size = new System.Drawing.Size(70, 13);
            this.lblProgressao.TabIndex = 7;
            this.lblProgressao.Text = "lblProgressao";
            // 
            // btnExportar
            // 
            this.btnExportar.Image = global::GeradorRelatorios.Properties.Resources.if_excel_272697;
            this.btnExportar.Location = new System.Drawing.Point(955, 12);
            this.btnExportar.Name = "btnExportar";
            this.btnExportar.Size = new System.Drawing.Size(114, 124);
            this.btnExportar.TabIndex = 6;
            this.btnExportar.Text = "Exportar para Excel";
            this.btnExportar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnExportar.UseVisualStyleBackColor = true;
            this.btnExportar.Click += new System.EventHandler(this.btnExportar_Click);
            // 
            // btnExecutarConsulta
            // 
            this.btnExecutarConsulta.Image = global::GeradorRelatorios.Properties.Resources.if_icon_89_document_file_sql_315887;
            this.btnExecutarConsulta.Location = new System.Drawing.Point(830, 12);
            this.btnExecutarConsulta.Name = "btnExecutarConsulta";
            this.btnExecutarConsulta.Size = new System.Drawing.Size(114, 124);
            this.btnExecutarConsulta.TabIndex = 5;
            this.btnExecutarConsulta.Text = "Executar Consulta";
            this.btnExecutarConsulta.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnExecutarConsulta.UseVisualStyleBackColor = true;
            this.btnExecutarConsulta.Click += new System.EventHandler(this.btnExecutarConsulta_Click);
            // 
            // frmGeradorRelatorios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1081, 620);
            this.Controls.Add(this.lblProgressao);
            this.Controls.Add(this.btnExportar);
            this.Controls.Add(this.btnExecutarConsulta);
            this.Controls.Add(this.dtgDados);
            this.Controls.Add(this.pbProgessao);
            this.Controls.Add(this.lstConsultaSQL);
            this.Controls.Add(this.txtCaminhoSQL);
            this.Controls.Add(this.btnSelecionar);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmGeradorRelatorios";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gerador de Relatórios";
            ((System.ComponentModel.ISupportInitialize)(this.dtgDados)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSelecionar;
        private System.Windows.Forms.TextBox txtCaminhoSQL;
        private System.Windows.Forms.ListBox lstConsultaSQL;
        private System.Windows.Forms.ProgressBar pbProgessao;
        private System.Windows.Forms.DataGridView dtgDados;
        private System.Windows.Forms.Button btnExecutarConsulta;
        private System.Windows.Forms.Button btnExportar;
        private System.Windows.Forms.Label lblProgressao;
        private System.Windows.Forms.OpenFileDialog ofdCaminhoSQL;
    }
}

