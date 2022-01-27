namespace Sistema_Elitt
{
    partial class FCaixaDia
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
            this.gpbCartCred = new System.Windows.Forms.GroupBox();
            this.dgvCartCred = new System.Windows.Forms.DataGridView();
            this.gpbCartDeb = new System.Windows.Forms.GroupBox();
            this.dgvCartDeb = new System.Windows.Forms.DataGridView();
            this.gpbDinheiro = new System.Windows.Forms.GroupBox();
            this.dgvDinheiro = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.txtFundoCaixa = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnFinalizarCaixa = new System.Windows.Forms.Button();
            this.lblTotalDia = new System.Windows.Forms.Label();
            this.gpbItensVenda = new System.Windows.Forms.GroupBox();
            this.dgvProdutosVenda = new System.Windows.Forms.DataGridView();
            this.lblTotalVenda = new System.Windows.Forms.Label();
            this.gpbCartCred.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCartCred)).BeginInit();
            this.gpbCartDeb.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCartDeb)).BeginInit();
            this.gpbDinheiro.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDinheiro)).BeginInit();
            this.gpbItensVenda.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProdutosVenda)).BeginInit();
            this.SuspendLayout();
            // 
            // gpbCartCred
            // 
            this.gpbCartCred.Controls.Add(this.dgvCartCred);
            this.gpbCartCred.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpbCartCred.Location = new System.Drawing.Point(12, 81);
            this.gpbCartCred.Name = "gpbCartCred";
            this.gpbCartCred.Size = new System.Drawing.Size(439, 341);
            this.gpbCartCred.TabIndex = 21;
            this.gpbCartCred.TabStop = false;
            this.gpbCartCred.Text = "Cartão de Crédito";
            // 
            // dgvCartCred
            // 
            this.dgvCartCred.AllowUserToAddRows = false;
            this.dgvCartCred.AllowUserToDeleteRows = false;
            this.dgvCartCred.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvCartCred.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvCartCred.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCartCred.Location = new System.Drawing.Point(7, 25);
            this.dgvCartCred.Name = "dgvCartCred";
            this.dgvCartCred.ReadOnly = true;
            this.dgvCartCred.RowHeadersVisible = false;
            this.dgvCartCred.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvCartCred.Size = new System.Drawing.Size(427, 308);
            this.dgvCartCred.TabIndex = 16;
            this.dgvCartCred.TabStop = false;
            this.dgvCartCred.DoubleClick += new System.EventHandler(this.dgvCartCred_DoubleClick);
            // 
            // gpbCartDeb
            // 
            this.gpbCartDeb.Controls.Add(this.dgvCartDeb);
            this.gpbCartDeb.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpbCartDeb.Location = new System.Drawing.Point(462, 81);
            this.gpbCartDeb.Name = "gpbCartDeb";
            this.gpbCartDeb.Size = new System.Drawing.Size(439, 341);
            this.gpbCartDeb.TabIndex = 22;
            this.gpbCartDeb.TabStop = false;
            this.gpbCartDeb.Text = "Cartão de Débito";
            // 
            // dgvCartDeb
            // 
            this.dgvCartDeb.AllowUserToAddRows = false;
            this.dgvCartDeb.AllowUserToDeleteRows = false;
            this.dgvCartDeb.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvCartDeb.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvCartDeb.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCartDeb.Location = new System.Drawing.Point(6, 25);
            this.dgvCartDeb.Name = "dgvCartDeb";
            this.dgvCartDeb.ReadOnly = true;
            this.dgvCartDeb.RowHeadersVisible = false;
            this.dgvCartDeb.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvCartDeb.Size = new System.Drawing.Size(427, 308);
            this.dgvCartDeb.TabIndex = 16;
            this.dgvCartDeb.TabStop = false;
            this.dgvCartDeb.DoubleClick += new System.EventHandler(this.dgvCartDeb_DoubleClick);
            // 
            // gpbDinheiro
            // 
            this.gpbDinheiro.Controls.Add(this.dgvDinheiro);
            this.gpbDinheiro.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpbDinheiro.Location = new System.Drawing.Point(912, 81);
            this.gpbDinheiro.Name = "gpbDinheiro";
            this.gpbDinheiro.Size = new System.Drawing.Size(439, 341);
            this.gpbDinheiro.TabIndex = 23;
            this.gpbDinheiro.TabStop = false;
            this.gpbDinheiro.Text = "Dinheiro";
            // 
            // dgvDinheiro
            // 
            this.dgvDinheiro.AllowUserToAddRows = false;
            this.dgvDinheiro.AllowUserToDeleteRows = false;
            this.dgvDinheiro.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDinheiro.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvDinheiro.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDinheiro.Location = new System.Drawing.Point(6, 25);
            this.dgvDinheiro.Name = "dgvDinheiro";
            this.dgvDinheiro.ReadOnly = true;
            this.dgvDinheiro.RowHeadersVisible = false;
            this.dgvDinheiro.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDinheiro.Size = new System.Drawing.Size(427, 308);
            this.dgvDinheiro.TabIndex = 16;
            this.dgvDinheiro.TabStop = false;
            this.dgvDinheiro.DoubleClick += new System.EventHandler(this.dgvDinheiro_DoubleClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(19, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(120, 20);
            this.label1.TabIndex = 24;
            this.label1.Text = "Fundo de Caixa";
            // 
            // txtFundoCaixa
            // 
            this.txtFundoCaixa.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFundoCaixa.Location = new System.Drawing.Point(145, 24);
            this.txtFundoCaixa.Name = "txtFundoCaixa";
            this.txtFundoCaixa.Size = new System.Drawing.Size(112, 26);
            this.txtFundoCaixa.TabIndex = 25;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(859, 571);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(119, 20);
            this.label2.TabIndex = 26;
            this.label2.Text = "Total do Dia R$";
            // 
            // btnFinalizarCaixa
            // 
            this.btnFinalizarCaixa.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFinalizarCaixa.Location = new System.Drawing.Point(1063, 562);
            this.btnFinalizarCaixa.Name = "btnFinalizarCaixa";
            this.btnFinalizarCaixa.Size = new System.Drawing.Size(167, 38);
            this.btnFinalizarCaixa.TabIndex = 28;
            this.btnFinalizarCaixa.Text = "Finalizar Caixa";
            this.btnFinalizarCaixa.UseVisualStyleBackColor = true;
            this.btnFinalizarCaixa.Click += new System.EventHandler(this.btnFinalizarCaixa_Click);
            // 
            // lblTotalDia
            // 
            this.lblTotalDia.AutoSize = true;
            this.lblTotalDia.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalDia.Location = new System.Drawing.Point(974, 571);
            this.lblTotalDia.Name = "lblTotalDia";
            this.lblTotalDia.Size = new System.Drawing.Size(0, 20);
            this.lblTotalDia.TabIndex = 29;
            // 
            // gpbItensVenda
            // 
            this.gpbItensVenda.Controls.Add(this.lblTotalVenda);
            this.gpbItensVenda.Controls.Add(this.dgvProdutosVenda);
            this.gpbItensVenda.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpbItensVenda.Location = new System.Drawing.Point(23, 443);
            this.gpbItensVenda.Name = "gpbItensVenda";
            this.gpbItensVenda.Size = new System.Drawing.Size(428, 294);
            this.gpbItensVenda.TabIndex = 30;
            this.gpbItensVenda.TabStop = false;
            this.gpbItensVenda.Text = "Itens da Venda";
            this.gpbItensVenda.Visible = false;
            // 
            // dgvProdutosVenda
            // 
            this.dgvProdutosVenda.AllowUserToAddRows = false;
            this.dgvProdutosVenda.AllowUserToDeleteRows = false;
            this.dgvProdutosVenda.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvProdutosVenda.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvProdutosVenda.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProdutosVenda.Location = new System.Drawing.Point(6, 37);
            this.dgvProdutosVenda.Name = "dgvProdutosVenda";
            this.dgvProdutosVenda.ReadOnly = true;
            this.dgvProdutosVenda.RowHeadersVisible = false;
            this.dgvProdutosVenda.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvProdutosVenda.Size = new System.Drawing.Size(415, 200);
            this.dgvProdutosVenda.TabIndex = 17;
            this.dgvProdutosVenda.TabStop = false;
            // 
            // lblTotalVenda
            // 
            this.lblTotalVenda.AutoSize = true;
            this.lblTotalVenda.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.lblTotalVenda.Location = new System.Drawing.Point(15, 259);
            this.lblTotalVenda.Name = "lblTotalVenda";
            this.lblTotalVenda.Size = new System.Drawing.Size(90, 16);
            this.lblTotalVenda.TabIndex = 31;
            this.lblTotalVenda.Text = "Valor total: R$";
            // 
            // FCaixaDia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1364, 749);
            this.Controls.Add(this.gpbItensVenda);
            this.Controls.Add(this.lblTotalDia);
            this.Controls.Add(this.btnFinalizarCaixa);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtFundoCaixa);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.gpbDinheiro);
            this.Controls.Add(this.gpbCartDeb);
            this.Controls.Add(this.gpbCartCred);
            this.Name = "FCaixaDia";
            this.ShowIcon = false;
            this.Text = "FCaixaDia";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.MouseEnter += new System.EventHandler(this.FCaixaDia_MouseEnter);
            this.gpbCartCred.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCartCred)).EndInit();
            this.gpbCartDeb.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCartDeb)).EndInit();
            this.gpbDinheiro.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDinheiro)).EndInit();
            this.gpbItensVenda.ResumeLayout(false);
            this.gpbItensVenda.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProdutosVenda)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gpbCartCred;
        private System.Windows.Forms.DataGridView dgvCartCred;
        private System.Windows.Forms.GroupBox gpbCartDeb;
        private System.Windows.Forms.DataGridView dgvCartDeb;
        private System.Windows.Forms.GroupBox gpbDinheiro;
        private System.Windows.Forms.DataGridView dgvDinheiro;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtFundoCaixa;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnFinalizarCaixa;
        private System.Windows.Forms.Label lblTotalDia;
        private System.Windows.Forms.GroupBox gpbItensVenda;
        private System.Windows.Forms.DataGridView dgvProdutosVenda;
        private System.Windows.Forms.Label lblTotalVenda;
    }
}