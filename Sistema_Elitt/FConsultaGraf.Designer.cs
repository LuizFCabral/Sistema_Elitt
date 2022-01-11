
namespace Sistema_Elitt
{
    partial class FConsultaGraf
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.chtProdAno = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.txtAno = new System.Windows.Forms.TextBox();
            this.lblAno = new System.Windows.Forms.Label();
            this.dgvResultados = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.chtProdAno)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvResultados)).BeginInit();
            this.SuspendLayout();
            // 
            // chtProdAno
            // 
            chartArea1.Name = "ChartArea1";
            this.chtProdAno.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chtProdAno.Legends.Add(legend1);
            this.chtProdAno.Location = new System.Drawing.Point(36, 53);
            this.chtProdAno.Name = "chtProdAno";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chtProdAno.Series.Add(series1);
            this.chtProdAno.Size = new System.Drawing.Size(300, 300);
            this.chtProdAno.TabIndex = 0;
            this.chtProdAno.Text = "chart1";
            // 
            // txtAno
            // 
            this.txtAno.Location = new System.Drawing.Point(158, 27);
            this.txtAno.Name = "txtAno";
            this.txtAno.Size = new System.Drawing.Size(115, 20);
            this.txtAno.TabIndex = 1;
            // 
            // lblAno
            // 
            this.lblAno.AutoSize = true;
            this.lblAno.Location = new System.Drawing.Point(33, 30);
            this.lblAno.Name = "lblAno";
            this.lblAno.Size = new System.Drawing.Size(119, 13);
            this.lblAno.TabIndex = 2;
            this.lblAno.Text = "Ano do relatório gráfico:";
            // 
            // dgvResultados
            // 
            this.dgvResultados.AllowUserToAddRows = false;
            this.dgvResultados.AllowUserToDeleteRows = false;
            this.dgvResultados.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvResultados.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvResultados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvResultados.Location = new System.Drawing.Point(417, 87);
            this.dgvResultados.Name = "dgvResultados";
            this.dgvResultados.ReadOnly = true;
            this.dgvResultados.RowHeadersVisible = false;
            this.dgvResultados.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvResultados.Size = new System.Drawing.Size(231, 186);
            this.dgvResultados.TabIndex = 17;
            this.dgvResultados.Visible = false;
            // 
            // FConsultaGraf
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dgvResultados);
            this.Controls.Add(this.lblAno);
            this.Controls.Add(this.txtAno);
            this.Controls.Add(this.chtProdAno);
            this.Name = "FConsultaGraf";
            this.Text = "FConsultaGraf";
            ((System.ComponentModel.ISupportInitialize)(this.chtProdAno)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvResultados)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart chtProdAno;
        private System.Windows.Forms.TextBox txtAno;
        private System.Windows.Forms.Label lblAno;
        private System.Windows.Forms.DataGridView dgvResultados;
    }
}