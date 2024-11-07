namespace TCC.Views
{
    partial class AdicionarAnimais
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
            this.cbGenero = new System.Windows.Forms.ComboBox();
            this.cbProprietario = new System.Windows.Forms.ComboBox();
            this.cbFazenda = new System.Windows.Forms.ComboBox();
            this.tbNome = new System.Windows.Forms.TextBox();
            this.cbRaca = new System.Windows.Forms.ComboBox();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.tbNascimento = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // cbGenero
            // 
            this.cbGenero.FormattingEnabled = true;
            this.cbGenero.Location = new System.Drawing.Point(78, 107);
            this.cbGenero.Name = "cbGenero";
            this.cbGenero.Size = new System.Drawing.Size(121, 21);
            this.cbGenero.TabIndex = 0;
            // 
            // cbProprietario
            // 
            this.cbProprietario.FormattingEnabled = true;
            this.cbProprietario.Location = new System.Drawing.Point(78, 220);
            this.cbProprietario.Name = "cbProprietario";
            this.cbProprietario.Size = new System.Drawing.Size(121, 21);
            this.cbProprietario.TabIndex = 2;
            // 
            // cbFazenda
            // 
            this.cbFazenda.FormattingEnabled = true;
            this.cbFazenda.Location = new System.Drawing.Point(78, 260);
            this.cbFazenda.Name = "cbFazenda";
            this.cbFazenda.Size = new System.Drawing.Size(121, 21);
            this.cbFazenda.TabIndex = 3;
            // 
            // tbNome
            // 
            this.tbNome.Location = new System.Drawing.Point(78, 45);
            this.tbNome.Name = "tbNome";
            this.tbNome.Size = new System.Drawing.Size(100, 20);
            this.tbNome.TabIndex = 4;
       
            // 
            // cbRaca
            // 
            this.cbRaca.FormattingEnabled = true;
            this.cbRaca.Location = new System.Drawing.Point(78, 144);
            this.cbRaca.Name = "cbRaca";
            this.cbRaca.Size = new System.Drawing.Size(121, 21);
            this.cbRaca.TabIndex = 5;
            // 
            // btnSalvar
            // 
            this.btnSalvar.Location = new System.Drawing.Point(264, 291);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(75, 23);
            this.btnSalvar.TabIndex = 6;
            this.btnSalvar.Text = "SALVAR";
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // tbNascimento
            // 
            this.tbNascimento.Location = new System.Drawing.Point(78, 182);
            this.tbNascimento.Name = "tbNascimento";
            this.tbNascimento.Size = new System.Drawing.Size(121, 20);
            this.tbNascimento.TabIndex = 7;
            // 
            // AdicionarAnimais
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(377, 326);
            this.Controls.Add(this.tbNascimento);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.cbRaca);
            this.Controls.Add(this.tbNome);
            this.Controls.Add(this.cbFazenda);
            this.Controls.Add(this.cbProprietario);
            this.Controls.Add(this.cbGenero);
            this.Name = "AdicionarAnimais";
            this.Text = "AdicionarAnimais";
            this.Load += new System.EventHandler(this.AdicionarAnimais_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbGenero;
        private System.Windows.Forms.ComboBox cbProprietario;
        private System.Windows.Forms.ComboBox cbFazenda;
        private System.Windows.Forms.TextBox tbNome;
        private System.Windows.Forms.ComboBox cbRaca;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.TextBox tbNascimento;
    }
}