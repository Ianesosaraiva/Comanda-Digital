namespace ComandaDigital
{
    partial class Cupom
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
            this.label1 = new System.Windows.Forms.Label();
            this.labelComanda = new System.Windows.Forms.Label();
            this.labelData = new System.Windows.Forms.Label();
            this.label = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.laTotal = new System.Windows.Forms.Label();
            this.laPago = new System.Windows.Forms.Label();
            this.laTroco = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.laComandaN = new System.Windows.Forms.Label();
            this.laData = new System.Windows.Forms.Label();
            this.dgDados = new System.Windows.Forms.DataGridView();
            this.labelFuncionario = new System.Windows.Forms.Label();
            this.laFuncionario = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.laTotalItens = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.labelEspaco = new System.Windows.Forms.Label();
            this.produtoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dgDados)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.produtoBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(206, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(236, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "CUPOM NÃO FISCAL";
            // 
            // labelComanda
            // 
            this.labelComanda.AutoSize = true;
            this.labelComanda.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelComanda.Location = new System.Drawing.Point(35, 88);
            this.labelComanda.Name = "labelComanda";
            this.labelComanda.Size = new System.Drawing.Size(90, 20);
            this.labelComanda.TabIndex = 1;
            this.labelComanda.Text = "Comanda:";
            // 
            // labelData
            // 
            this.labelData.AutoSize = true;
            this.labelData.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelData.Location = new System.Drawing.Point(428, 89);
            this.labelData.Name = "labelData";
            this.labelData.Size = new System.Drawing.Size(53, 20);
            this.labelData.TabIndex = 2;
            this.labelData.Text = "Data:";
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label.Location = new System.Drawing.Point(33, 437);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(118, 18);
            this.label.TabIndex = 6;
            this.label.Text = "TOTAL ITENS:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(35, 463);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(60, 18);
            this.label8.TabIndex = 8;
            this.label8.Text = "PAGO:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(33, 489);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(73, 18);
            this.label9.TabIndex = 9;
            this.label9.Text = "TROCO:";
            // 
            // laTotal
            // 
            this.laTotal.AutoSize = true;
            this.laTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.laTotal.Location = new System.Drawing.Point(515, 436);
            this.laTotal.Name = "laTotal";
            this.laTotal.Size = new System.Drawing.Size(38, 20);
            this.laTotal.TabIndex = 10;
            this.laTotal.Text = "R$: ";
            // 
            // laPago
            // 
            this.laPago.AutoSize = true;
            this.laPago.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.laPago.Location = new System.Drawing.Point(515, 462);
            this.laPago.Name = "laPago";
            this.laPago.Size = new System.Drawing.Size(38, 20);
            this.laPago.TabIndex = 11;
            this.laPago.Text = "R$: ";
            // 
            // laTroco
            // 
            this.laTroco.AutoSize = true;
            this.laTroco.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.laTroco.Location = new System.Drawing.Point(515, 488);
            this.laTroco.Name = "laTroco";
            this.laTroco.Size = new System.Drawing.Size(38, 20);
            this.laTroco.TabIndex = 12;
            this.laTroco.Text = "R$: ";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(224, 538);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(201, 18);
            this.label13.TabIndex = 13;
            this.label13.Text = "Obrigado e Volte Sempre!";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(33, 410);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(581, 13);
            this.label19.TabIndex = 16;
            this.label19.Text = "_________________________________________________________________________________" +
    "_";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(33, 509);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(581, 13);
            this.label2.TabIndex = 23;
            this.label2.Text = "_________________________________________________________________________________" +
    "_";
            // 
            // laComandaN
            // 
            this.laComandaN.AutoSize = true;
            this.laComandaN.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.laComandaN.Location = new System.Drawing.Point(147, 89);
            this.laComandaN.Name = "laComandaN";
            this.laComandaN.Size = new System.Drawing.Size(148, 18);
            this.laComandaN.TabIndex = 26;
            this.laComandaN.Text = "Número da comanda";
            // 
            // laData
            // 
            this.laData.AutoSize = true;
            this.laData.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.laData.Location = new System.Drawing.Point(487, 90);
            this.laData.Name = "laData";
            this.laData.Size = new System.Drawing.Size(88, 18);
            this.laData.TabIndex = 27;
            this.laData.Text = "Data e Hora";
            // 
            // dgDados
            // 
            this.dgDados.AllowUserToAddRows = false;
            this.dgDados.AllowUserToDeleteRows = false;
            this.dgDados.AllowUserToOrderColumns = true;
            this.dgDados.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dgDados.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgDados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgDados.Location = new System.Drawing.Point(37, 173);
            this.dgDados.Name = "dgDados";
            this.dgDados.ReadOnly = true;
            this.dgDados.Size = new System.Drawing.Size(577, 234);
            this.dgDados.TabIndex = 29;
            // 
            // labelFuncionario
            // 
            this.labelFuncionario.AutoSize = true;
            this.labelFuncionario.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.labelFuncionario.Location = new System.Drawing.Point(35, 127);
            this.labelFuncionario.Name = "labelFuncionario";
            this.labelFuncionario.Size = new System.Drawing.Size(108, 20);
            this.labelFuncionario.TabIndex = 3;
            this.labelFuncionario.Text = "Funcionário:";
            // 
            // laFuncionario
            // 
            this.laFuncionario.AutoSize = true;
            this.laFuncionario.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.laFuncionario.Location = new System.Drawing.Point(147, 127);
            this.laFuncionario.Name = "laFuncionario";
            this.laFuncionario.Size = new System.Drawing.Size(165, 18);
            this.laFuncionario.TabIndex = 28;
            this.laFuncionario.Text = "Número do Funcionário";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(34, 147);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(581, 13);
            this.label3.TabIndex = 30;
            this.label3.Text = "_________________________________________________________________________________" +
    "_";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(34, 561);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(581, 13);
            this.label4.TabIndex = 31;
            this.label4.Text = "_________________________________________________________________________________" +
    "_";
            // 
            // button1
            // 
            this.button1.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(236, 590);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(174, 44);
            this.button1.TabIndex = 32;
            this.button1.Text = "IMPRIMIR";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(323, 437);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 18);
            this.label5.TabIndex = 33;
            this.label5.Text = "TOTAL:";
            // 
            // laTotalItens
            // 
            this.laTotalItens.AutoSize = true;
            this.laTotalItens.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.laTotalItens.Location = new System.Drawing.Point(219, 437);
            this.laTotalItens.Name = "laTotalItens";
            this.laTotalItens.Size = new System.Drawing.Size(96, 18);
            this.laTotalItens.TabIndex = 34;
            this.laTotalItens.Text = "Total de Itens";
            this.laTotalItens.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(33, 62);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(581, 13);
            this.label6.TabIndex = 35;
            this.label6.Text = "_________________________________________________________________________________" +
    "_";
            // 
            // labelEspaco
            // 
            this.labelEspaco.AutoSize = true;
            this.labelEspaco.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelEspaco.Location = new System.Drawing.Point(314, 430);
            this.labelEspaco.Name = "labelEspaco";
            this.labelEspaco.Size = new System.Drawing.Size(14, 24);
            this.labelEspaco.TabIndex = 36;
            this.labelEspaco.Text = "|";
            // 
            // produtoBindingSource
            // 
            this.produtoBindingSource.DataSource = typeof(ComandaDigital.Produto);
            // 
            // Cupom
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(647, 646);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.laTotalItens);
            this.Controls.Add(this.labelEspaco);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dgDados);
            this.Controls.Add(this.laFuncionario);
            this.Controls.Add(this.laData);
            this.Controls.Add(this.laComandaN);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label19);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.laTroco);
            this.Controls.Add(this.laPago);
            this.Controls.Add(this.laTotal);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label);
            this.Controls.Add(this.labelFuncionario);
            this.Controls.Add(this.labelData);
            this.Controls.Add(this.labelComanda);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "Cupom";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            ((System.ComponentModel.ISupportInitialize)(this.dgDados)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.produtoBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelComanda;
        private System.Windows.Forms.Label labelData;
        private System.Windows.Forms.Label label;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label laTotal;
        private System.Windows.Forms.Label laPago;
        private System.Windows.Forms.Label laTroco;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label laComandaN;
        private System.Windows.Forms.Label laData;
        private System.Windows.Forms.BindingSource produtoBindingSource;
        private System.Windows.Forms.DataGridView dgDados;
        private System.Windows.Forms.Label labelFuncionario;
        private System.Windows.Forms.Label laFuncionario;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label laTotalItens;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label labelEspaco;
    }
}