
namespace Sistema_Elitt
{
    partial class FConsultas
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
            this.dgvVendas = new System.Windows.Forms.DataGridView();
            this.dgvProdutosVenda = new System.Windows.Forms.DataGridView();
            this.gpbVendas = new System.Windows.Forms.GroupBox();
            this.lblOrdenar = new System.Windows.Forms.Label();
            this.rdbAsc = new System.Windows.Forms.RadioButton();
            this.rdbDesc = new System.Windows.Forms.RadioButton();
            this.gpbItensVenda = new System.Windows.Forms.GroupBox();
            this.lblTotalVenda = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVendas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProdutosVenda)).BeginInit();
            this.gpbVendas.SuspendLayout();
            this.gpbItensVenda.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvVendas
            // 
            this.dgvVendas.AllowUserToAddRows = false;
            this.dgvVendas.AllowUserToDeleteRows = false;
            this.dgvVendas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvVendas.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvVendas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvVendas.Location = new System.Drawing.Point(6, 37);
            this.dgvVendas.Name = "dgvVendas";
            this.dgvVendas.ReadOnly = true;
            this.dgvVendas.RowHeadersVisible = false;
            this.dgvVendas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvVendas.Size = new System.Drawing.Size(317, 367);
            this.dgvVendas.TabIndex = 16;
            this.dgvVendas.TabStop = false;
            this.dgvVendas.DoubleClick += new System.EventHandler(this.dgvVendas_DoubleClick);
            // 
            // dgvProdutosVenda
            // 
            this.dgvProdutosVenda.AllowUserToAddRows = false;
            this.dgvProdutosVenda.AllowUserToDeleteRows = false;
            this.dgvProdutosVenda.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvProdutosVenda.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvProdutosVenda.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProdutosVenda.Location = new System.Drawing.Point(6, 19);
            this.dgvProdutosVenda.Name = "dgvProdutosVenda";
            this.dgvProdutosVenda.ReadOnly = true;
            this.dgvProdutosVenda.RowHeadersVisible = false;
            this.dgvProdutosVenda.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvProdutosVenda.Size = new System.Drawing.Size(443, 330);
            this.dgvProdutosVenda.TabIndex = 17;
            this.dgvProdutosVenda.TabStop = false;
            // 
            // gpbVendas
            // 
            this.gpbVendas.Controls.Add(this.lblOrdenar);
            this.gpbVendas.Controls.Add(this.rdbAsc);
            this.gpbVendas.Controls.Add(this.rdbDesc);
            this.gpbVendas.Controls.Add(this.dgvVendas);
            this.gpbVendas.Location = new System.Drawing.Point(38, 13);
            this.gpbVendas.Name = "gpbVendas";
            this.gpbVendas.Size = new System.Drawing.Size(329, 410);
            this.gpbVendas.TabIndex = 18;
            this.gpbVendas.TabStop = false;
            this.gpbVendas.Text = "Listagem de vendas";
            // 
            // lblOrdenar
            // 
            this.lblOrdenar.AutoSize = true;
            this.lblOrdenar.Location = new System.Drawing.Point(6, 18);
            this.lblOrdenar.Name = "lblOrdenar";
            this.lblOrdenar.Size = new System.Drawing.Size(58, 13);
            this.lblOrdenar.TabIndex = 19;
            this.lblOrdenar.Text = "Iniciar dos:";
            // 
            // rdbAsc
            // 
            this.rdbAsc.AutoSize = true;
            this.rdbAsc.Location = new System.Drawing.Point(174, 16);
            this.rdbAsc.Name = "rdbAsc";
            this.rdbAsc.Size = new System.Drawing.Size(84, 17);
            this.rdbAsc.TabIndex = 18;
            this.rdbAsc.TabStop = true;
            this.rdbAsc.Text = "Mais antigos";
            this.rdbAsc.UseVisualStyleBackColor = true;
            this.rdbAsc.Click += new System.EventHandler(this.rdbAsc_Click);
            // 
            // rdbDesc
            // 
            this.rdbDesc.AutoSize = true;
            this.rdbDesc.Location = new System.Drawing.Point(67, 16);
            this.rdbDesc.Name = "rdbDesc";
            this.rdbDesc.Size = new System.Drawing.Size(91, 17);
            this.rdbDesc.TabIndex = 17;
            this.rdbDesc.TabStop = true;
            this.rdbDesc.Text = "Mais recentes";
            this.rdbDesc.UseVisualStyleBackColor = true;
            this.rdbDesc.Click += new System.EventHandler(this.rdbDesc_Click);
            // 
            // gpbItensVenda
            // 
            this.gpbItensVenda.Controls.Add(this.lblTotalVenda);
            this.gpbItensVenda.Controls.Add(this.dgvProdutosVenda);
            this.gpbItensVenda.Location = new System.Drawing.Point(406, 13);
            this.gpbItensVenda.Name = "gpbItensVenda";
            this.gpbItensVenda.Size = new System.Drawing.Size(458, 410);
            this.gpbItensVenda.TabIndex = 19;
            this.gpbItensVenda.TabStop = false;
            this.gpbItensVenda.Text = "Itens da venda";
            // 
            // lblTotalVenda
            // 
            this.lblTotalVenda.AutoSize = true;
            this.lblTotalVenda.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.lblTotalVenda.Location = new System.Drawing.Point(49, 370);
            this.lblTotalVenda.Name = "lblTotalVenda";
            this.lblTotalVenda.Size = new System.Drawing.Size(74, 13);
            this.lblTotalVenda.TabIndex = 18;
            this.lblTotalVenda.Text = "Valor total: R$";
            // 
            // FConsultas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(867, 477);
            this.Controls.Add(this.gpbItensVenda);
            this.Controls.Add(this.gpbVendas);
            this.Name = "FConsultas";
            this.Text = "Conulta";
            ((System.ComponentModel.ISupportInitialize)(this.dgvVendas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProdutosVenda)).EndInit();
            this.gpbVendas.ResumeLayout(false);
            this.gpbVendas.PerformLayout();
            this.gpbItensVenda.ResumeLayout(false);
            this.gpbItensVenda.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvVendas;
        private System.Windows.Forms.DataGridView dgvProdutosVenda;
        private System.Windows.Forms.GroupBox gpbVendas;
        private System.Windows.Forms.Label lblOrdenar;
        private System.Windows.Forms.RadioButton rdbAsc;
        private System.Windows.Forms.RadioButton rdbDesc;
        private System.Windows.Forms.GroupBox gpbItensVenda;
        private System.Windows.Forms.Label lblTotalVenda;
    }
}