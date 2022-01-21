
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
            this.gpbVendasD = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.rdbMad = new System.Windows.Forms.RadioButton();
            this.rdbMrd = new System.Windows.Forms.RadioButton();
            this.dgvVendasD = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVendas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProdutosVenda)).BeginInit();
            this.gpbVendas.SuspendLayout();
            this.gpbItensVenda.SuspendLayout();
            this.gpbVendasD.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVendasD)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvVendas
            // 
            this.dgvVendas.AllowUserToAddRows = false;
            this.dgvVendas.AllowUserToDeleteRows = false;
            this.dgvVendas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvVendas.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvVendas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvVendas.Location = new System.Drawing.Point(6, 66);
            this.dgvVendas.Name = "dgvVendas";
            this.dgvVendas.ReadOnly = true;
            this.dgvVendas.RowHeadersVisible = false;
            this.dgvVendas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvVendas.Size = new System.Drawing.Size(415, 376);
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
            this.dgvProdutosVenda.Location = new System.Drawing.Point(6, 66);
            this.dgvProdutosVenda.Name = "dgvProdutosVenda";
            this.dgvProdutosVenda.ReadOnly = true;
            this.dgvProdutosVenda.RowHeadersVisible = false;
            this.dgvProdutosVenda.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvProdutosVenda.Size = new System.Drawing.Size(397, 330);
            this.dgvProdutosVenda.TabIndex = 17;
            this.dgvProdutosVenda.TabStop = false;
            // 
            // gpbVendas
            // 
            this.gpbVendas.Controls.Add(this.lblOrdenar);
            this.gpbVendas.Controls.Add(this.rdbAsc);
            this.gpbVendas.Controls.Add(this.rdbDesc);
            this.gpbVendas.Controls.Add(this.dgvVendas);
            this.gpbVendas.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpbVendas.Location = new System.Drawing.Point(12, 75);
            this.gpbVendas.Name = "gpbVendas";
            this.gpbVendas.Size = new System.Drawing.Size(427, 448);
            this.gpbVendas.TabIndex = 18;
            this.gpbVendas.TabStop = false;
            this.gpbVendas.Text = "Vendas Cartão";
            // 
            // lblOrdenar
            // 
            this.lblOrdenar.AutoSize = true;
            this.lblOrdenar.Location = new System.Drawing.Point(6, 31);
            this.lblOrdenar.Name = "lblOrdenar";
            this.lblOrdenar.Size = new System.Drawing.Size(71, 16);
            this.lblOrdenar.TabIndex = 19;
            this.lblOrdenar.Text = "Iniciar dos:";
            // 
            // rdbAsc
            // 
            this.rdbAsc.AutoSize = true;
            this.rdbAsc.Location = new System.Drawing.Point(190, 29);
            this.rdbAsc.Name = "rdbAsc";
            this.rdbAsc.Size = new System.Drawing.Size(101, 20);
            this.rdbAsc.TabIndex = 18;
            this.rdbAsc.TabStop = true;
            this.rdbAsc.Text = "Mais antigos";
            this.rdbAsc.UseVisualStyleBackColor = true;
            this.rdbAsc.Click += new System.EventHandler(this.rdbAsc_Click);
            // 
            // rdbDesc
            // 
            this.rdbDesc.AutoSize = true;
            this.rdbDesc.Location = new System.Drawing.Point(83, 29);
            this.rdbDesc.Name = "rdbDesc";
            this.rdbDesc.Size = new System.Drawing.Size(109, 20);
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
            this.gpbItensVenda.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpbItensVenda.Location = new System.Drawing.Point(890, 75);
            this.gpbItensVenda.Name = "gpbItensVenda";
            this.gpbItensVenda.Size = new System.Drawing.Size(421, 448);
            this.gpbItensVenda.TabIndex = 19;
            this.gpbItensVenda.TabStop = false;
            this.gpbItensVenda.Text = "Itens da venda";
            // 
            // lblTotalVenda
            // 
            this.lblTotalVenda.AutoSize = true;
            this.lblTotalVenda.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.lblTotalVenda.Location = new System.Drawing.Point(50, 417);
            this.lblTotalVenda.Name = "lblTotalVenda";
            this.lblTotalVenda.Size = new System.Drawing.Size(90, 16);
            this.lblTotalVenda.TabIndex = 18;
            this.lblTotalVenda.Text = "Valor total: R$";
            // 
            // gpbVendasD
            // 
            this.gpbVendasD.Controls.Add(this.label1);
            this.gpbVendasD.Controls.Add(this.rdbMad);
            this.gpbVendasD.Controls.Add(this.rdbMrd);
            this.gpbVendasD.Controls.Add(this.dgvVendasD);
            this.gpbVendasD.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpbVendasD.Location = new System.Drawing.Point(445, 75);
            this.gpbVendasD.Name = "gpbVendasD";
            this.gpbVendasD.Size = new System.Drawing.Size(427, 448);
            this.gpbVendasD.TabIndex = 20;
            this.gpbVendasD.TabStop = false;
            this.gpbVendasD.Text = "Vendas Dinheiro";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 16);
            this.label1.TabIndex = 19;
            this.label1.Text = "Iniciar dos:";
            // 
            // rdbMad
            // 
            this.rdbMad.AutoSize = true;
            this.rdbMad.Location = new System.Drawing.Point(190, 27);
            this.rdbMad.Name = "rdbMad";
            this.rdbMad.Size = new System.Drawing.Size(101, 20);
            this.rdbMad.TabIndex = 18;
            this.rdbMad.Text = "Mais antigos";
            this.rdbMad.UseVisualStyleBackColor = true;
            this.rdbMad.CheckedChanged += new System.EventHandler(this.rdbMad_CheckedChanged);
            // 
            // rdbMrd
            // 
            this.rdbMrd.AutoSize = true;
            this.rdbMrd.Checked = true;
            this.rdbMrd.Location = new System.Drawing.Point(83, 27);
            this.rdbMrd.Name = "rdbMrd";
            this.rdbMrd.Size = new System.Drawing.Size(109, 20);
            this.rdbMrd.TabIndex = 17;
            this.rdbMrd.TabStop = true;
            this.rdbMrd.Text = "Mais recentes";
            this.rdbMrd.UseVisualStyleBackColor = true;
            this.rdbMrd.CheckedChanged += new System.EventHandler(this.rdbMrd_CheckedChanged);
            // 
            // dgvVendasD
            // 
            this.dgvVendasD.AllowUserToAddRows = false;
            this.dgvVendasD.AllowUserToDeleteRows = false;
            this.dgvVendasD.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvVendasD.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvVendasD.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvVendasD.Location = new System.Drawing.Point(6, 66);
            this.dgvVendasD.Name = "dgvVendasD";
            this.dgvVendasD.ReadOnly = true;
            this.dgvVendasD.RowHeadersVisible = false;
            this.dgvVendasD.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvVendasD.Size = new System.Drawing.Size(415, 376);
            this.dgvVendasD.TabIndex = 16;
            this.dgvVendasD.TabStop = false;
            this.dgvVendasD.DoubleClick += new System.EventHandler(this.dgvVendasD_DoubleClick);
            // 
            // FConsultas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1323, 582);
            this.Controls.Add(this.gpbVendasD);
            this.Controls.Add(this.gpbItensVenda);
            this.Controls.Add(this.gpbVendas);
            this.Name = "FConsultas";
            this.Text = "Conulta";
            this.Load += new System.EventHandler(this.FConsultas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvVendas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProdutosVenda)).EndInit();
            this.gpbVendas.ResumeLayout(false);
            this.gpbVendas.PerformLayout();
            this.gpbItensVenda.ResumeLayout(false);
            this.gpbItensVenda.PerformLayout();
            this.gpbVendasD.ResumeLayout(false);
            this.gpbVendasD.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVendasD)).EndInit();
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
        private System.Windows.Forms.GroupBox gpbVendasD;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton rdbMad;
        private System.Windows.Forms.RadioButton rdbMrd;
        private System.Windows.Forms.DataGridView dgvVendasD;
    }
}