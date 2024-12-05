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
            this.labelNome = new System.Windows.Forms.Label();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.animaisBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.cbRaca = new System.Windows.Forms.ComboBox();
            this.racasBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.racasBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.racasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.labelSexo = new System.Windows.Forms.Label();
            this.cbGenero = new System.Windows.Forms.ComboBox();
            this.generosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.labelProprietario = new System.Windows.Forms.Label();
            this.comboBoxProprietario = new System.Windows.Forms.ComboBox();
            this.proprietariosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.labelFazenda = new System.Windows.Forms.Label();
            this.cbFazenda = new System.Windows.Forms.ComboBox();
            this.fazendasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label2 = new System.Windows.Forms.Label();
            this.dtpDataNascimento = new System.Windows.Forms.DateTimePicker();
            this.animaisBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.tccEntitiesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.btnFazendas = new System.Windows.Forms.Button();
            this.btnProprietário = new System.Windows.Forms.Button();
            this.tbNome = new System.Windows.Forms.TextBox();
            this.btnBluetooth = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.animaisBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.racasBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.racasBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.racasBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.generosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.proprietariosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fazendasBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.animaisBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tccEntitiesBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // labelNome
            // 
            this.labelNome.AutoSize = true;
            this.labelNome.Location = new System.Drawing.Point(70, 43);
            this.labelNome.Name = "labelNome";
            this.labelNome.Size = new System.Drawing.Size(107, 16);
            this.labelNome.TabIndex = 0;
            this.labelNome.Text = "Nome (opcional)";
            this.labelNome.Click += new System.EventHandler(this.label1_Click);
            // 
            // btnSalvar
            // 
            this.btnSalvar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalvar.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnSalvar.Location = new System.Drawing.Point(603, 261);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(92, 58);
            this.btnSalvar.TabIndex = 1;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(70, 102);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 16);
            this.label1.TabIndex = 3;
            this.label1.Text = "Raça";
            // 
            // cbRaca
            // 
            this.cbRaca.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.racasBindingSource1, "Nome_Raca", true));
            this.cbRaca.DataSource = this.racasBindingSource2;
            this.cbRaca.DisplayMember = "Nome_Raca";
            this.cbRaca.FormattingEnabled = true;
            this.cbRaca.Location = new System.Drawing.Point(73, 121);
            this.cbRaca.Name = "cbRaca";
            this.cbRaca.Size = new System.Drawing.Size(169, 24);
            this.cbRaca.TabIndex = 4;
            this.cbRaca.ValueMember = "ID_Raca";
            this.cbRaca.SelectedIndexChanged += new System.EventHandler(this.cbRaca_SelectedIndexChanged);
            // 
            // racasBindingSource1
            // 
            this.racasBindingSource1.DataSource = typeof(TCC.Models.Racas);
            // 
            // racasBindingSource2
            // 
            this.racasBindingSource2.DataSource = typeof(TCC.Models.Racas);
            // 
            // racasBindingSource
            // 
            this.racasBindingSource.DataSource = typeof(TCC.Models.Racas);
            // 
            // labelSexo
            // 
            this.labelSexo.AutoSize = true;
            this.labelSexo.Location = new System.Drawing.Point(72, 170);
            this.labelSexo.Name = "labelSexo";
            this.labelSexo.Size = new System.Drawing.Size(38, 16);
            this.labelSexo.TabIndex = 5;
            this.labelSexo.Text = "Sexo";
            this.labelSexo.Click += new System.EventHandler(this.label2_Click);
            // 
            // cbGenero
            // 
            this.cbGenero.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.generosBindingSource, "ID_Genero", true));
            this.cbGenero.DataSource = this.generosBindingSource;
            this.cbGenero.DisplayMember = "Tipo_Genero";
            this.cbGenero.FormattingEnabled = true;
            this.cbGenero.Location = new System.Drawing.Point(75, 189);
            this.cbGenero.Name = "cbGenero";
            this.cbGenero.Size = new System.Drawing.Size(169, 24);
            this.cbGenero.TabIndex = 6;
            this.cbGenero.ValueMember = "ID_Genero";
            this.cbGenero.SelectedIndexChanged += new System.EventHandler(this.cbGenero_SelectedIndexChanged);
            // 
            // generosBindingSource
            // 
            this.generosBindingSource.DataSource = typeof(TCC.Models.Generos);
            // 
            // labelProprietario
            // 
            this.labelProprietario.AutoSize = true;
            this.labelProprietario.BackColor = System.Drawing.Color.Transparent;
            this.labelProprietario.Font = new System.Drawing.Font("Microsoft JhengHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelProprietario.Location = new System.Drawing.Point(369, 37);
            this.labelProprietario.Name = "labelProprietario";
            this.labelProprietario.Size = new System.Drawing.Size(130, 25);
            this.labelProprietario.TabIndex = 7;
            this.labelProprietario.Text = "Proprietário";
            this.labelProprietario.Click += new System.EventHandler(this.labelProprietario_Click);
            // 
            // comboBoxProprietario
            // 
            this.comboBoxProprietario.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.proprietariosBindingSource, "ID_Proprietario", true));
            this.comboBoxProprietario.DataSource = this.proprietariosBindingSource;
            this.comboBoxProprietario.DisplayMember = "Nome";
            this.comboBoxProprietario.DropDownHeight = 110;
            this.comboBoxProprietario.FormattingEnabled = true;
            this.comboBoxProprietario.IntegralHeight = false;
            this.comboBoxProprietario.Location = new System.Drawing.Point(360, 65);
            this.comboBoxProprietario.Name = "comboBoxProprietario";
            this.comboBoxProprietario.Size = new System.Drawing.Size(172, 24);
            this.comboBoxProprietario.TabIndex = 8;
            this.comboBoxProprietario.ValueMember = "ID_Proprietario";
            this.comboBoxProprietario.SelectedIndexChanged += new System.EventHandler(this.cbProprietario_SelectedIndexChanged);
            // 
            // proprietariosBindingSource
            // 
            this.proprietariosBindingSource.DataSource = typeof(TCC.Models.Proprietarios);
            // 
            // labelFazenda
            // 
            this.labelFazenda.AutoSize = true;
            this.labelFazenda.Location = new System.Drawing.Point(305, 129);
            this.labelFazenda.Name = "labelFazenda";
            this.labelFazenda.Size = new System.Drawing.Size(60, 16);
            this.labelFazenda.TabIndex = 9;
            this.labelFazenda.Text = "Fazenda";
            // 
            // cbFazenda
            // 
            this.cbFazenda.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.fazendasBindingSource, "ID_Fazenda", true));
            this.cbFazenda.DataSource = this.fazendasBindingSource;
            this.cbFazenda.DisplayMember = "Nome_Fazenda";
            this.cbFazenda.FormattingEnabled = true;
            this.cbFazenda.Location = new System.Drawing.Point(374, 123);
            this.cbFazenda.Name = "cbFazenda";
            this.cbFazenda.Size = new System.Drawing.Size(172, 24);
            this.cbFazenda.TabIndex = 10;
            this.cbFazenda.ValueMember = "ID_Fazenda";
            this.cbFazenda.SelectedIndexChanged += new System.EventHandler(this.cbFazenda_SelectedIndexChanged);
            // 
            // fazendasBindingSource
            // 
            this.fazendasBindingSource.DataSource = typeof(TCC.Models.Fazendas);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(305, 192);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 16);
            this.label2.TabIndex = 11;
            this.label2.Text = "Nascimento";
            // 
            // dtpDataNascimento
            // 
            this.dtpDataNascimento.Location = new System.Drawing.Point(400, 187);
            this.dtpDataNascimento.Name = "dtpDataNascimento";
            this.dtpDataNascimento.Size = new System.Drawing.Size(200, 22);
            this.dtpDataNascimento.TabIndex = 12;
            // 
            // animaisBindingSource1
            // 
            this.animaisBindingSource1.DataSource = typeof(TCC.Models.Animais);
            // 
            // tccEntitiesBindingSource
            // 
            this.tccEntitiesBindingSource.DataSource = typeof(TCC.Models.tccEntities);
            // 
            // btnFazendas
            // 
            this.btnFazendas.AccessibleRole = System.Windows.Forms.AccessibleRole.TitleBar;
            this.btnFazendas.AutoSize = true;
            this.btnFazendas.BackColor = System.Drawing.Color.Transparent;
            this.btnFazendas.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnFazendas.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnFazendas.FlatAppearance.BorderSize = 0;
            this.btnFazendas.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Ivory;
            this.btnFazendas.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnFazendas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFazendas.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnFazendas.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnFazendas.Location = new System.Drawing.Point(552, 123);
            this.btnFazendas.Name = "btnFazendas";
            this.btnFazendas.Size = new System.Drawing.Size(170, 30);
            this.btnFazendas.TabIndex = 13;
            this.btnFazendas.Text = "Adicionar nova Fazenda";
            this.btnFazendas.UseVisualStyleBackColor = false;
            this.btnFazendas.Click += new System.EventHandler(this.btnFazendas_Click);
            // 
            // btnProprietário
            // 
            this.btnProprietário.AccessibleRole = System.Windows.Forms.AccessibleRole.TitleBar;
            this.btnProprietário.AutoSize = true;
            this.btnProprietário.BackColor = System.Drawing.Color.Transparent;
            this.btnProprietário.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnProprietário.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnProprietário.FlatAppearance.BorderSize = 0;
            this.btnProprietário.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Ivory;
            this.btnProprietário.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnProprietário.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProprietário.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnProprietário.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnProprietário.Location = new System.Drawing.Point(552, 61);
            this.btnProprietário.Name = "btnProprietário";
            this.btnProprietário.Size = new System.Drawing.Size(179, 30);
            this.btnProprietário.TabIndex = 14;
            this.btnProprietário.Text = "Adicionar novo proprietário";
            this.btnProprietário.UseVisualStyleBackColor = false;
            this.btnProprietário.Click += new System.EventHandler(this.btnProprietário_Click);
            // 
            // tbNome
            // 
            this.tbNome.Location = new System.Drawing.Point(73, 62);
            this.tbNome.Name = "tbNome";
            this.tbNome.Size = new System.Drawing.Size(182, 22);
            this.tbNome.TabIndex = 15;
            this.tbNome.TextChanged += new System.EventHandler(this.tbNome_TextChanged);
            // 
            // btnBluetooth
            // 
            this.btnBluetooth.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBluetooth.ForeColor = System.Drawing.Color.Black;
            this.btnBluetooth.Location = new System.Drawing.Point(481, 261);
            this.btnBluetooth.Name = "btnBluetooth";
            this.btnBluetooth.Size = new System.Drawing.Size(99, 58);
            this.btnBluetooth.TabIndex = 16;
            this.btnBluetooth.Text = "Enviar ao dispositivo";
            this.btnBluetooth.UseVisualStyleBackColor = true;
            this.btnBluetooth.Click += new System.EventHandler(this.btnBluetooth_Click);
            // 
            // AdicionarAnimais
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkCyan;
            this.ClientSize = new System.Drawing.Size(771, 383);
            this.Controls.Add(this.btnBluetooth);
            this.Controls.Add(this.tbNome);
            this.Controls.Add(this.btnProprietário);
            this.Controls.Add(this.btnFazendas);
            this.Controls.Add(this.dtpDataNascimento);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cbFazenda);
            this.Controls.Add(this.labelFazenda);
            this.Controls.Add(this.comboBoxProprietario);
            this.Controls.Add(this.labelProprietario);
            this.Controls.Add(this.cbGenero);
            this.Controls.Add(this.labelSexo);
            this.Controls.Add(this.cbRaca);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.labelNome);
            this.Name = "AdicionarAnimais";
            this.Text = "AdicionarAnimais";
            ((System.ComponentModel.ISupportInitialize)(this.animaisBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.racasBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.racasBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.racasBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.generosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.proprietariosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fazendasBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.animaisBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tccEntitiesBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelNome;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.BindingSource animaisBindingSource;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbRaca;
        private System.Windows.Forms.Label labelSexo;
        private System.Windows.Forms.ComboBox cbGenero;
        private System.Windows.Forms.Label labelProprietario;
        private System.Windows.Forms.ComboBox comboBoxProprietario;
        private System.Windows.Forms.Label labelFazenda;
        private System.Windows.Forms.ComboBox cbFazenda;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dtpDataNascimento;
        private System.Windows.Forms.BindingSource racasBindingSource;
        private System.Windows.Forms.BindingSource animaisBindingSource1;
        private System.Windows.Forms.BindingSource racasBindingSource1;
        private System.Windows.Forms.BindingSource racasBindingSource2;
        private System.Windows.Forms.BindingSource tccEntitiesBindingSource;
        private System.Windows.Forms.BindingSource generosBindingSource;
        private System.Windows.Forms.Button btnFazendas;
        private System.Windows.Forms.Button btnProprietário;
        private System.Windows.Forms.BindingSource fazendasBindingSource;
        private System.Windows.Forms.BindingSource proprietariosBindingSource;
        private System.Windows.Forms.TextBox tbNome;
        private System.Windows.Forms.Button btnBluetooth;
    }
}