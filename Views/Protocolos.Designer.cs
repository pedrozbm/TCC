namespace TCC.Views
{
    partial class Protocolos
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btnDeletar = new System.Windows.Forms.Button();
            this.cbIDAnimal = new System.Windows.Forms.ComboBox();
            this.animaisBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label2 = new System.Windows.Forms.Label();
            this.labelAdicionar = new System.Windows.Forms.Label();
            this.btnAdicionar = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnConsultarIseminacoes = new System.Windows.Forms.Button();
            this.dtpInseminacao = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.tbInseminacao = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cbSemen = new System.Windows.Forms.ComboBox();
            this.semensBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.btnAddBT = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.animaisBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.semensBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // btnDeletar
            // 
            this.btnDeletar.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnDeletar.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnDeletar.Location = new System.Drawing.Point(678, 365);
            this.btnDeletar.Name = "btnDeletar";
            this.btnDeletar.Size = new System.Drawing.Size(84, 36);
            this.btnDeletar.TabIndex = 30;
            this.btnDeletar.Text = "Deletar";
            this.btnDeletar.UseVisualStyleBackColor = false;
            // 
            // cbIDAnimal
            // 
            this.cbIDAnimal.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.animaisBindingSource, "ID_Animal", true));
            this.cbIDAnimal.DataSource = this.animaisBindingSource;
            this.cbIDAnimal.DisplayMember = "ID_Animal";
            this.cbIDAnimal.FormattingEnabled = true;
            this.cbIDAnimal.Location = new System.Drawing.Point(98, 70);
            this.cbIDAnimal.Name = "cbIDAnimal";
            this.cbIDAnimal.Size = new System.Drawing.Size(90, 24);
            this.cbIDAnimal.TabIndex = 28;
            this.cbIDAnimal.ValueMember = "ID_Animal";
            this.cbIDAnimal.SelectedIndexChanged += new System.EventHandler(this.cbIDAnimal_SelectedIndexChanged);
            // 
            // animaisBindingSource
            // 
            this.animaisBindingSource.DataSource = typeof(TCC.Models.Animais);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(31, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 16);
            this.label2.TabIndex = 23;
            this.label2.Text = "IDAnimal";
            // 
            // labelAdicionar
            // 
            this.labelAdicionar.AutoSize = true;
            this.labelAdicionar.Font = new System.Drawing.Font("Microsoft JhengHei UI", 12F, System.Drawing.FontStyle.Bold);
            this.labelAdicionar.ForeColor = System.Drawing.SystemColors.ControlText;
            this.labelAdicionar.Location = new System.Drawing.Point(29, 19);
            this.labelAdicionar.Name = "labelAdicionar";
            this.labelAdicionar.Size = new System.Drawing.Size(280, 25);
            this.labelAdicionar.TabIndex = 21;
            this.labelAdicionar.Text = "Adiconar nova Inseminação";
            // 
            // btnAdicionar
            // 
            this.btnAdicionar.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnAdicionar.Location = new System.Drawing.Point(678, 115);
            this.btnAdicionar.Name = "btnAdicionar";
            this.btnAdicionar.Size = new System.Drawing.Size(96, 30);
            this.btnAdicionar.TabIndex = 20;
            this.btnAdicionar.Text = "Adicionar";
            this.btnAdicionar.UseVisualStyleBackColor = true;
            this.btnAdicionar.Click += new System.EventHandler(this.btnAdicionar_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView1.Location = new System.Drawing.Point(46, 151);
            this.dataGridView1.Name = "dataGridView1";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridView1.RowHeadersWidth = 51;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black;
            this.dataGridView1.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(728, 208);
            this.dataGridView1.TabIndex = 19;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // btnConsultarIseminacoes
            // 
            this.btnConsultarIseminacoes.BackColor = System.Drawing.Color.Cornsilk;
            this.btnConsultarIseminacoes.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnConsultarIseminacoes.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnConsultarIseminacoes.Location = new System.Drawing.Point(574, 365);
            this.btnConsultarIseminacoes.Name = "btnConsultarIseminacoes";
            this.btnConsultarIseminacoes.Size = new System.Drawing.Size(84, 36);
            this.btnConsultarIseminacoes.TabIndex = 18;
            this.btnConsultarIseminacoes.Text = "Consultar";
            this.btnConsultarIseminacoes.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnConsultarIseminacoes.UseVisualStyleBackColor = false;
            this.btnConsultarIseminacoes.Click += new System.EventHandler(this.btnConsultarInseminacoes_Click);
            // 
            // dtpInseminacao
            // 
            this.dtpInseminacao.Location = new System.Drawing.Point(537, 68);
            this.dtpInseminacao.Name = "dtpInseminacao";
            this.dtpInseminacao.Size = new System.Drawing.Size(200, 22);
            this.dtpInseminacao.TabIndex = 31;
            this.dtpInseminacao.ValueChanged += new System.EventHandler(this.dtpInseminacao_ValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(482, 73);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 16);
            this.label1.TabIndex = 32;
            this.label1.Text = "Data";
            // 
            // tbInseminacao
            // 
            this.tbInseminacao.Location = new System.Drawing.Point(144, 115);
            this.tbInseminacao.Name = "tbInseminacao";
            this.tbInseminacao.Size = new System.Drawing.Size(100, 22);
            this.tbInseminacao.TabIndex = 33;
            this.tbInseminacao.TextChanged += new System.EventHandler(this.tbInseminacao_TextChanged);
            this.tbInseminacao.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tbInseminacao_KeyDown);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(31, 121);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(107, 16);
            this.label3.TabIndex = 34;
            this.label3.Text = "Nome do Animal";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(266, 118);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(77, 16);
            this.label4.TabIndex = 35;
            this.label4.Text = "Proprietario";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(349, 115);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 22);
            this.textBox1.TabIndex = 36;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(206, 74);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(75, 16);
            this.label5.TabIndex = 37;
            this.label5.Text = "Reprodutor";
            // 
            // cbSemen
            // 
            this.cbSemen.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.semensBindingSource, "ID_Semen", true));
            this.cbSemen.DataSource = this.semensBindingSource;
            this.cbSemen.DisplayMember = "Nome";
            this.cbSemen.FormattingEnabled = true;
            this.cbSemen.Location = new System.Drawing.Point(287, 70);
            this.cbSemen.Name = "cbSemen";
            this.cbSemen.Size = new System.Drawing.Size(121, 24);
            this.cbSemen.TabIndex = 38;
            this.cbSemen.ValueMember = "ID_Semen";
            // 
            // semensBindingSource
            // 
            this.semensBindingSource.DataSource = typeof(TCC.Models.Semens);
            // 
            // btnAddBT
            // 
            this.btnAddBT.Location = new System.Drawing.Point(526, 117);
            this.btnAddBT.Name = "btnAddBT";
            this.btnAddBT.Size = new System.Drawing.Size(132, 27);
            this.btnAddBT.TabIndex = 39;
            this.btnAddBT.Text = "Adiconar com Tag";
            this.btnAddBT.UseVisualStyleBackColor = true;
            this.btnAddBT.Click += new System.EventHandler(this.btnAddBT_Click);
            // 
            // Protocolos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkCyan;
            this.ClientSize = new System.Drawing.Size(800, 427);
            this.Controls.Add(this.btnAddBT);
            this.Controls.Add(this.cbSemen);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tbInseminacao);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dtpInseminacao);
            this.Controls.Add(this.btnDeletar);
            this.Controls.Add(this.cbIDAnimal);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.labelAdicionar);
            this.Controls.Add(this.btnAdicionar);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnConsultarIseminacoes);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Protocolos";
            this.Text = "Protocolos";
            this.Load += new System.EventHandler(this.Protocolos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.animaisBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.semensBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnDeletar;
        private System.Windows.Forms.ComboBox cbIDAnimal;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label labelAdicionar;
        private System.Windows.Forms.Button btnAdicionar;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnConsultarIseminacoes;
        private System.Windows.Forms.BindingSource animaisBindingSource;
        private System.Windows.Forms.DateTimePicker dtpInseminacao;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbInseminacao;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cbSemen;
        private System.Windows.Forms.BindingSource semensBindingSource;
        private System.Windows.Forms.Button btnAddBT;
    }
}