
namespace Sistema_Elitt
{
    partial class FProduto
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
            this.gpbCadastro = new System.Windows.Forms.GroupBox();
            this.txtPreco = new System.Windows.Forms.TextBox();
            this.nudQtde = new System.Windows.Forms.NumericUpDown();
            this.btnCadastrar = new System.Windows.Forms.Button();
            this.lblQtde = new System.Windows.Forms.Label();
            this.lblPreco = new System.Windows.Forms.Label();
            this.lblDescr = new System.Windows.Forms.Label();
            this.txtDescr = new System.Windows.Forms.TextBox();
            this.dgvProdutos = new System.Windows.Forms.DataGridView();
            this.gpbLista = new System.Windows.Forms.GroupBox();
            this.lblPesquisa = new System.Windows.Forms.Label();
            this.txtPesquisa = new System.Windows.Forms.TextBox();
            this.txtCod = new System.Windows.Forms.TextBox();
            this.lblCod = new System.Windows.Forms.Label();
            this.btnRemover = new System.Windows.Forms.Button();
            this.gpbSelect = new System.Windows.Forms.GroupBox();
            this.gpbQtde = new System.Windows.Forms.GroupBox();
            this.btnAumentar = new System.Windows.Forms.Button();
            this.nudQtdeSelect = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.txtPrecoSelect = new System.Windows.Forms.TextBox();
            this.btnRelatorio = new System.Windows.Forms.Button();
            this.btnAlterar = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtDescrSelect = new System.Windows.Forms.TextBox();
            this.btnRecuperar = new System.Windows.Forms.Button();
            this.gpbCadastro.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudQtde)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProdutos)).BeginInit();
            this.gpbLista.SuspendLayout();
            this.gpbSelect.SuspendLayout();
            this.gpbQtde.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudQtdeSelect)).BeginInit();
            this.SuspendLayout();
            // 
            // gpbCadastro
            // 
            this.gpbCadastro.Controls.Add(this.txtPreco);
            this.gpbCadastro.Controls.Add(this.nudQtde);
            this.gpbCadastro.Controls.Add(this.btnCadastrar);
            this.gpbCadastro.Controls.Add(this.lblQtde);
            this.gpbCadastro.Controls.Add(this.lblPreco);
            this.gpbCadastro.Controls.Add(this.lblDescr);
            this.gpbCadastro.Controls.Add(this.txtDescr);
            this.gpbCadastro.Location = new System.Drawing.Point(12, 49);
            this.gpbCadastro.Name = "gpbCadastro";
            this.gpbCadastro.Size = new System.Drawing.Size(275, 121);
            this.gpbCadastro.TabIndex = 0;
            this.gpbCadastro.TabStop = false;
            this.gpbCadastro.Text = "Cadastrar produto";
            // 
            // txtPreco
            // 
            this.txtPreco.Location = new System.Drawing.Point(75, 54);
            this.txtPreco.Name = "txtPreco";
            this.txtPreco.Size = new System.Drawing.Size(98, 20);
            this.txtPreco.TabIndex = 1;
            this.txtPreco.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtPreco_KeyUp);
            // 
            // nudQtde
            // 
            this.nudQtde.Location = new System.Drawing.Point(75, 81);
            this.nudQtde.Maximum = new decimal(new int[] {
            -1304428544,
            434162106,
            542,
            0});
            this.nudQtde.Name = "nudQtde";
            this.nudQtde.Size = new System.Drawing.Size(95, 20);
            this.nudQtde.TabIndex = 2;
            // 
            // btnCadastrar
            // 
            this.btnCadastrar.Location = new System.Drawing.Point(186, 57);
            this.btnCadastrar.Name = "btnCadastrar";
            this.btnCadastrar.Size = new System.Drawing.Size(68, 42);
            this.btnCadastrar.TabIndex = 3;
            this.btnCadastrar.Text = "Adicionar";
            this.btnCadastrar.UseVisualStyleBackColor = true;
            this.btnCadastrar.Click += new System.EventHandler(this.btnCadastrar_Click);
            // 
            // lblQtde
            // 
            this.lblQtde.AutoSize = true;
            this.lblQtde.Location = new System.Drawing.Point(7, 83);
            this.lblQtde.Name = "lblQtde";
            this.lblQtde.Size = new System.Drawing.Size(62, 13);
            this.lblQtde.TabIndex = 5;
            this.lblQtde.Text = "Quantidade";
            // 
            // lblPreco
            // 
            this.lblPreco.AutoSize = true;
            this.lblPreco.Location = new System.Drawing.Point(34, 57);
            this.lblPreco.Name = "lblPreco";
            this.lblPreco.Size = new System.Drawing.Size(35, 13);
            this.lblPreco.TabIndex = 3;
            this.lblPreco.Text = "Preço";
            // 
            // lblDescr
            // 
            this.lblDescr.AutoSize = true;
            this.lblDescr.Location = new System.Drawing.Point(14, 31);
            this.lblDescr.Name = "lblDescr";
            this.lblDescr.Size = new System.Drawing.Size(55, 13);
            this.lblDescr.TabIndex = 1;
            this.lblDescr.Text = "Descrição";
            // 
            // txtDescr
            // 
            this.txtDescr.Location = new System.Drawing.Point(75, 28);
            this.txtDescr.Name = "txtDescr";
            this.txtDescr.Size = new System.Drawing.Size(179, 20);
            this.txtDescr.TabIndex = 0;
            // 
            // dgvProdutos
            // 
            this.dgvProdutos.AllowUserToAddRows = false;
            this.dgvProdutos.AllowUserToDeleteRows = false;
            this.dgvProdutos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvProdutos.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvProdutos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProdutos.Location = new System.Drawing.Point(18, 70);
            this.dgvProdutos.Name = "dgvProdutos";
            this.dgvProdutos.ReadOnly = true;
            this.dgvProdutos.RowHeadersVisible = false;
            this.dgvProdutos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvProdutos.Size = new System.Drawing.Size(369, 358);
            this.dgvProdutos.TabIndex = 16;
            this.dgvProdutos.DoubleClick += new System.EventHandler(this.dgvProdutos_DoubleClick);
            // 
            // gpbLista
            // 
            this.gpbLista.Controls.Add(this.lblPesquisa);
            this.gpbLista.Controls.Add(this.dgvProdutos);
            this.gpbLista.Controls.Add(this.txtPesquisa);
            this.gpbLista.Location = new System.Drawing.Point(347, 23);
            this.gpbLista.Name = "gpbLista";
            this.gpbLista.Size = new System.Drawing.Size(402, 434);
            this.gpbLista.TabIndex = 17;
            this.gpbLista.TabStop = false;
            this.gpbLista.Text = "Lista de produtos cadastrados";
            // 
            // lblPesquisa
            // 
            this.lblPesquisa.AutoSize = true;
            this.lblPesquisa.Location = new System.Drawing.Point(15, 28);
            this.lblPesquisa.Name = "lblPesquisa";
            this.lblPesquisa.Size = new System.Drawing.Size(140, 13);
            this.lblPesquisa.TabIndex = 9;
            this.lblPesquisa.Text = "🔎 Pesquisar pela descrição";
            // 
            // txtPesquisa
            // 
            this.txtPesquisa.Location = new System.Drawing.Point(18, 44);
            this.txtPesquisa.Name = "txtPesquisa";
            this.txtPesquisa.Size = new System.Drawing.Size(354, 20);
            this.txtPesquisa.TabIndex = 8;
            this.txtPesquisa.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtPesquisa_KeyUp);
            // 
            // txtCod
            // 
            this.txtCod.Location = new System.Drawing.Point(117, 195);
            this.txtCod.Name = "txtCod";
            this.txtCod.Size = new System.Drawing.Size(113, 20);
            this.txtCod.TabIndex = 8;
            // 
            // lblCod
            // 
            this.lblCod.AutoSize = true;
            this.lblCod.Location = new System.Drawing.Point(26, 198);
            this.lblCod.Name = "lblCod";
            this.lblCod.Size = new System.Drawing.Size(85, 13);
            this.lblCod.TabIndex = 8;
            this.lblCod.Text = "Procurar código:";
            // 
            // btnRemover
            // 
            this.btnRemover.Location = new System.Drawing.Point(207, 114);
            this.btnRemover.Name = "btnRemover";
            this.btnRemover.Size = new System.Drawing.Size(68, 42);
            this.btnRemover.TabIndex = 9;
            this.btnRemover.Text = "Remover";
            this.btnRemover.UseVisualStyleBackColor = true;
            this.btnRemover.Click += new System.EventHandler(this.btnRemover_Click);
            // 
            // gpbSelect
            // 
            this.gpbSelect.Controls.Add(this.gpbQtde);
            this.gpbSelect.Controls.Add(this.txtPrecoSelect);
            this.gpbSelect.Controls.Add(this.btnRelatorio);
            this.gpbSelect.Controls.Add(this.btnRemover);
            this.gpbSelect.Controls.Add(this.btnAlterar);
            this.gpbSelect.Controls.Add(this.label2);
            this.gpbSelect.Controls.Add(this.label3);
            this.gpbSelect.Controls.Add(this.txtDescrSelect);
            this.gpbSelect.Location = new System.Drawing.Point(12, 232);
            this.gpbSelect.Name = "gpbSelect";
            this.gpbSelect.Size = new System.Drawing.Size(303, 225);
            this.gpbSelect.TabIndex = 8;
            this.gpbSelect.TabStop = false;
            this.gpbSelect.Text = "Dados do produto - ";
            // 
            // gpbQtde
            // 
            this.gpbQtde.Controls.Add(this.btnAumentar);
            this.gpbQtde.Controls.Add(this.nudQtdeSelect);
            this.gpbQtde.Controls.Add(this.label1);
            this.gpbQtde.Location = new System.Drawing.Point(6, 89);
            this.gpbQtde.Name = "gpbQtde";
            this.gpbQtde.Size = new System.Drawing.Size(188, 67);
            this.gpbQtde.TabIndex = 11;
            this.gpbQtde.TabStop = false;
            // 
            // btnAumentar
            // 
            this.btnAumentar.Location = new System.Drawing.Point(49, 38);
            this.btnAumentar.Name = "btnAumentar";
            this.btnAumentar.Size = new System.Drawing.Size(118, 23);
            this.btnAumentar.TabIndex = 8;
            this.btnAumentar.Text = "Adicionar unidades";
            this.btnAumentar.UseVisualStyleBackColor = true;
            this.btnAumentar.Click += new System.EventHandler(this.btnAumentar_Click);
            // 
            // nudQtdeSelect
            // 
            this.nudQtdeSelect.Location = new System.Drawing.Point(74, 14);
            this.nudQtdeSelect.Maximum = new decimal(new int[] {
            1241513984,
            370409800,
            542101,
            0});
            this.nudQtdeSelect.Name = "nudQtdeSelect";
            this.nudQtdeSelect.Size = new System.Drawing.Size(95, 20);
            this.nudQtdeSelect.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Quantidade";
            // 
            // txtPrecoSelect
            // 
            this.txtPrecoSelect.Location = new System.Drawing.Point(77, 63);
            this.txtPrecoSelect.Name = "txtPrecoSelect";
            this.txtPrecoSelect.Size = new System.Drawing.Size(98, 20);
            this.txtPrecoSelect.TabIndex = 9;
            // 
            // btnRelatorio
            // 
            this.btnRelatorio.Location = new System.Drawing.Point(17, 158);
            this.btnRelatorio.Name = "btnRelatorio";
            this.btnRelatorio.Size = new System.Drawing.Size(82, 40);
            this.btnRelatorio.TabIndex = 10;
            this.btnRelatorio.Text = "Relatório";
            this.btnRelatorio.UseVisualStyleBackColor = true;
            this.btnRelatorio.Click += new System.EventHandler(this.btnRelatorio_Click);
            // 
            // btnAlterar
            // 
            this.btnAlterar.Location = new System.Drawing.Point(207, 66);
            this.btnAlterar.Name = "btnAlterar";
            this.btnAlterar.Size = new System.Drawing.Size(68, 42);
            this.btnAlterar.TabIndex = 6;
            this.btnAlterar.Text = "Salvar";
            this.btnAlterar.UseVisualStyleBackColor = true;
            this.btnAlterar.Click += new System.EventHandler(this.btnAlterar_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(36, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Preço";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 40);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Descrição";
            // 
            // txtDescrSelect
            // 
            this.txtDescrSelect.Location = new System.Drawing.Point(77, 37);
            this.txtDescrSelect.Name = "txtDescrSelect";
            this.txtDescrSelect.Size = new System.Drawing.Size(179, 20);
            this.txtDescrSelect.TabIndex = 0;
            // 
            // btnRecuperar
            // 
            this.btnRecuperar.Location = new System.Drawing.Point(236, 189);
            this.btnRecuperar.Name = "btnRecuperar";
            this.btnRecuperar.Size = new System.Drawing.Size(40, 31);
            this.btnRecuperar.TabIndex = 9;
            this.btnRecuperar.Text = "🔎";
            this.btnRecuperar.UseVisualStyleBackColor = true;
            this.btnRecuperar.Click += new System.EventHandler(this.btnRecuperar_Click);
            // 
            // FProduto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(769, 469);
            this.Controls.Add(this.btnRecuperar);
            this.Controls.Add(this.gpbSelect);
            this.Controls.Add(this.lblCod);
            this.Controls.Add(this.gpbLista);
            this.Controls.Add(this.gpbCadastro);
            this.Controls.Add(this.txtCod);
            this.Name = "FProduto";
            this.Text = "Produtos";
            this.gpbCadastro.ResumeLayout(false);
            this.gpbCadastro.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudQtde)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProdutos)).EndInit();
            this.gpbLista.ResumeLayout(false);
            this.gpbLista.PerformLayout();
            this.gpbSelect.ResumeLayout(false);
            this.gpbSelect.PerformLayout();
            this.gpbQtde.ResumeLayout(false);
            this.gpbQtde.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudQtdeSelect)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gpbCadastro;
        private System.Windows.Forms.Label lblDescr;
        private System.Windows.Forms.TextBox txtDescr;
        private System.Windows.Forms.Label lblQtde;
        private System.Windows.Forms.Label lblPreco;
        private System.Windows.Forms.Button btnCadastrar;
        private System.Windows.Forms.NumericUpDown nudQtde;
        private System.Windows.Forms.DataGridView dgvProdutos;
        private System.Windows.Forms.GroupBox gpbLista;
        private System.Windows.Forms.Label lblPesquisa;
        private System.Windows.Forms.TextBox txtPesquisa;
        private System.Windows.Forms.TextBox txtCod;
        private System.Windows.Forms.Label lblCod;
        private System.Windows.Forms.Button btnRemover;
        private System.Windows.Forms.GroupBox gpbSelect;
        private System.Windows.Forms.Button btnRelatorio;
        private System.Windows.Forms.NumericUpDown nudQtdeSelect;
        private System.Windows.Forms.Button btnAlterar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtDescrSelect;
        private System.Windows.Forms.TextBox txtPreco;
        private System.Windows.Forms.TextBox txtPrecoSelect;
        private System.Windows.Forms.Button btnRecuperar;
        private System.Windows.Forms.GroupBox gpbQtde;
        private System.Windows.Forms.Button btnAumentar;
    }
}