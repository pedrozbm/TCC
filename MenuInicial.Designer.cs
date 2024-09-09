namespace TCC
{
    partial class MenuInicial
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MenuInicial));
            this.btnAnimais = new System.Windows.Forms.Button();
            this.menuVertical = new System.Windows.Forms.Panel();
            this.btnConfiguracoes = new System.Windows.Forms.Button();
            this.btnSêmens = new System.Windows.Forms.Button();
            this.btnProtocolos = new System.Windows.Forms.Button();
            this.menuSuperior = new System.Windows.Forms.Panel();
            this.btnSlide = new System.Windows.Forms.PictureBox();
            this.panelContanedor = new System.Windows.Forms.Panel();
            this.btnFazendas = new System.Windows.Forms.Button();
            this.menuVertical.SuspendLayout();
            this.menuSuperior.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnSlide)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAnimais
            // 
            this.btnAnimais.AccessibleRole = System.Windows.Forms.AccessibleRole.TitleBar;
            resources.ApplyResources(this.btnAnimais, "btnAnimais");
            this.btnAnimais.BackColor = System.Drawing.Color.Transparent;
            this.btnAnimais.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAnimais.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnAnimais.FlatAppearance.BorderSize = 0;
            this.btnAnimais.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Ivory;
            this.btnAnimais.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnAnimais.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnAnimais.Name = "btnAnimais";
            this.btnAnimais.UseVisualStyleBackColor = false;
            this.btnAnimais.Click += new System.EventHandler(this.btnAnimais_Click);
            this.btnAnimais.MouseEnter += new System.EventHandler(this.MenuInicial_Load);
            // 
            // menuVertical
            // 
            this.menuVertical.BackColor = System.Drawing.Color.Green;
            this.menuVertical.Controls.Add(this.btnConfiguracoes);
            this.menuVertical.Controls.Add(this.btnSêmens);
            this.menuVertical.Controls.Add(this.btnProtocolos);
            this.menuVertical.Controls.Add(this.btnFazendas);
            this.menuVertical.Controls.Add(this.btnAnimais);
            resources.ApplyResources(this.menuVertical, "menuVertical");
            this.menuVertical.Name = "menuVertical";
            this.menuVertical.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // btnConfiguracoes
            // 
            this.btnConfiguracoes.AccessibleRole = System.Windows.Forms.AccessibleRole.TitleBar;
            resources.ApplyResources(this.btnConfiguracoes, "btnConfiguracoes");
            this.btnConfiguracoes.BackColor = System.Drawing.Color.Transparent;
            this.btnConfiguracoes.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnConfiguracoes.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnConfiguracoes.FlatAppearance.BorderSize = 0;
            this.btnConfiguracoes.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Ivory;
            this.btnConfiguracoes.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnConfiguracoes.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnConfiguracoes.Name = "btnConfiguracoes";
            this.btnConfiguracoes.UseVisualStyleBackColor = false;
            this.btnConfiguracoes.Click += new System.EventHandler(this.button4_Click);
            // 
            // btnSêmens
            // 
            this.btnSêmens.AccessibleRole = System.Windows.Forms.AccessibleRole.TitleBar;
            resources.ApplyResources(this.btnSêmens, "btnSêmens");
            this.btnSêmens.BackColor = System.Drawing.Color.Transparent;
            this.btnSêmens.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSêmens.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnSêmens.FlatAppearance.BorderSize = 0;
            this.btnSêmens.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Ivory;
            this.btnSêmens.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnSêmens.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnSêmens.Name = "btnSêmens";
            this.btnSêmens.UseVisualStyleBackColor = false;
            this.btnSêmens.Click += new System.EventHandler(this.btnSêmens_Click);
            // 
            // btnProtocolos
            // 
            this.btnProtocolos.AccessibleRole = System.Windows.Forms.AccessibleRole.TitleBar;
            resources.ApplyResources(this.btnProtocolos, "btnProtocolos");
            this.btnProtocolos.BackColor = System.Drawing.Color.Transparent;
            this.btnProtocolos.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnProtocolos.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnProtocolos.FlatAppearance.BorderSize = 0;
            this.btnProtocolos.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Ivory;
            this.btnProtocolos.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnProtocolos.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnProtocolos.Name = "btnProtocolos";
            this.btnProtocolos.UseVisualStyleBackColor = false;
            // 
            // menuSuperior
            // 
            this.menuSuperior.BackColor = System.Drawing.Color.LightYellow;
            this.menuSuperior.Controls.Add(this.btnSlide);
            resources.ApplyResources(this.menuSuperior, "menuSuperior");
            this.menuSuperior.Name = "menuSuperior";
            this.menuSuperior.Paint += new System.Windows.Forms.PaintEventHandler(this.menuSuperior_Paint);
            // 
            // btnSlide
            // 
            resources.ApplyResources(this.btnSlide, "btnSlide");
            this.btnSlide.Name = "btnSlide";
            this.btnSlide.TabStop = false;
            // 
            // panelContanedor
            // 
            resources.ApplyResources(this.panelContanedor, "panelContanedor");
            this.panelContanedor.Name = "panelContanedor";
            this.panelContanedor.Paint += new System.Windows.Forms.PaintEventHandler(this.panelContanedor_Paint);
            // 
            // btnFazendas
            // 
            this.btnFazendas.AccessibleRole = System.Windows.Forms.AccessibleRole.TitleBar;
            resources.ApplyResources(this.btnFazendas, "btnFazendas");
            this.btnFazendas.BackColor = System.Drawing.Color.Transparent;
            this.btnFazendas.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnFazendas.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnFazendas.FlatAppearance.BorderSize = 0;
            this.btnFazendas.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Ivory;
            this.btnFazendas.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnFazendas.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnFazendas.Name = "btnFazendas";
            this.btnFazendas.UseVisualStyleBackColor = false;
            this.btnFazendas.Click += new System.EventHandler(this.btnFazendas_Click);
            // 
            // MenuInicial
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightYellow;
            this.Controls.Add(this.panelContanedor);
            this.Controls.Add(this.menuSuperior);
            this.Controls.Add(this.menuVertical);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MenuInicial";
            this.Load += new System.EventHandler(this.MenuInicial_Load);
            this.menuVertical.ResumeLayout(false);
            this.menuVertical.PerformLayout();
            this.menuSuperior.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btnSlide)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnAnimais;
        private System.Windows.Forms.Panel menuVertical;
        private System.Windows.Forms.Panel menuSuperior;
        private System.Windows.Forms.PictureBox btnSlide;
        private System.Windows.Forms.Button btnConfiguracoes;
        private System.Windows.Forms.Button btnSêmens;
        private System.Windows.Forms.Button btnProtocolos;
        private System.Windows.Forms.Panel panelContanedor;
        private System.Windows.Forms.Button btnFazendas;
    }
}