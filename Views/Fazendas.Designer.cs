namespace TCC
{
    partial class Fazendas
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
            this.fazendasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cidadesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.estadosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.proprietariosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.btnConsultarAnimais = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnAdicionar = new System.Windows.Forms.Button();
            this.labelAdicionar = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txbNome = new System.Windows.Forms.TextBox();
            this.txbEndereco = new System.Windows.Forms.TextBox();
            this.cbCidade = new System.Windows.Forms.ComboBox();
            this.cbEstado = new System.Windows.Forms.ComboBox();
            this.btnDeletar = new System.Windows.Forms.Button();
            this.labelProprietario = new System.Windows.Forms.Label();
            this.comboBoxProprietario = new System.Windows.Forms.ComboBox();
            this.nomeFazendaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ID_Fazenda = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.enderecoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cidadesDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.estadosDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.proprietariosDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.fazendasBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cidadesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.estadosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.proprietariosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // fazendasBindingSource
            // 
            this.fazendasBindingSource.DataSource = typeof(TCC.Models.Fazendas);
            // 
            // cidadesBindingSource
            // 
            this.cidadesBindingSource.DataSource = typeof(TCC.Models.Cidades);
            // 
            // estadosBindingSource
            // 
            this.estadosBindingSource.DataSource = typeof(TCC.Models.Estados);
            // 
            // proprietariosBindingSource
            // 
            this.proprietariosBindingSource.DataSource = typeof(TCC.Models.Proprietarios);
            // 
            // btnConsultarAnimais
            // 
            this.btnConsultarAnimais.Location = new System.Drawing.Point(564, 350);
            this.btnConsultarAnimais.Name = "btnConsultarAnimais";
            this.btnConsultarAnimais.Size = new System.Drawing.Size(84, 36);
            this.btnConsultarAnimais.TabIndex = 0;
            this.btnConsultarAnimais.Text = "Consultar";
            this.btnConsultarAnimais.UseVisualStyleBackColor = true;
            this.btnConsultarAnimais.Click += new System.EventHandler(this.button1_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nomeFazendaDataGridViewTextBoxColumn,
            this.ID_Fazenda,
            this.enderecoDataGridViewTextBoxColumn,
            this.cidadesDataGridViewTextBoxColumn,
            this.estadosDataGridViewTextBoxColumn,
            this.proprietariosDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.fazendasBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(29, 123);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(728, 208);
            this.dataGridView1.TabIndex = 1;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // btnAdicionar
            // 
            this.btnAdicionar.Location = new System.Drawing.Point(661, 77);
            this.btnAdicionar.Name = "btnAdicionar";
            this.btnAdicionar.Size = new System.Drawing.Size(96, 30);
            this.btnAdicionar.TabIndex = 2;
            this.btnAdicionar.Text = "Adicionar";
            this.btnAdicionar.UseVisualStyleBackColor = true;
            this.btnAdicionar.Click += new System.EventHandler(this.btnAdicionar_Click);
            // 
            // labelAdicionar
            // 
            this.labelAdicionar.AutoSize = true;
            this.labelAdicionar.Font = new System.Drawing.Font("Microsoft JhengHei UI", 12F, System.Drawing.FontStyle.Bold);
            this.labelAdicionar.ForeColor = System.Drawing.SystemColors.ControlText;
            this.labelAdicionar.Location = new System.Drawing.Point(12, 9);
            this.labelAdicionar.Name = "labelAdicionar";
            this.labelAdicionar.Size = new System.Drawing.Size(238, 25);
            this.labelAdicionar.TabIndex = 3;
            this.labelAdicionar.Text = "Adiconar nova Fazenda";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 87);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 16);
            this.label1.TabIndex = 4;
            this.label1.Text = "Endereço";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 16);
            this.label2.TabIndex = 5;
            this.label2.Text = "Nome";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(269, 45);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 16);
            this.label3.TabIndex = 6;
            this.label3.Text = "Cidade";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(459, 45);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(50, 16);
            this.label4.TabIndex = 7;
            this.label4.Text = "Estado";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // txbNome
            // 
            this.txbNome.Location = new System.Drawing.Point(64, 42);
            this.txbNome.Name = "txbNome";
            this.txbNome.Size = new System.Drawing.Size(199, 22);
            this.txbNome.TabIndex = 8;
            this.txbNome.TextChanged += new System.EventHandler(this.txbNome_TextChanged);
            // 
            // txbEndereco
            // 
            this.txbEndereco.Location = new System.Drawing.Point(92, 81);
            this.txbEndereco.Name = "txbEndereco";
            this.txbEndereco.Size = new System.Drawing.Size(262, 22);
            this.txbEndereco.TabIndex = 10;
            this.txbEndereco.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // cbCidade
            // 
            this.cbCidade.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.cidadesBindingSource, "ID_Cidade", true));
            this.cbCidade.DataSource = this.cidadesBindingSource;
            this.cbCidade.DisplayMember = "Nome_Cidade";
            this.cbCidade.FormattingEnabled = true;
            this.cbCidade.Location = new System.Drawing.Point(326, 40);
            this.cbCidade.Name = "cbCidade";
            this.cbCidade.Size = new System.Drawing.Size(127, 24);
            this.cbCidade.TabIndex = 12;
            this.cbCidade.ValueMember = "ID_Cidade";
            this.cbCidade.SelectedIndexChanged += new System.EventHandler(this.cbCidade_SelectedIndexChanged);
            // 
            // cbEstado
            // 
            this.cbEstado.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.estadosBindingSource, "Nome_Estado", true));
            this.cbEstado.DataSource = this.estadosBindingSource;
            this.cbEstado.DisplayMember = "Nome_Estado";
            this.cbEstado.FormattingEnabled = true;
            this.cbEstado.Location = new System.Drawing.Point(515, 42);
            this.cbEstado.Name = "cbEstado";
            this.cbEstado.Size = new System.Drawing.Size(58, 24);
            this.cbEstado.TabIndex = 13;
            this.cbEstado.ValueMember = "ID_Estado";
            this.cbEstado.SelectedIndexChanged += new System.EventHandler(this.cbEstado_SelectedIndexChanged);
            // 
            // btnDeletar
            // 
            this.btnDeletar.Location = new System.Drawing.Point(673, 350);
            this.btnDeletar.Name = "btnDeletar";
            this.btnDeletar.Size = new System.Drawing.Size(84, 36);
            this.btnDeletar.TabIndex = 14;
            this.btnDeletar.Text = "Deletar";
            this.btnDeletar.UseVisualStyleBackColor = true;
            this.btnDeletar.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // labelProprietario
            // 
            this.labelProprietario.AutoSize = true;
            this.labelProprietario.Location = new System.Drawing.Point(360, 84);
            this.labelProprietario.Name = "labelProprietario";
            this.labelProprietario.Size = new System.Drawing.Size(77, 16);
            this.labelProprietario.TabIndex = 16;
            this.labelProprietario.Text = "Proprietario";
            // 
            // comboBoxProprietario
            // 
            this.comboBoxProprietario.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.proprietariosBindingSource, "ID_Proprietario", true));
            this.comboBoxProprietario.DataSource = this.proprietariosBindingSource;
            this.comboBoxProprietario.DisplayMember = "Nome";
            this.comboBoxProprietario.FormattingEnabled = true;
            this.comboBoxProprietario.Location = new System.Drawing.Point(443, 79);
            this.comboBoxProprietario.Name = "comboBoxProprietario";
            this.comboBoxProprietario.Size = new System.Drawing.Size(179, 24);
            this.comboBoxProprietario.TabIndex = 17;
            this.comboBoxProprietario.ValueMember = "ID_Proprietario";
            this.comboBoxProprietario.SelectedIndexChanged += new System.EventHandler(this.comboBoxProprietario_SelectedIndexChanged);
            // 
            // nomeFazendaDataGridViewTextBoxColumn
            // 
            this.nomeFazendaDataGridViewTextBoxColumn.DataPropertyName = "Nome_Fazenda";
            this.nomeFazendaDataGridViewTextBoxColumn.HeaderText = "Nome_Fazenda";
            this.nomeFazendaDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.nomeFazendaDataGridViewTextBoxColumn.Name = "nomeFazendaDataGridViewTextBoxColumn";
            this.nomeFazendaDataGridViewTextBoxColumn.Width = 125;
            // 
            // ID_Fazenda
            // 
            this.ID_Fazenda.DataPropertyName = "ID_Fazenda";
            this.ID_Fazenda.HeaderText = "ID_Fazenda";
            this.ID_Fazenda.MinimumWidth = 6;
            this.ID_Fazenda.Name = "ID_Fazenda";
            this.ID_Fazenda.Width = 125;
            // 
            // enderecoDataGridViewTextBoxColumn
            // 
            this.enderecoDataGridViewTextBoxColumn.DataPropertyName = "Endereco";
            this.enderecoDataGridViewTextBoxColumn.HeaderText = "Endereco";
            this.enderecoDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.enderecoDataGridViewTextBoxColumn.Name = "enderecoDataGridViewTextBoxColumn";
            this.enderecoDataGridViewTextBoxColumn.Width = 125;
            // 
            // cidadesDataGridViewTextBoxColumn
            // 
            this.cidadesDataGridViewTextBoxColumn.DataPropertyName = "Cidades";
            this.cidadesDataGridViewTextBoxColumn.HeaderText = "Cidades";
            this.cidadesDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.cidadesDataGridViewTextBoxColumn.Name = "cidadesDataGridViewTextBoxColumn";
            this.cidadesDataGridViewTextBoxColumn.Width = 125;
            // 
            // estadosDataGridViewTextBoxColumn
            // 
            this.estadosDataGridViewTextBoxColumn.DataPropertyName = "Estados";
            this.estadosDataGridViewTextBoxColumn.HeaderText = "Estados";
            this.estadosDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.estadosDataGridViewTextBoxColumn.Name = "estadosDataGridViewTextBoxColumn";
            this.estadosDataGridViewTextBoxColumn.Width = 125;
            // 
            // proprietariosDataGridViewTextBoxColumn
            // 
            this.proprietariosDataGridViewTextBoxColumn.DataPropertyName = "Proprietarios";
            this.proprietariosDataGridViewTextBoxColumn.HeaderText = "Proprietarios";
            this.proprietariosDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.proprietariosDataGridViewTextBoxColumn.Name = "proprietariosDataGridViewTextBoxColumn";
            this.proprietariosDataGridViewTextBoxColumn.Width = 125;
            // 
            // Fazendas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkCyan;
            this.ClientSize = new System.Drawing.Size(782, 412);
            this.Controls.Add(this.comboBoxProprietario);
            this.Controls.Add(this.labelProprietario);
            this.Controls.Add(this.btnDeletar);
            this.Controls.Add(this.cbEstado);
            this.Controls.Add(this.cbCidade);
            this.Controls.Add(this.txbEndereco);
            this.Controls.Add(this.txbNome);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.labelAdicionar);
            this.Controls.Add(this.btnAdicionar);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnConsultarAnimais);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Fazendas";
            this.Text = "Fazendas";
            this.Load += new System.EventHandler(this.Fazendas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.fazendasBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cidadesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.estadosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.proprietariosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.BindingSource cidadesBindingSource;
        private System.Windows.Forms.BindingSource estadosBindingSource;
        private System.Windows.Forms.BindingSource fazendasBindingSource;
        private System.Windows.Forms.BindingSource proprietariosBindingSource;
        private System.Windows.Forms.Button btnConsultarAnimais;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnAdicionar;
        private System.Windows.Forms.Label labelAdicionar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txbNome;
        private System.Windows.Forms.TextBox txbEndereco;
        private System.Windows.Forms.ComboBox cbCidade;
        private System.Windows.Forms.ComboBox cbEstado;
        private System.Windows.Forms.Button btnDeletar;
        private System.Windows.Forms.Label labelProprietario;
        private System.Windows.Forms.ComboBox comboBoxProprietario;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomeFazendaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID_Fazenda;
        private System.Windows.Forms.DataGridViewTextBoxColumn enderecoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cidadesDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn estadosDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn proprietariosDataGridViewTextBoxColumn;
    }
}