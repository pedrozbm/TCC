namespace TCC.Views
{
    partial class FormSemens
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
            this.dgvSemens = new System.Windows.Forms.DataGridView();
            this.btnExcluirSemen = new System.Windows.Forms.Button();
            this.btnAdicionarSemen = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSemens)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvSemens
            // 
            this.dgvSemens.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSemens.Location = new System.Drawing.Point(1, 1);
            this.dgvSemens.Name = "dgvSemens";
            this.dgvSemens.Size = new System.Drawing.Size(433, 288);
            this.dgvSemens.TabIndex = 0;
            // 
            // btnExcluirSemen
            // 
            this.btnExcluirSemen.Location = new System.Drawing.Point(462, 73);
            this.btnExcluirSemen.Name = "btnExcluirSemen";
            this.btnExcluirSemen.Size = new System.Drawing.Size(75, 23);
            this.btnExcluirSemen.TabIndex = 1;
            this.btnExcluirSemen.Text = "Excluir";
            this.btnExcluirSemen.UseVisualStyleBackColor = true;
            this.btnExcluirSemen.Click += new System.EventHandler(this.btnExcluirSemen_Click);
            // 
            // btnAdicionarSemen
            // 
            this.btnAdicionarSemen.Location = new System.Drawing.Point(462, 32);
            this.btnAdicionarSemen.Name = "btnAdicionarSemen";
            this.btnAdicionarSemen.Size = new System.Drawing.Size(75, 23);
            this.btnAdicionarSemen.TabIndex = 2;
            this.btnAdicionarSemen.Text = "Adicionar";
            this.btnAdicionarSemen.UseVisualStyleBackColor = true;
            this.btnAdicionarSemen.Click += new System.EventHandler(this.btnAdicionarSemen_Click);
            // 
            // FormSemens
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(587, 294);
            this.Controls.Add(this.btnAdicionarSemen);
            this.Controls.Add(this.btnExcluirSemen);
            this.Controls.Add(this.dgvSemens);
            this.Name = "FormSemens";
            this.Text = "FormSemens";
            ((System.ComponentModel.ISupportInitialize)(this.dgvSemens)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvSemens;
        private System.Windows.Forms.Button btnExcluirSemen;
        private System.Windows.Forms.Button btnAdicionarSemen;
    }
}