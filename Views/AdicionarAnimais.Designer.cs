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
            this.components = new System.ComponentModel.Container();
            this.labelIDAnimal = new System.Windows.Forms.Label();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.animaisBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.cbRaca = new System.Windows.Forms.ComboBox();
            this.labelSexo = new System.Windows.Forms.Label();
            this.cbGenero = new System.Windows.Forms.ComboBox();
            this.labelProprietario = new System.Windows.Forms.Label();
            this.cbProprietario = new System.Windows.Forms.ComboBox();
            this.labelFazenda = new System.Windows.Forms.Label();
            this.cbFazenda = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dtpDataNascimento = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.animaisBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // labelIDAnimal
            // 
            this.labelIDAnimal.AutoSize = true;
            this.labelIDAnimal.Location = new System.Drawing.Point(48, 65);
            this.labelIDAnimal.Name = "labelIDAnimal";
            this.labelIDAnimal.Size = new System.Drawing.Size(61, 16);
            this.labelIDAnimal.TabIndex = 0;
            this.labelIDAnimal.Text = "IDAnimal";
            this.labelIDAnimal.Click += new System.EventHandler(this.label1_Click);
            // 
            // btnSalvar
            // 
            this.btnSalvar.Location = new System.Drawing.Point(603, 261);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(92, 43);
            this.btnSalvar.TabIndex = 1;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.button1_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.DataSource = this.animaisBindingSource;
            this.comboBox1.DisplayMember = "ID_Animal";
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(115, 62);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(169, 24);
            this.comboBox1.TabIndex = 2;
            this.comboBox1.ValueMember = "ID_Animal";
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(48, 129);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 16);
            this.label1.TabIndex = 3;
            this.label1.Text = "Raça";
            // 
            // cbRaca
            // 
            this.cbRaca.DataSource = this.animaisBindingSource;
            this.cbRaca.DisplayMember = "ID_Raca";
            this.cbRaca.FormattingEnabled = true;
            this.cbRaca.Location = new System.Drawing.Point(115, 121);
            this.cbRaca.Name = "cbRaca";
            this.cbRaca.Size = new System.Drawing.Size(169, 24);
            this.cbRaca.TabIndex = 4;
            this.cbRaca.ValueMember = "ID_Raca";
            // 
            // labelSexo
            // 
            this.labelSexo.AutoSize = true;
            this.labelSexo.Location = new System.Drawing.Point(48, 189);
            this.labelSexo.Name = "labelSexo";
            this.labelSexo.Size = new System.Drawing.Size(38, 16);
            this.labelSexo.TabIndex = 5;
            this.labelSexo.Text = "Sexo";
            this.labelSexo.Click += new System.EventHandler(this.label2_Click);
            // 
            // cbGenero
            // 
            this.cbGenero.FormattingEnabled = true;
            this.cbGenero.Location = new System.Drawing.Point(115, 186);
            this.cbGenero.Name = "cbGenero";
            this.cbGenero.Size = new System.Drawing.Size(169, 24);
            this.cbGenero.TabIndex = 6;
            // 
            // labelProprietario
            // 
            this.labelProprietario.AutoSize = true;
            this.labelProprietario.BackColor = System.Drawing.Color.Transparent;
            this.labelProprietario.Font = new System.Drawing.Font("Microsoft JhengHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelProprietario.Location = new System.Drawing.Point(369, 61);
            this.labelProprietario.Name = "labelProprietario";
            this.labelProprietario.Size = new System.Drawing.Size(130, 25);
            this.labelProprietario.TabIndex = 7;
            this.labelProprietario.Text = "Proprietário";
            this.labelProprietario.Click += new System.EventHandler(this.labelProprietario_Click);
            // 
            // cbProprietario
            // 
            this.cbProprietario.DataSource = this.animaisBindingSource;
            this.cbProprietario.DropDownHeight = 110;
            this.cbProprietario.FormattingEnabled = true;
            this.cbProprietario.IntegralHeight = false;
            this.cbProprietario.Location = new System.Drawing.Point(503, 62);
            this.cbProprietario.Name = "cbProprietario";
            this.cbProprietario.Size = new System.Drawing.Size(172, 24);
            this.cbProprietario.TabIndex = 8;
            // 
            // labelFazenda
            // 
            this.labelFazenda.AutoSize = true;
            this.labelFazenda.Location = new System.Drawing.Point(420, 129);
            this.labelFazenda.Name = "labelFazenda";
            this.labelFazenda.Size = new System.Drawing.Size(60, 16);
            this.labelFazenda.TabIndex = 9;
            this.labelFazenda.Text = "Fazenda";
            // 
            // cbFazenda
            // 
            this.cbFazenda.DataSource = this.animaisBindingSource;
            this.cbFazenda.FormattingEnabled = true;
            this.cbFazenda.Location = new System.Drawing.Point(503, 126);
            this.cbFazenda.Name = "cbFazenda";
            this.cbFazenda.Size = new System.Drawing.Size(172, 24);
            this.cbFazenda.TabIndex = 10;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(420, 194);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 16);
            this.label2.TabIndex = 11;
            this.label2.Text = "Nascimento";
            // 
            // dtpDataNascimento
            // 
            this.dtpDataNascimento.Location = new System.Drawing.Point(515, 194);
            this.dtpDataNascimento.Name = "dtpDataNascimento";
            this.dtpDataNascimento.Size = new System.Drawing.Size(200, 22);
            this.dtpDataNascimento.TabIndex = 12;
            // 
            // AdicionarAnimais
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkCyan;
            this.ClientSize = new System.Drawing.Size(806, 383);
            this.Controls.Add(this.dtpDataNascimento);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cbFazenda);
            this.Controls.Add(this.labelFazenda);
            this.Controls.Add(this.cbProprietario);
            this.Controls.Add(this.labelProprietario);
            this.Controls.Add(this.cbGenero);
            this.Controls.Add(this.labelSexo);
            this.Controls.Add(this.cbRaca);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.labelIDAnimal);
            this.Name = "AdicionarAnimais";
            this.Text = "AdicionarAnimais";
            ((System.ComponentModel.ISupportInitialize)(this.animaisBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelIDAnimal;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.BindingSource animaisBindingSource;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbRaca;
        private System.Windows.Forms.Label labelSexo;
        private System.Windows.Forms.ComboBox cbGenero;
        private System.Windows.Forms.Label labelProprietario;
        private System.Windows.Forms.ComboBox cbProprietario;
        private System.Windows.Forms.Label labelFazenda;
        private System.Windows.Forms.ComboBox cbFazenda;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dtpDataNascimento;
    }
}