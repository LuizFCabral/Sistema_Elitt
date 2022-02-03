
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
            this.label1 = new System.Windows.Forms.Label();
            this.cmbCredDeb = new System.Windows.Forms.ComboBox();
            this.gpbItensVenda = new System.Windows.Forms.GroupBox();
            this.lblTotalVenda = new System.Windows.Forms.Label();
            this.gpbVendasD = new System.Windows.Forms.GroupBox();
            this.dgvVendasD = new System.Windows.Forms.DataGridView();
            this.lbl2 = new System.Windows.Forms.Label();
            this.lbl3 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblTotalVendaC = new System.Windows.Forms.Label();
            this.lblTotalVendaD = new System.Windows.Forms.Label();
            this.lblTotalDasVendas = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dtpDataF = new System.Windows.Forms.DateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            this.btnBuscarPData = new System.Windows.Forms.Button();
            this.dtpDataI = new System.Windows.Forms.DateTimePicker();
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
            this.dgvVendas.Size = new System.Drawing.Size(439, 376);
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
            this.gpbVendas.Controls.Add(this.label1);
            this.gpbVendas.Controls.Add(this.cmbCredDeb);
            this.gpbVendas.Controls.Add(this.dgvVendas);
            this.gpbVendas.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpbVendas.Location = new System.Drawing.Point(11, 132);
            this.gpbVendas.Name = "gpbVendas";
            this.gpbVendas.Size = new System.Drawing.Size(451, 448);
            this.gpbVendas.TabIndex = 18;
            this.gpbVendas.TabStop = false;
            this.gpbVendas.Text = "Cartão";
            this.gpbVendas.Enter += new System.EventHandler(this.gpbVendas_Enter);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(18, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 20);
            this.label1.TabIndex = 32;
            this.label1.Text = "Cred/Deb";
            // 
            // cmbCredDeb
            // 
            this.cmbCredDeb.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.cmbCredDeb.AutoCompleteCustomSource.AddRange(new string[] {
            ""});
            this.cmbCredDeb.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbCredDeb.FormattingEnabled = true;
            this.cmbCredDeb.Items.AddRange(new object[] {
            "Crédito",
            "Débito"});
            this.cmbCredDeb.Location = new System.Drawing.Point(101, 32);
            this.cmbCredDeb.Name = "cmbCredDeb";
            this.cmbCredDeb.Size = new System.Drawing.Size(126, 28);
            this.cmbCredDeb.TabIndex = 32;
            this.cmbCredDeb.SelectedIndexChanged += new System.EventHandler(this.cmbCredDeb_SelectedIndexChanged);
            // 
            // gpbItensVenda
            // 
            this.gpbItensVenda.Controls.Add(this.lblTotalVenda);
            this.gpbItensVenda.Controls.Add(this.dgvProdutosVenda);
            this.gpbItensVenda.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpbItensVenda.Location = new System.Drawing.Point(941, 132);
            this.gpbItensVenda.Name = "gpbItensVenda";
            this.gpbItensVenda.Size = new System.Drawing.Size(410, 448);
            this.gpbItensVenda.TabIndex = 19;
            this.gpbItensVenda.TabStop = false;
            this.gpbItensVenda.Text = "Itens da venda";
            this.gpbItensVenda.Enter += new System.EventHandler(this.gpbItensVenda_Enter);
            // 
            // lblTotalVenda
            // 
            this.lblTotalVenda.AutoSize = true;
            this.lblTotalVenda.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.lblTotalVenda.Location = new System.Drawing.Point(40, 411);
            this.lblTotalVenda.Name = "lblTotalVenda";
            this.lblTotalVenda.Size = new System.Drawing.Size(110, 20);
            this.lblTotalVenda.TabIndex = 18;
            this.lblTotalVenda.Text = "Valor total: R$";
            // 
            // gpbVendasD
            // 
            this.gpbVendasD.Controls.Add(this.dgvVendasD);
            this.gpbVendasD.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpbVendasD.Location = new System.Drawing.Point(468, 132);
            this.gpbVendasD.Name = "gpbVendasD";
            this.gpbVendasD.Size = new System.Drawing.Size(451, 448);
            this.gpbVendasD.TabIndex = 20;
            this.gpbVendasD.TabStop = false;
            this.gpbVendasD.Text = "Dinheiro";
            this.gpbVendasD.Enter += new System.EventHandler(this.gpbVendasD_Enter);
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
            this.dgvVendasD.Size = new System.Drawing.Size(439, 376);
            this.dgvVendasD.TabIndex = 16;
            this.dgvVendasD.TabStop = false;
            this.dgvVendasD.DoubleClick += new System.EventHandler(this.dgvVendasD_DoubleClick);
            // 
            // lbl2
            // 
            this.lbl2.AutoSize = true;
            this.lbl2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl2.Location = new System.Drawing.Point(49, 628);
            this.lbl2.Name = "lbl2";
            this.lbl2.Size = new System.Drawing.Size(117, 40);
            this.lbl2.TabIndex = 23;
            this.lbl2.Text = "Total de Venda\r\n    por cartão";
            this.lbl2.Click += new System.EventHandler(this.lbl2_Click);
            // 
            // lbl3
            // 
            this.lbl3.AutoSize = true;
            this.lbl3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl3.Location = new System.Drawing.Point(262, 628);
            this.lbl3.Name = "lbl3";
            this.lbl3.Size = new System.Drawing.Size(117, 40);
            this.lbl3.TabIndex = 24;
            this.lbl3.Text = "Total de Venda\r\n  por dinheiro\r\n";
            this.lbl3.Click += new System.EventHandler(this.lbl3_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(478, 628);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(182, 20);
            this.label3.TabIndex = 25;
            this.label3.Text = "Total de todas as Venda";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // lblTotalVendaC
            // 
            this.lblTotalVendaC.AutoSize = true;
            this.lblTotalVendaC.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalVendaC.Location = new System.Drawing.Point(172, 637);
            this.lblTotalVendaC.Name = "lblTotalVendaC";
            this.lblTotalVendaC.Size = new System.Drawing.Size(34, 20);
            this.lblTotalVendaC.TabIndex = 26;
            this.lblTotalVendaC.Text = "R$ ";
            this.lblTotalVendaC.Click += new System.EventHandler(this.lblTotalVendaC_Click);
            // 
            // lblTotalVendaD
            // 
            this.lblTotalVendaD.AutoSize = true;
            this.lblTotalVendaD.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalVendaD.Location = new System.Drawing.Point(385, 637);
            this.lblTotalVendaD.Name = "lblTotalVendaD";
            this.lblTotalVendaD.Size = new System.Drawing.Size(34, 20);
            this.lblTotalVendaD.TabIndex = 27;
            this.lblTotalVendaD.Text = "R$ ";
            this.lblTotalVendaD.Click += new System.EventHandler(this.lblTotalVendaD_Click);
            // 
            // lblTotalDasVendas
            // 
            this.lblTotalDasVendas.AutoSize = true;
            this.lblTotalDasVendas.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalDasVendas.Location = new System.Drawing.Point(666, 628);
            this.lblTotalDasVendas.Name = "lblTotalDasVendas";
            this.lblTotalDasVendas.Size = new System.Drawing.Size(34, 20);
            this.lblTotalDasVendas.TabIndex = 28;
            this.lblTotalDasVendas.Text = "R$ ";
            this.lblTotalDasVendas.Click += new System.EventHandler(this.lblTotalDasVendas_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(162, 637);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(13, 20);
            this.label4.TabIndex = 29;
            this.label4.Text = ":";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(375, 637);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(13, 20);
            this.label5.TabIndex = 30;
            this.label5.Text = ":";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(654, 628);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(13, 20);
            this.label6.TabIndex = 31;
            this.label6.Text = ":";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(366, 36);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 20);
            this.label2.TabIndex = 36;
            this.label2.Text = "Data final";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // dtpDataF
            // 
            this.dtpDataF.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpDataF.Location = new System.Drawing.Point(370, 59);
            this.dtpDataF.Name = "dtpDataF";
            this.dtpDataF.Size = new System.Drawing.Size(322, 26);
            this.dtpDataF.TabIndex = 35;
            this.dtpDataF.ValueChanged += new System.EventHandler(this.dtpDataF_ValueChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(23, 36);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(83, 20);
            this.label7.TabIndex = 34;
            this.label7.Text = "Data início";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // btnBuscarPData
            // 
            this.btnBuscarPData.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscarPData.Location = new System.Drawing.Point(698, 56);
            this.btnBuscarPData.Name = "btnBuscarPData";
            this.btnBuscarPData.Size = new System.Drawing.Size(50, 37);
            this.btnBuscarPData.TabIndex = 33;
            this.btnBuscarPData.Text = "🔎";
            this.btnBuscarPData.UseVisualStyleBackColor = true;
            this.btnBuscarPData.Click += new System.EventHandler(this.btnBuscarPData_Click);
            // 
            // dtpDataI
            // 
            this.dtpDataI.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpDataI.Location = new System.Drawing.Point(27, 59);
            this.dtpDataI.Name = "dtpDataI";
            this.dtpDataI.Size = new System.Drawing.Size(322, 26);
            this.dtpDataI.TabIndex = 32;
            this.dtpDataI.ValueChanged += new System.EventHandler(this.dtpDataI_ValueChanged);
            // 
            // FConsultas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1364, 749);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dtpDataF);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.btnBuscarPData);
            this.Controls.Add(this.dtpDataI);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lblTotalDasVendas);
            this.Controls.Add(this.lblTotalVendaD);
            this.Controls.Add(this.lblTotalVendaC);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lbl3);
            this.Controls.Add(this.lbl2);
            this.Controls.Add(this.gpbVendasD);
            this.Controls.Add(this.gpbItensVenda);
            this.Controls.Add(this.gpbVendas);
            this.Name = "FConsultas";
            this.Text = "Conulta";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.dgvVendas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProdutosVenda)).EndInit();
            this.gpbVendas.ResumeLayout(false);
            this.gpbVendas.PerformLayout();
            this.gpbItensVenda.ResumeLayout(false);
            this.gpbItensVenda.PerformLayout();
            this.gpbVendasD.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvVendasD)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvVendas;
        private System.Windows.Forms.DataGridView dgvProdutosVenda;
        private System.Windows.Forms.GroupBox gpbVendas;
        private System.Windows.Forms.GroupBox gpbItensVenda;
        private System.Windows.Forms.Label lblTotalVenda;
        private System.Windows.Forms.GroupBox gpbVendasD;
        private System.Windows.Forms.DataGridView dgvVendasD;
        private System.Windows.Forms.Label lbl2;
        private System.Windows.Forms.Label lbl3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblTotalVendaC;
        private System.Windows.Forms.Label lblTotalVendaD;
        private System.Windows.Forms.Label lblTotalDasVendas;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbCredDeb;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dtpDataF;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnBuscarPData;
        private System.Windows.Forms.DateTimePicker dtpDataI;
    }
}