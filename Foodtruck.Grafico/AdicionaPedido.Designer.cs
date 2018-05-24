namespace Foodtruck.Grafico
{
    partial class AdicionaPedido
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cbClientes = new System.Windows.Forms.ComboBox();
            this.cbBebidas = new System.Windows.Forms.ComboBox();
            this.cbLanches = new System.Windows.Forms.ComboBox();
            this.btAdicionaBebida = new System.Windows.Forms.Button();
            this.btAdicionaLanche = new System.Windows.Forms.Button();
            this.dgBebidas = new System.Windows.Forms.DataGridView();
            this.dgLanches = new System.Windows.Forms.DataGridView();
            this.button3 = new System.Windows.Forms.Button();
            this.Nome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tamanho = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Valor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NomeLanche = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ValorLanche = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label4 = new System.Windows.Forms.Label();
            this.lbTotal = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgBebidas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgLanches)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(41, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Cliente:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(30, 97);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Bebidas:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(599, 98);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 25);
            this.label3.TabIndex = 2;
            this.label3.Text = "Lanches:";
            // 
            // cbClientes
            // 
            this.cbClientes.FormattingEnabled = true;
            this.cbClientes.Location = new System.Drawing.Point(132, 31);
            this.cbClientes.Name = "cbClientes";
            this.cbClientes.Size = new System.Drawing.Size(369, 33);
            this.cbClientes.TabIndex = 4;
            // 
            // cbBebidas
            // 
            this.cbBebidas.FormattingEnabled = true;
            this.cbBebidas.Location = new System.Drawing.Point(132, 89);
            this.cbBebidas.Name = "cbBebidas";
            this.cbBebidas.Size = new System.Drawing.Size(369, 33);
            this.cbBebidas.TabIndex = 5;
            // 
            // cbLanches
            // 
            this.cbLanches.FormattingEnabled = true;
            this.cbLanches.Location = new System.Drawing.Point(705, 95);
            this.cbLanches.Name = "cbLanches";
            this.cbLanches.Size = new System.Drawing.Size(282, 33);
            this.cbLanches.TabIndex = 6;
            // 
            // btAdicionaBebida
            // 
            this.btAdicionaBebida.Location = new System.Drawing.Point(507, 89);
            this.btAdicionaBebida.Name = "btAdicionaBebida";
            this.btAdicionaBebida.Size = new System.Drawing.Size(75, 34);
            this.btAdicionaBebida.TabIndex = 7;
            this.btAdicionaBebida.Text = "+";
            this.btAdicionaBebida.UseVisualStyleBackColor = true;
            this.btAdicionaBebida.Click += new System.EventHandler(this.btAdicionaBebida_Click);
            // 
            // btAdicionaLanche
            // 
            this.btAdicionaLanche.Location = new System.Drawing.Point(1002, 94);
            this.btAdicionaLanche.Name = "btAdicionaLanche";
            this.btAdicionaLanche.Size = new System.Drawing.Size(75, 34);
            this.btAdicionaLanche.TabIndex = 8;
            this.btAdicionaLanche.Text = "+";
            this.btAdicionaLanche.UseVisualStyleBackColor = true;
            this.btAdicionaLanche.Click += new System.EventHandler(this.btAdicionaLanche_Click);
            // 
            // dgBebidas
            // 
            this.dgBebidas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgBebidas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Nome,
            this.Tamanho,
            this.Valor});
            this.dgBebidas.Location = new System.Drawing.Point(35, 150);
            this.dgBebidas.Name = "dgBebidas";
            this.dgBebidas.RowTemplate.Height = 33;
            this.dgBebidas.Size = new System.Drawing.Size(551, 398);
            this.dgBebidas.TabIndex = 9;
            // 
            // dgLanches
            // 
            this.dgLanches.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgLanches.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.NomeLanche,
            this.ValorLanche});
            this.dgLanches.Location = new System.Drawing.Point(604, 150);
            this.dgLanches.Name = "dgLanches";
            this.dgLanches.RowTemplate.Height = 33;
            this.dgLanches.Size = new System.Drawing.Size(565, 398);
            this.dgLanches.TabIndex = 10;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(955, 574);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(214, 57);
            this.button3.TabIndex = 11;
            this.button3.Text = "Salvar";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // Nome
            // 
            this.Nome.DataPropertyName = "Nome";
            this.Nome.HeaderText = "Nome";
            this.Nome.Name = "Nome";
            this.Nome.ReadOnly = true;
            // 
            // Tamanho
            // 
            this.Tamanho.DataPropertyName = "Tamanho";
            this.Tamanho.HeaderText = "Tamanho";
            this.Tamanho.Name = "Tamanho";
            this.Tamanho.ReadOnly = true;
            // 
            // Valor
            // 
            this.Valor.DataPropertyName = "Valor";
            this.Valor.HeaderText = "Valor";
            this.Valor.Name = "Valor";
            this.Valor.ReadOnly = true;
            // 
            // NomeLanche
            // 
            this.NomeLanche.DataPropertyName = "Nome";
            this.NomeLanche.HeaderText = "Nome";
            this.NomeLanche.Name = "NomeLanche";
            // 
            // ValorLanche
            // 
            this.ValorLanche.DataPropertyName = "Valor";
            this.ValorLanche.HeaderText = "Valor";
            this.ValorLanche.Name = "ValorLanche";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(30, 590);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(115, 25);
            this.label4.TabIndex = 12;
            this.label4.Text = "Valor total:";
            // 
            // lbTotal
            // 
            this.lbTotal.AutoSize = true;
            this.lbTotal.Location = new System.Drawing.Point(152, 590);
            this.lbTotal.Name = "lbTotal";
            this.lbTotal.Size = new System.Drawing.Size(0, 25);
            this.lbTotal.TabIndex = 13;
            // 
            // AdicionaPedido
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1206, 686);
            this.Controls.Add(this.lbTotal);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.dgLanches);
            this.Controls.Add(this.dgBebidas);
            this.Controls.Add(this.btAdicionaLanche);
            this.Controls.Add(this.btAdicionaBebida);
            this.Controls.Add(this.cbLanches);
            this.Controls.Add(this.cbBebidas);
            this.Controls.Add(this.cbClientes);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "AdicionaPedido";
            this.Text = "AdicionaPedido";
            this.Load += new System.EventHandler(this.AdicionaPedido_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgBebidas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgLanches)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbClientes;
        private System.Windows.Forms.ComboBox cbBebidas;
        private System.Windows.Forms.ComboBox cbLanches;
        private System.Windows.Forms.Button btAdicionaBebida;
        private System.Windows.Forms.Button btAdicionaLanche;
        private System.Windows.Forms.DataGridView dgBebidas;
        private System.Windows.Forms.DataGridView dgLanches;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nome;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tamanho;
        private System.Windows.Forms.DataGridViewTextBoxColumn Valor;
        private System.Windows.Forms.DataGridViewTextBoxColumn NomeLanche;
        private System.Windows.Forms.DataGridViewTextBoxColumn ValorLanche;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lbTotal;
    }
}