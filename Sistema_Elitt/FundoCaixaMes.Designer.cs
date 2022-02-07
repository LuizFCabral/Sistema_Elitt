namespace Sistema_Elitt
{
    partial class FundoCaixaMes
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
            this.lblTotalVendas = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dgvFundoCaixaMes = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFundoCaixaMes)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTotalVendas
            // 
            this.lblTotalVendas.AutoSize = true;
            this.lblTotalVendas.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalVendas.Location = new System.Drawing.Point(712, 443);
            this.lblTotalVendas.Name = "lblTotalVendas";
            this.lblTotalVendas.Size = new System.Drawing.Size(30, 20);
            this.lblTotalVendas.TabIndex = 28;
            this.lblTotalVendas.Text = "R$";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(654, 443);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 20);
            this.label3.TabIndex = 27;
            this.label3.Text = "Total: ";
            // 
            // dgvFundoCaixaMes
            // 
            this.dgvFundoCaixaMes.AllowUserToAddRows = false;
            this.dgvFundoCaixaMes.AllowUserToDeleteRows = false;
            this.dgvFundoCaixaMes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvFundoCaixaMes.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvFundoCaixaMes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvFundoCaixaMes.Location = new System.Drawing.Point(12, 30);
            this.dgvFundoCaixaMes.Name = "dgvFundoCaixaMes";
            this.dgvFundoCaixaMes.ReadOnly = true;
            this.dgvFundoCaixaMes.RowHeadersVisible = false;
            this.dgvFundoCaixaMes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvFundoCaixaMes.Size = new System.Drawing.Size(796, 381);
            this.dgvFundoCaixaMes.TabIndex = 26;
            this.dgvFundoCaixaMes.TabStop = false;
            // 
            // FundoCaixaMes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(866, 535);
            this.Controls.Add(this.lblTotalVendas);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dgvFundoCaixaMes);
            this.Name = "FundoCaixaMes";
            this.Text = "FundoCaixaMes";
            this.Load += new System.EventHandler(this.FundoCaixaMes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvFundoCaixaMes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblTotalVendas;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dgvFundoCaixaMes;
    }
}