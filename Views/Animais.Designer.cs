namespace TCC
{
    partial class Animais
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
            this.btnConsultaAnimais = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnConsultaAnimais
            // 
            this.btnConsultaAnimais.Location = new System.Drawing.Point(251, 96);
            this.btnConsultaAnimais.Name = "btnConsultaAnimais";
            this.btnConsultaAnimais.Size = new System.Drawing.Size(75, 23);
            this.btnConsultaAnimais.TabIndex = 0;
            this.btnConsultaAnimais.Text = "Consultar";
            this.btnConsultaAnimais.UseVisualStyleBackColor = true;
            this.btnConsultaAnimais.Click += new System.EventHandler(this.button1_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(251, 136);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(349, 209);
            this.dataGridView1.TabIndex = 1;
            // 
            // Animais
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(782, 412);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnConsultaAnimais);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Animais";
            this.Text = "Animais";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnConsultaAnimais;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}