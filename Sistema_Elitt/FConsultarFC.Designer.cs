namespace Sistema_Elitt
{
    partial class FConsultarFC
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
            this.dgvFundoCaixa = new System.Windows.Forms.DataGridView();
            this.dtpDataI = new System.Windows.Forms.DateTimePicker();
            this.btnBuscarPData = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dtpDataF = new System.Windows.Forms.DateTimePicker();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFundoCaixa)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvFundoCaixa
            // 
            this.dgvFundoCaixa.AllowUserToAddRows = false;
            this.dgvFundoCaixa.AllowUserToDeleteRows = false;
            this.dgvFundoCaixa.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvFundoCaixa.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvFundoCaixa.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvFundoCaixa.Location = new System.Drawing.Point(41, 115);
            this.dgvFundoCaixa.Name = "dgvFundoCaixa";
            this.dgvFundoCaixa.ReadOnly = true;
            this.dgvFundoCaixa.RowHeadersVisible = false;
            this.dgvFundoCaixa.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvFundoCaixa.Size = new System.Drawing.Size(796, 475);
            this.dgvFundoCaixa.TabIndex = 16;
            this.dgvFundoCaixa.TabStop = false;
            // 
            // dtpDataI
            // 
            this.dtpDataI.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpDataI.Location = new System.Drawing.Point(41, 64);
            this.dtpDataI.Name = "dtpDataI";
            this.dtpDataI.Size = new System.Drawing.Size(322, 26);
            this.dtpDataI.TabIndex = 17;
            // 
            // btnBuscarPData
            // 
            this.btnBuscarPData.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscarPData.Location = new System.Drawing.Point(712, 61);
            this.btnBuscarPData.Name = "btnBuscarPData";
            this.btnBuscarPData.Size = new System.Drawing.Size(50, 37);
            this.btnBuscarPData.TabIndex = 18;
            this.btnBuscarPData.Text = "🔎";
            this.btnBuscarPData.UseVisualStyleBackColor = true;
            this.btnBuscarPData.Click += new System.EventHandler(this.btnRecuperar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(37, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 20);
            this.label1.TabIndex = 19;
            this.label1.Text = "Data início";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(380, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 20);
            this.label2.TabIndex = 21;
            this.label2.Text = "Data final";
            // 
            // dtpDataF
            // 
            this.dtpDataF.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpDataF.Location = new System.Drawing.Point(384, 64);
            this.dtpDataF.Name = "dtpDataF";
            this.dtpDataF.Size = new System.Drawing.Size(322, 26);
            this.dtpDataF.TabIndex = 20;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(768, 61);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(69, 37);
            this.button1.TabIndex = 22;
            this.button1.Text = "Todos os Caixas";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // FConsultarFC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(910, 620);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dtpDataF);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnBuscarPData);
            this.Controls.Add(this.dtpDataI);
            this.Controls.Add(this.dgvFundoCaixa);
            this.Name = "FConsultarFC";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Consultar Fundo de Caixa";
            ((System.ComponentModel.ISupportInitialize)(this.dgvFundoCaixa)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dgvFundoCaixa;
        private System.Windows.Forms.DateTimePicker dtpDataI;
        private System.Windows.Forms.Button btnBuscarPData;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dtpDataF;
        private System.Windows.Forms.Button button1;
    }
}