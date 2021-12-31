
namespace Sistema_Elitt
{
    partial class FQtde
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
            this.btnAdicionar = new System.Windows.Forms.Button();
            this.nudNumUnidades = new System.Windows.Forms.NumericUpDown();
            this.lblNumUnidades = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.nudNumUnidades)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAdicionar
            // 
            this.btnAdicionar.Location = new System.Drawing.Point(54, 64);
            this.btnAdicionar.Name = "btnAdicionar";
            this.btnAdicionar.Size = new System.Drawing.Size(75, 23);
            this.btnAdicionar.TabIndex = 0;
            this.btnAdicionar.Text = "Adicionar";
            this.btnAdicionar.UseVisualStyleBackColor = true;
            this.btnAdicionar.Click += new System.EventHandler(this.btnAdicionar_Click);
            // 
            // nudNumUnidades
            // 
            this.nudNumUnidades.Location = new System.Drawing.Point(31, 38);
            this.nudNumUnidades.Name = "nudNumUnidades";
            this.nudNumUnidades.Size = new System.Drawing.Size(120, 20);
            this.nudNumUnidades.TabIndex = 1;
            // 
            // lblNumUnidades
            // 
            this.lblNumUnidades.AutoSize = true;
            this.lblNumUnidades.Location = new System.Drawing.Point(42, 22);
            this.lblNumUnidades.Name = "lblNumUnidades";
            this.lblNumUnidades.Size = new System.Drawing.Size(99, 13);
            this.lblNumUnidades.TabIndex = 2;
            this.lblNumUnidades.Text = "Quantas unidades?";
            // 
            // FQtde
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(291, 102);
            this.Controls.Add(this.lblNumUnidades);
            this.Controls.Add(this.nudNumUnidades);
            this.Controls.Add(this.btnAdicionar);
            this.Name = "FQtde";
            this.Text = "Adicionar unidades de";
            ((System.ComponentModel.ISupportInitialize)(this.nudNumUnidades)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAdicionar;
        private System.Windows.Forms.NumericUpDown nudNumUnidades;
        private System.Windows.Forms.Label lblNumUnidades;
    }
}