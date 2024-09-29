namespace TCC.Views
{
    partial class Semens
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
            this.BtnConsultarSemen = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // BtnConsultarSemen
            // 
            this.BtnConsultarSemen.Location = new System.Drawing.Point(625, 343);
            this.BtnConsultarSemen.Name = "BtnConsultarSemen";
            this.BtnConsultarSemen.Size = new System.Drawing.Size(75, 23);
            this.BtnConsultarSemen.TabIndex = 0;
            this.BtnConsultarSemen.Text = "Consultar";
            this.BtnConsultarSemen.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(84, 40);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(616, 270);
            this.dataGridView1.TabIndex = 1;
            // 
            // Semens
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(782, 412);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.BtnConsultarSemen);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Semens";
            this.Text = "Semens";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BtnConsultarSemen;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}