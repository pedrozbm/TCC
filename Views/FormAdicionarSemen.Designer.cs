namespace TCC.Views
{
    partial class FormAdicionarSemen
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
            this.components = new System.ComponentModel.Container();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.txtQuantidade = new System.Windows.Forms.TextBox();
            this.dtpDataValidade = new System.Windows.Forms.DateTimePicker();
            this.comboBoxProprietarios = new System.Windows.Forms.ComboBox();
            this.btnSalvarSemen = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(24, 21);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(100, 20);
            this.txtNome.TabIndex = 0;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // txtQuantidade
            // 
            this.txtQuantidade.Location = new System.Drawing.Point(24, 66);
            this.txtQuantidade.Name = "txtQuantidade";
            this.txtQuantidade.Size = new System.Drawing.Size(100, 20);
            this.txtQuantidade.TabIndex = 2;
            // 
            // dtpDataValidade
            // 
            this.dtpDataValidade.Location = new System.Drawing.Point(3, 112);
            this.dtpDataValidade.Name = "dtpDataValidade";
            this.dtpDataValidade.Size = new System.Drawing.Size(200, 20);
            this.dtpDataValidade.TabIndex = 3;
            // 
            // comboBoxProprietarios
            // 
            this.comboBoxProprietarios.FormattingEnabled = true;
            this.comboBoxProprietarios.Location = new System.Drawing.Point(24, 150);
            this.comboBoxProprietarios.Name = "comboBoxProprietarios";
            this.comboBoxProprietarios.Size = new System.Drawing.Size(121, 21);
            this.comboBoxProprietarios.TabIndex = 4;
            // 
            // btnSalvarSemen
            // 
            this.btnSalvarSemen.Location = new System.Drawing.Point(138, 233);
            this.btnSalvarSemen.Name = "btnSalvarSemen";
            this.btnSalvarSemen.Size = new System.Drawing.Size(75, 23);
            this.btnSalvarSemen.TabIndex = 5;
            this.btnSalvarSemen.Text = "Salvar";
            this.btnSalvarSemen.UseVisualStyleBackColor = true;
            this.btnSalvarSemen.Click += new System.EventHandler(this.btnSalvarSemen_Click_1);
            // 
            // FormAdicionarSemen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(225, 283);
            this.Controls.Add(this.btnSalvarSemen);
            this.Controls.Add(this.comboBoxProprietarios);
            this.Controls.Add(this.dtpDataValidade);
            this.Controls.Add(this.txtQuantidade);
            this.Controls.Add(this.txtNome);
            this.Name = "FormAdicionarSemen";
            this.Text = "FormAdicionarSemen";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.TextBox txtQuantidade;
        private System.Windows.Forms.DateTimePicker dtpDataValidade;
        private System.Windows.Forms.ComboBox comboBoxProprietarios;
        private System.Windows.Forms.Button btnSalvarSemen;
    }
}