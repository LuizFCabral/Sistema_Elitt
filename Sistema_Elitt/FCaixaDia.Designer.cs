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
            this.dgvVendasD = new System.Windows.Forms.DataGridView();
            this.gpbCartDeb = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.gpbDinheiro = new System.Windows.Forms.GroupBox();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.txtFundoCaixa = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnFinalizarCaixa = new System.Windows.Forms.Button();
            this.lblTotalDia = new System.Windows.Forms.Label();
            this.gpbCartCred.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVendasD)).BeginInit();
            this.gpbCartDeb.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.gpbDinheiro.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // gpbCartCred
            // 
            this.gpbCartCred.Controls.Add(this.dgvVendasD);
            this.gpbCartCred.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpbCartCred.Location = new System.Drawing.Point(12, 81);
            this.gpbCartCred.Name = "gpbCartCred";
            this.gpbCartCred.Size = new System.Drawing.Size(439, 402);
            this.gpbCartCred.TabIndex = 21;
            this.gpbCartCred.TabStop = false;
            this.gpbCartCred.Text = "Cartão de Crédito";
            // 
            // dgvVendasD
            // 
            this.dgvVendasD.AllowUserToAddRows = false;
            this.dgvVendasD.AllowUserToDeleteRows = false;
            this.dgvVendasD.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvVendasD.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvVendasD.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvVendasD.Location = new System.Drawing.Point(7, 25);
            this.dgvVendasD.Name = "dgvVendasD";
            this.dgvVendasD.ReadOnly = true;
            this.dgvVendasD.RowHeadersVisible = false;
            this.dgvVendasD.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvVendasD.Size = new System.Drawing.Size(427, 363);
            this.dgvVendasD.TabIndex = 16;
            this.dgvVendasD.TabStop = false;
            // 
            // gpbCartDeb
            // 
            this.gpbCartDeb.Controls.Add(this.dataGridView1);
            this.gpbCartDeb.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpbCartDeb.Location = new System.Drawing.Point(462, 81);
            this.gpbCartDeb.Name = "gpbCartDeb";
            this.gpbCartDeb.Size = new System.Drawing.Size(439, 402);
            this.gpbCartDeb.TabIndex = 22;
            this.gpbCartDeb.TabStop = false;
            this.gpbCartDeb.Text = "Cartão de Débito";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(6, 25);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(427, 363);
            this.dataGridView1.TabIndex = 16;
            this.dataGridView1.TabStop = false;
            // 
            // gpbDinheiro
            // 
            this.gpbDinheiro.Controls.Add(this.dataGridView2);
            this.gpbDinheiro.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpbDinheiro.Location = new System.Drawing.Point(912, 81);
            this.gpbDinheiro.Name = "gpbDinheiro";
            this.gpbDinheiro.Size = new System.Drawing.Size(439, 402);
            this.gpbDinheiro.TabIndex = 23;
            this.gpbDinheiro.TabStop = false;
            this.gpbDinheiro.Text = "Dinheiro";
            // 
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToAddRows = false;
            this.dataGridView2.AllowUserToDeleteRows = false;
            this.dataGridView2.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView2.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(6, 25);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.ReadOnly = true;
            this.dataGridView2.RowHeadersVisible = false;
            this.dataGridView2.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView2.Size = new System.Drawing.Size(427, 363);
            this.dataGridView2.TabIndex = 16;
            this.dataGridView2.TabStop = false;
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
            this.label2.Location = new System.Drawing.Point(30, 534);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 20);
            this.label2.TabIndex = 26;
            this.label2.Text = "Total do Dia";
            // 
            // btnFinalizarCaixa
            // 
            this.btnFinalizarCaixa.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFinalizarCaixa.Location = new System.Drawing.Point(234, 525);
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
            this.lblTotalDia.Location = new System.Drawing.Point(130, 534);
            this.lblTotalDia.Name = "lblTotalDia";
            this.lblTotalDia.Size = new System.Drawing.Size(30, 20);
            this.lblTotalDia.TabIndex = 29;
            this.lblTotalDia.Text = "R$";
            // 
            // FCaixaDia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1364, 749);
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
            this.gpbCartCred.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvVendasD)).EndInit();
            this.gpbCartDeb.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.gpbDinheiro.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gpbCartCred;
        private System.Windows.Forms.DataGridView dgvVendasD;
        private System.Windows.Forms.GroupBox gpbCartDeb;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.GroupBox gpbDinheiro;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtFundoCaixa;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnFinalizarCaixa;
        private System.Windows.Forms.Label lblTotalDia;
    }
}