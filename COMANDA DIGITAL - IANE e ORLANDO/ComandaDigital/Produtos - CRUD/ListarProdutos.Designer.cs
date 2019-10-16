namespace ComandaDigital
{
    partial class ListarProdutos
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
            this.components = new System.ComponentModel.Container();
            this.dgDados = new System.Windows.Forms.DataGridView();
            this.produto1DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.valorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.produtoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.btnVoltar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgDados)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.produtoBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dgDados
            // 
            this.dgDados.AllowUserToAddRows = false;
            this.dgDados.AllowUserToDeleteRows = false;
            this.dgDados.AutoGenerateColumns = false;
            this.dgDados.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dgDados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgDados.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.produto1DataGridViewTextBoxColumn,
            this.valorDataGridViewTextBoxColumn});
            this.dgDados.DataSource = this.produtoBindingSource;
            this.dgDados.Location = new System.Drawing.Point(1, 1);
            this.dgDados.Name = "dgDados";
            this.dgDados.ReadOnly = true;
            this.dgDados.Size = new System.Drawing.Size(633, 505);
            this.dgDados.TabIndex = 0;
            // 
            // produto1DataGridViewTextBoxColumn
            // 
            this.produto1DataGridViewTextBoxColumn.DataPropertyName = "produto1";
            this.produto1DataGridViewTextBoxColumn.HeaderText = "Produto";
            this.produto1DataGridViewTextBoxColumn.Name = "produto1DataGridViewTextBoxColumn";
            this.produto1DataGridViewTextBoxColumn.ReadOnly = true;
            this.produto1DataGridViewTextBoxColumn.Width = 300;
            // 
            // valorDataGridViewTextBoxColumn
            // 
            this.valorDataGridViewTextBoxColumn.DataPropertyName = "valor";
            this.valorDataGridViewTextBoxColumn.HeaderText = "Preço";
            this.valorDataGridViewTextBoxColumn.Name = "valorDataGridViewTextBoxColumn";
            this.valorDataGridViewTextBoxColumn.ReadOnly = true;
            this.valorDataGridViewTextBoxColumn.Width = 290;
            // 
            // produtoBindingSource
            // 
            this.produtoBindingSource.DataSource = typeof(ComandaDigital.Produto);
            // 
            // btnVoltar
            // 
            this.btnVoltar.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnVoltar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.btnVoltar.Location = new System.Drawing.Point(527, 512);
            this.btnVoltar.Name = "btnVoltar";
            this.btnVoltar.Size = new System.Drawing.Size(95, 37);
            this.btnVoltar.TabIndex = 13;
            this.btnVoltar.Text = "Voltar";
            this.btnVoltar.UseVisualStyleBackColor = false;
            this.btnVoltar.Click += new System.EventHandler(this.btnVoltar_Click);
            // 
            // ListarProdutos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(634, 561);
            this.Controls.Add(this.btnVoltar);
            this.Controls.Add(this.dgDados);
            this.Name = "ListarProdutos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ListarProdutos";
            ((System.ComponentModel.ISupportInitialize)(this.dgDados)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.produtoBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgDados;
        private System.Windows.Forms.BindingSource produtoBindingSource;
        private System.Windows.Forms.Button btnVoltar;
        private System.Windows.Forms.DataGridViewTextBoxColumn produto1DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn valorDataGridViewTextBoxColumn;
    }
}