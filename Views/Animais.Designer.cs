using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;
using System;

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
            this.dgvAnimais = new System.Windows.Forms.DataGridView();
            this.cbFazendas = new System.Windows.Forms.ComboBox();
            this.btnAdicionarAnimal = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAnimais)).BeginInit();
            this.SuspendLayout();
            // 
            // btnConsultaAnimais
            // 
            this.btnConsultaAnimais.Location = new System.Drawing.Point(19, 73);
            this.btnConsultaAnimais.Margin = new System.Windows.Forms.Padding(2);
            this.btnConsultaAnimais.Name = "btnConsultaAnimais";
            this.btnConsultaAnimais.Size = new System.Drawing.Size(56, 19);
            this.btnConsultaAnimais.TabIndex = 0;
            this.btnConsultaAnimais.Text = "Consultar";
            this.btnConsultaAnimais.UseVisualStyleBackColor = true;
            this.btnConsultaAnimais.Click += new System.EventHandler(this.btnConsultaAnimais_Click);
            // 
            // dgvAnimais
            // 
            this.dgvAnimais.AllowUserToAddRows = false;
            this.dgvAnimais.AllowUserToDeleteRows = false;
            this.dgvAnimais.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAnimais.Location = new System.Drawing.Point(19, 124);
            this.dgvAnimais.Margin = new System.Windows.Forms.Padding(2);
            this.dgvAnimais.Name = "dgvAnimais";
            this.dgvAnimais.ReadOnly = true;
            this.dgvAnimais.RowHeadersWidth = 51;
            this.dgvAnimais.RowTemplate.Height = 24;
            this.dgvAnimais.Size = new System.Drawing.Size(515, 170);
            this.dgvAnimais.TabIndex = 1;
            // 
            // cbFazendas
            // 
            this.cbFazendas.FormattingEnabled = true;
            this.cbFazendas.Location = new System.Drawing.Point(223, 71);
            this.cbFazendas.Name = "cbFazendas";
            this.cbFazendas.Size = new System.Drawing.Size(121, 21);
            this.cbFazendas.TabIndex = 2;
            // 
            // btnAdicionarAnimal
            // 
            this.btnAdicionarAnimal.Location = new System.Drawing.Point(459, 25);
            this.btnAdicionarAnimal.Name = "btnAdicionarAnimal";
            this.btnAdicionarAnimal.Size = new System.Drawing.Size(75, 23);
            this.btnAdicionarAnimal.TabIndex = 3;
            this.btnAdicionarAnimal.Text = "Adicionar Animal";
            this.btnAdicionarAnimal.UseVisualStyleBackColor = true;
            this.btnAdicionarAnimal.Click += new System.EventHandler(this.btnAdicionarAnimal_Click);
            // 
            // Animais
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(586, 335);
            this.Controls.Add(this.btnAdicionarAnimal);
            this.Controls.Add(this.cbFazendas);
            this.Controls.Add(this.dgvAnimais);
            this.Controls.Add(this.btnConsultaAnimais);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Animais";
            this.Text = "Animais";
            this.Load += new System.EventHandler(this.Animais_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAnimais)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnConsultaAnimais;
        private System.Windows.Forms.ComboBox cbFazendas;
        private System.Windows.Forms.DataGridView dgvAnimais;

        private void Animais_Load(object sender, System.EventArgs e)
        {

            
             try
            {
                using (SqlConnection conexao = DatabaseConnection.GetConnection())
                {
                    
                        string strSQL = "SELECT ID_Fazenda, Nome_Fazenda FROM Fazendas";
                    SqlCommand comando = new SqlCommand(strSQL, conexao);
                    SqlDataAdapter adapter = new SqlDataAdapter(comando);
                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);

                    cbFazendas.DataSource = dataTable;
                    cbFazendas.DisplayMember = "Nome_Fazenda";
                    cbFazendas.ValueMember = "ID_Fazenda";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao carregar fazendas: " + ex.Message);
            }
        }

        private Button btnAdicionarAnimal;
    }
}