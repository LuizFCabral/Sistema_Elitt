
namespace Sistema_Elitt
{
    partial class Form1
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.caixaDoDiaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnProd = new System.Windows.Forms.ToolStripMenuItem();
            this.btnConsulta = new System.Windows.Forms.ToolStripMenuItem();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.lblTotal = new System.Windows.Forms.Label();
            this.gpbItens = new System.Windows.Forms.GroupBox();
            this.btnRemover = new System.Windows.Forms.Button();
            this.txtCodProduto = new System.Windows.Forms.TextBox();
            this.lblCodProduto = new System.Windows.Forms.Label();
            this.lblValorU = new System.Windows.Forms.Label();
            this.txtValorU = new System.Windows.Forms.TextBox();
            this.txtDescr = new System.Windows.Forms.TextBox();
            this.lblDescr = new System.Windows.Forms.Label();
            this.txtQuant = new System.Windows.Forms.TextBox();
            this.btnIncluir = new System.Windows.Forms.Button();
            this.btnBrowse = new System.Windows.Forms.Button();
            this.lblQuantidade = new System.Windows.Forms.Label();
            this.dgvVenda = new System.Windows.Forms.DataGridView();
            this.btnFinalizar = new System.Windows.Forms.Button();
            this.txtRecebido = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtTroco = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbTipoVenda = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnConsultarFC = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.gpbItens.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVenda)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.caixaDoDiaToolStripMenuItem,
            this.btnProd,
            this.btnConsulta,
            this.btnConsultarFC});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1282, 29);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // caixaDoDiaToolStripMenuItem
            // 
            this.caixaDoDiaToolStripMenuItem.Name = "caixaDoDiaToolStripMenuItem";
            this.caixaDoDiaToolStripMenuItem.Size = new System.Drawing.Size(108, 25);
            this.caixaDoDiaToolStripMenuItem.Text = "Caixa do Dia";
            this.caixaDoDiaToolStripMenuItem.Click += new System.EventHandler(this.caixaDoDiaToolStripMenuItem_Click);
            // 
            // btnProd
            // 
            this.btnProd.Name = "btnProd";
            this.btnProd.Size = new System.Drawing.Size(85, 25);
            this.btnProd.Text = "Produtos";
            this.btnProd.Click += new System.EventHandler(this.btnProd_Click);
            // 
            // btnConsulta
            // 
            this.btnConsulta.Name = "btnConsulta";
            this.btnConsulta.Size = new System.Drawing.Size(90, 25);
            this.btnConsulta.Text = "Consultas";
            this.btnConsulta.Click += new System.EventHandler(this.btnConsulta_Click);
            // 
            // txtTotal
            // 
            this.txtTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotal.Location = new System.Drawing.Point(963, 446);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.ReadOnly = true;
            this.txtTotal.Size = new System.Drawing.Size(90, 26);
            this.txtTotal.TabIndex = 17;
            this.txtTotal.TabStop = false;
            this.txtTotal.Text = "00,00";
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotal.Location = new System.Drawing.Point(901, 449);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(56, 20);
            this.lblTotal.TabIndex = 18;
            this.lblTotal.Text = "Total : ";
            // 
            // gpbItens
            // 
            this.gpbItens.Controls.Add(this.btnRemover);
            this.gpbItens.Controls.Add(this.txtCodProduto);
            this.gpbItens.Controls.Add(this.lblCodProduto);
            this.gpbItens.Controls.Add(this.lblValorU);
            this.gpbItens.Controls.Add(this.txtValorU);
            this.gpbItens.Controls.Add(this.txtDescr);
            this.gpbItens.Controls.Add(this.lblDescr);
            this.gpbItens.Controls.Add(this.txtQuant);
            this.gpbItens.Controls.Add(this.btnIncluir);
            this.gpbItens.Controls.Add(this.btnBrowse);
            this.gpbItens.Controls.Add(this.lblQuantidade);
            this.gpbItens.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpbItens.Location = new System.Drawing.Point(72, 114);
            this.gpbItens.Name = "gpbItens";
            this.gpbItens.Size = new System.Drawing.Size(424, 372);
            this.gpbItens.TabIndex = 16;
            this.gpbItens.TabStop = false;
            this.gpbItens.Text = "Adicionar itens:";
            // 
            // btnRemover
            // 
            this.btnRemover.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRemover.Location = new System.Drawing.Point(191, 318);
            this.btnRemover.Name = "btnRemover";
            this.btnRemover.Size = new System.Drawing.Size(102, 33);
            this.btnRemover.TabIndex = 15;
            this.btnRemover.TabStop = false;
            this.btnRemover.Text = "Remover";
            this.btnRemover.UseVisualStyleBackColor = true;
            this.btnRemover.Visible = false;
            this.btnRemover.Click += new System.EventHandler(this.btnRemover_Click);
            // 
            // txtCodProduto
            // 
            this.txtCodProduto.Location = new System.Drawing.Point(22, 67);
            this.txtCodProduto.Name = "txtCodProduto";
            this.txtCodProduto.Size = new System.Drawing.Size(100, 26);
            this.txtCodProduto.TabIndex = 1;
            this.txtCodProduto.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCodProduto_KeyPress);
            this.txtCodProduto.Leave += new System.EventHandler(this.txtCodProduto_Leave);
            // 
            // lblCodProduto
            // 
            this.lblCodProduto.AutoSize = true;
            this.lblCodProduto.Location = new System.Drawing.Point(19, 44);
            this.lblCodProduto.Name = "lblCodProduto";
            this.lblCodProduto.Size = new System.Drawing.Size(59, 20);
            this.lblCodProduto.TabIndex = 14;
            this.lblCodProduto.Text = "Código";
            // 
            // lblValorU
            // 
            this.lblValorU.AutoSize = true;
            this.lblValorU.Location = new System.Drawing.Point(19, 213);
            this.lblValorU.Name = "lblValorU";
            this.lblValorU.Size = new System.Drawing.Size(102, 20);
            this.lblValorU.TabIndex = 12;
            this.lblValorU.Text = "Valor unitário";
            // 
            // txtValorU
            // 
            this.txtValorU.Enabled = false;
            this.txtValorU.Location = new System.Drawing.Point(22, 236);
            this.txtValorU.Name = "txtValorU";
            this.txtValorU.ReadOnly = true;
            this.txtValorU.Size = new System.Drawing.Size(170, 26);
            this.txtValorU.TabIndex = 4;
            this.txtValorU.TabStop = false;
            // 
            // txtDescr
            // 
            this.txtDescr.Enabled = false;
            this.txtDescr.Location = new System.Drawing.Point(22, 121);
            this.txtDescr.Name = "txtDescr";
            this.txtDescr.ReadOnly = true;
            this.txtDescr.Size = new System.Drawing.Size(170, 26);
            this.txtDescr.TabIndex = 2;
            this.txtDescr.TabStop = false;
            // 
            // lblDescr
            // 
            this.lblDescr.AutoSize = true;
            this.lblDescr.Location = new System.Drawing.Point(19, 102);
            this.lblDescr.Name = "lblDescr";
            this.lblDescr.Size = new System.Drawing.Size(80, 20);
            this.lblDescr.TabIndex = 4;
            this.lblDescr.Text = "Descrição";
            // 
            // txtQuant
            // 
            this.txtQuant.Location = new System.Drawing.Point(22, 175);
            this.txtQuant.Name = "txtQuant";
            this.txtQuant.Size = new System.Drawing.Size(170, 26);
            this.txtQuant.TabIndex = 3;
            this.txtQuant.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtQuant_KeyPress);
            this.txtQuant.Leave += new System.EventHandler(this.txtQuant_Leave);
            // 
            // btnIncluir
            // 
            this.btnIncluir.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIncluir.Location = new System.Drawing.Point(309, 318);
            this.btnIncluir.Name = "btnIncluir";
            this.btnIncluir.Size = new System.Drawing.Size(83, 33);
            this.btnIncluir.TabIndex = 6;
            this.btnIncluir.Text = "+";
            this.btnIncluir.UseVisualStyleBackColor = true;
            this.btnIncluir.Click += new System.EventHandler(this.btnIncluir_Click);
            // 
            // btnBrowse
            // 
            this.btnBrowse.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBrowse.Location = new System.Drawing.Point(279, 65);
            this.btnBrowse.Name = "btnBrowse";
            this.btnBrowse.Size = new System.Drawing.Size(113, 36);
            this.btnBrowse.TabIndex = 3;
            this.btnBrowse.TabStop = false;
            this.btnBrowse.Text = "Ver produtos";
            this.btnBrowse.UseVisualStyleBackColor = true;
            this.btnBrowse.Click += new System.EventHandler(this.btnBrowse_Click);
            // 
            // lblQuantidade
            // 
            this.lblQuantidade.AutoSize = true;
            this.lblQuantidade.Location = new System.Drawing.Point(18, 156);
            this.lblQuantidade.Name = "lblQuantidade";
            this.lblQuantidade.Size = new System.Drawing.Size(92, 20);
            this.lblQuantidade.TabIndex = 5;
            this.lblQuantidade.Text = "Quantidade";
            // 
            // dgvVenda
            // 
            this.dgvVenda.AllowUserToAddRows = false;
            this.dgvVenda.AllowUserToDeleteRows = false;
            this.dgvVenda.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvVenda.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvVenda.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvVenda.Location = new System.Drawing.Point(597, 73);
            this.dgvVenda.Name = "dgvVenda";
            this.dgvVenda.ReadOnly = true;
            this.dgvVenda.RowHeadersVisible = false;
            this.dgvVenda.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvVenda.Size = new System.Drawing.Size(620, 351);
            this.dgvVenda.TabIndex = 15;
            this.dgvVenda.TabStop = false;
            this.dgvVenda.DoubleClick += new System.EventHandler(this.dgvVenda_DoubleClick);
            // 
            // btnFinalizar
            // 
            this.btnFinalizar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFinalizar.Location = new System.Drawing.Point(1077, 444);
            this.btnFinalizar.Name = "btnFinalizar";
            this.btnFinalizar.Size = new System.Drawing.Size(140, 42);
            this.btnFinalizar.TabIndex = 14;
            this.btnFinalizar.Text = "Finalizar venda";
            this.btnFinalizar.UseVisualStyleBackColor = true;
            this.btnFinalizar.Click += new System.EventHandler(this.btnFinalizar_Click);
            // 
            // txtRecebido
            // 
            this.txtRecebido.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRecebido.Location = new System.Drawing.Point(963, 481);
            this.txtRecebido.Name = "txtRecebido";
            this.txtRecebido.Size = new System.Drawing.Size(90, 26);
            this.txtRecebido.TabIndex = 19;
            this.txtRecebido.TabStop = false;
            this.txtRecebido.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtRecebido_KeyPress);
            this.txtRecebido.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtRecebido_KeyUp);
            this.txtRecebido.Leave += new System.EventHandler(this.txtRecebido_Leave);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(805, 484);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(152, 20);
            this.label1.TabIndex = 20;
            this.label1.Text = "Dinheiro Recebido : ";
            // 
            // txtTroco
            // 
            this.txtTroco.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTroco.Location = new System.Drawing.Point(963, 515);
            this.txtTroco.Name = "txtTroco";
            this.txtTroco.ReadOnly = true;
            this.txtTroco.Size = new System.Drawing.Size(90, 26);
            this.txtTroco.TabIndex = 21;
            this.txtTroco.TabStop = false;
            this.txtTroco.Text = "00,00";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(896, 515);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 20);
            this.label2.TabIndex = 22;
            this.label2.Text = "Troco : ";
            // 
            // cmbTipoVenda
            // 
            this.cmbTipoVenda.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbTipoVenda.FormattingEnabled = true;
            this.cmbTipoVenda.Items.AddRange(new object[] {
            "Dinheiro",
            "Crédito",
            "Débito"});
            this.cmbTipoVenda.Location = new System.Drawing.Point(597, 481);
            this.cmbTipoVenda.Name = "cmbTipoVenda";
            this.cmbTipoVenda.Size = new System.Drawing.Size(189, 28);
            this.cmbTipoVenda.TabIndex = 23;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(593, 455);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(112, 20);
            this.label3.TabIndex = 24;
            this.label3.Text = "Tipo da Venda";
            // 
            // btnConsultarFC
            // 
            this.btnConsultarFC.Name = "btnConsultarFC";
            this.btnConsultarFC.Size = new System.Drawing.Size(199, 25);
            this.btnConsultarFC.Text = "Consultar Fundo de Caixa";
            this.btnConsultarFC.Click += new System.EventHandler(this.btnConsultarFC_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1282, 579);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cmbTipoVenda);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtTroco);
            this.Controls.Add(this.txtRecebido);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtTotal);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.gpbItens);
            this.Controls.Add(this.dgvVenda);
            this.Controls.Add(this.btnFinalizar);
            this.Controls.Add(this.menuStrip1);
            this.Name = "Form1";
            this.Text = "Caixa";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.gpbItens.ResumeLayout(false);
            this.gpbItens.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVenda)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem btnProd;
        private System.Windows.Forms.ToolStripMenuItem btnConsulta;
        private System.Windows.Forms.TextBox txtTotal;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.GroupBox gpbItens;
        private System.Windows.Forms.Button btnRemover;
        private System.Windows.Forms.TextBox txtCodProduto;
        private System.Windows.Forms.Label lblCodProduto;
        private System.Windows.Forms.Label lblValorU;
        private System.Windows.Forms.TextBox txtValorU;
        private System.Windows.Forms.TextBox txtDescr;
        private System.Windows.Forms.Label lblDescr;
        private System.Windows.Forms.TextBox txtQuant;
        private System.Windows.Forms.Button btnIncluir;
        private System.Windows.Forms.Button btnBrowse;
        private System.Windows.Forms.Label lblQuantidade;
        private System.Windows.Forms.DataGridView dgvVenda;
        private System.Windows.Forms.Button btnFinalizar;
        private System.Windows.Forms.TextBox txtRecebido;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtTroco;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbTipoVenda;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ToolStripMenuItem caixaDoDiaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem btnConsultarFC;
    }
}

