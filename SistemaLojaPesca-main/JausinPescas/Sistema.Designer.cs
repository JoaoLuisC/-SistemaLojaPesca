namespace JausinPescas
{
    partial class Sistema
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Sistema));
            this.panelMenu = new System.Windows.Forms.Panel();
            this.btnRemover = new FontAwesome.Sharp.IconButton();
            this.btnAlterar = new FontAwesome.Sharp.IconButton();
            this.btnBusca = new FontAwesome.Sharp.IconButton();
            this.btnCadastro = new FontAwesome.Sharp.IconButton();
            this.panelLogo = new System.Windows.Forms.Panel();
            this.btnHome = new System.Windows.Forms.PictureBox();
            this.panelTitleBar = new System.Windows.Forms.Panel();
            this.lblmsgerro = new System.Windows.Forms.Label();
            this.iconMin = new FontAwesome.Sharp.IconButton();
            this.iconExit = new FontAwesome.Sharp.IconButton();
            this.lblTitleBar = new System.Windows.Forms.Label();
            this.iconCurrent = new FontAwesome.Sharp.IconPictureBox();
            this.panelSombra = new System.Windows.Forms.Panel();
            this.panelDesktop = new System.Windows.Forms.Panel();
            this.lblNomes = new System.Windows.Forms.Label();
            this.lblDesenvolvimento = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panelMenu.SuspendLayout();
            this.panelLogo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnHome)).BeginInit();
            this.panelTitleBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconCurrent)).BeginInit();
            this.panelDesktop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panelMenu
            // 
            this.panelMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(0)))), ((int)(((byte)(36)))));
            this.panelMenu.Controls.Add(this.btnRemover);
            this.panelMenu.Controls.Add(this.btnAlterar);
            this.panelMenu.Controls.Add(this.btnBusca);
            this.panelMenu.Controls.Add(this.btnCadastro);
            this.panelMenu.Controls.Add(this.panelLogo);
            this.panelMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMenu.Location = new System.Drawing.Point(0, 0);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(220, 833);
            this.panelMenu.TabIndex = 0;
            // 
            // btnRemover
            // 
            this.btnRemover.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnRemover.FlatAppearance.BorderSize = 0;
            this.btnRemover.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRemover.IconChar = FontAwesome.Sharp.IconChar.TrashAlt;
            this.btnRemover.IconColor = System.Drawing.Color.Gainsboro;
            this.btnRemover.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnRemover.IconSize = 32;
            this.btnRemover.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRemover.Location = new System.Drawing.Point(0, 320);
            this.btnRemover.Name = "btnRemover";
            this.btnRemover.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.btnRemover.Size = new System.Drawing.Size(220, 60);
            this.btnRemover.TabIndex = 4;
            this.btnRemover.Text = "Remover";
            this.btnRemover.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRemover.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnRemover.UseVisualStyleBackColor = true;
            this.btnRemover.Click += new System.EventHandler(this.btnRemover_Click);
            // 
            // btnAlterar
            // 
            this.btnAlterar.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnAlterar.FlatAppearance.BorderSize = 0;
            this.btnAlterar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAlterar.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnAlterar.IconChar = FontAwesome.Sharp.IconChar.FileAlt;
            this.btnAlterar.IconColor = System.Drawing.Color.Gainsboro;
            this.btnAlterar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnAlterar.IconSize = 32;
            this.btnAlterar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAlterar.Location = new System.Drawing.Point(0, 260);
            this.btnAlterar.Name = "btnAlterar";
            this.btnAlterar.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.btnAlterar.Size = new System.Drawing.Size(220, 60);
            this.btnAlterar.TabIndex = 3;
            this.btnAlterar.Text = "Alterar";
            this.btnAlterar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAlterar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAlterar.UseVisualStyleBackColor = true;
            this.btnAlterar.Click += new System.EventHandler(this.btnAltera_Click);
            // 
            // btnBusca
            // 
            this.btnBusca.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnBusca.FlatAppearance.BorderSize = 0;
            this.btnBusca.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBusca.IconChar = FontAwesome.Sharp.IconChar.Search;
            this.btnBusca.IconColor = System.Drawing.Color.Gainsboro;
            this.btnBusca.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnBusca.IconSize = 32;
            this.btnBusca.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBusca.Location = new System.Drawing.Point(0, 200);
            this.btnBusca.Name = "btnBusca";
            this.btnBusca.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.btnBusca.Size = new System.Drawing.Size(220, 60);
            this.btnBusca.TabIndex = 2;
            this.btnBusca.Text = "Listar";
            this.btnBusca.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBusca.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnBusca.UseVisualStyleBackColor = true;
            this.btnBusca.Click += new System.EventHandler(this.btnBusca_Click);
            // 
            // btnCadastro
            // 
            this.btnCadastro.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnCadastro.FlatAppearance.BorderSize = 0;
            this.btnCadastro.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCadastro.IconChar = FontAwesome.Sharp.IconChar.Plus;
            this.btnCadastro.IconColor = System.Drawing.Color.Gainsboro;
            this.btnCadastro.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnCadastro.IconSize = 32;
            this.btnCadastro.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCadastro.Location = new System.Drawing.Point(0, 140);
            this.btnCadastro.Name = "btnCadastro";
            this.btnCadastro.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.btnCadastro.Size = new System.Drawing.Size(220, 60);
            this.btnCadastro.TabIndex = 1;
            this.btnCadastro.Text = "Cadastro";
            this.btnCadastro.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCadastro.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCadastro.UseVisualStyleBackColor = true;
            this.btnCadastro.Click += new System.EventHandler(this.btnCadastro_Click);
            // 
            // panelLogo
            // 
            this.panelLogo.Controls.Add(this.btnHome);
            this.panelLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelLogo.Location = new System.Drawing.Point(0, 0);
            this.panelLogo.Name = "panelLogo";
            this.panelLogo.Size = new System.Drawing.Size(220, 140);
            this.panelLogo.TabIndex = 0;
            // 
            // btnHome
            // 
            this.btnHome.Image = ((System.Drawing.Image)(resources.GetObject("btnHome.Image")));
            this.btnHome.Location = new System.Drawing.Point(12, 3);
            this.btnHome.Name = "btnHome";
            this.btnHome.Size = new System.Drawing.Size(201, 134);
            this.btnHome.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnHome.TabIndex = 0;
            this.btnHome.TabStop = false;
            this.btnHome.Click += new System.EventHandler(this.btnHome_Click_1);
            // 
            // panelTitleBar
            // 
            this.panelTitleBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(0)))), ((int)(((byte)(36)))));
            this.panelTitleBar.Controls.Add(this.lblmsgerro);
            this.panelTitleBar.Controls.Add(this.iconMin);
            this.panelTitleBar.Controls.Add(this.iconExit);
            this.panelTitleBar.Controls.Add(this.lblTitleBar);
            this.panelTitleBar.Controls.Add(this.iconCurrent);
            this.panelTitleBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTitleBar.Location = new System.Drawing.Point(220, 0);
            this.panelTitleBar.Name = "panelTitleBar";
            this.panelTitleBar.Size = new System.Drawing.Size(962, 75);
            this.panelTitleBar.TabIndex = 1;
            this.panelTitleBar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelTitleBar_MouseDown);
            // 
            // lblmsgerro
            // 
            this.lblmsgerro.AutoSize = true;
            this.lblmsgerro.ForeColor = System.Drawing.Color.Red;
            this.lblmsgerro.Location = new System.Drawing.Point(439, 38);
            this.lblmsgerro.Name = "lblmsgerro";
            this.lblmsgerro.Size = new System.Drawing.Size(0, 20);
            this.lblmsgerro.TabIndex = 5;
            // 
            // iconMin
            // 
            this.iconMin.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.iconMin.FlatAppearance.BorderSize = 0;
            this.iconMin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconMin.IconChar = FontAwesome.Sharp.IconChar.Minus;
            this.iconMin.IconColor = System.Drawing.Color.Gainsboro;
            this.iconMin.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconMin.Location = new System.Drawing.Point(864, 28);
            this.iconMin.Name = "iconMin";
            this.iconMin.Size = new System.Drawing.Size(35, 35);
            this.iconMin.TabIndex = 4;
            this.iconMin.UseVisualStyleBackColor = true;
            this.iconMin.Click += new System.EventHandler(this.iconMin_Click);
            // 
            // iconExit
            // 
            this.iconExit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.iconExit.FlatAppearance.BorderSize = 0;
            this.iconExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconExit.IconChar = FontAwesome.Sharp.IconChar.Multiply;
            this.iconExit.IconColor = System.Drawing.Color.Gainsboro;
            this.iconExit.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconExit.Location = new System.Drawing.Point(915, 28);
            this.iconExit.Name = "iconExit";
            this.iconExit.Size = new System.Drawing.Size(35, 35);
            this.iconExit.TabIndex = 2;
            this.iconExit.UseVisualStyleBackColor = true;
            this.iconExit.Click += new System.EventHandler(this.iconExit_Click);
            // 
            // lblTitleBar
            // 
            this.lblTitleBar.AutoSize = true;
            this.lblTitleBar.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblTitleBar.Location = new System.Drawing.Point(51, 28);
            this.lblTitleBar.Name = "lblTitleBar";
            this.lblTitleBar.Size = new System.Drawing.Size(125, 28);
            this.lblTitleBar.TabIndex = 1;
            this.lblTitleBar.Text = "Página Inicial";
            // 
            // iconCurrent
            // 
            this.iconCurrent.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(0)))), ((int)(((byte)(36)))));
            this.iconCurrent.ForeColor = System.Drawing.Color.Gainsboro;
            this.iconCurrent.IconChar = FontAwesome.Sharp.IconChar.Home;
            this.iconCurrent.IconColor = System.Drawing.Color.Gainsboro;
            this.iconCurrent.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconCurrent.Location = new System.Drawing.Point(22, 28);
            this.iconCurrent.Name = "iconCurrent";
            this.iconCurrent.Size = new System.Drawing.Size(32, 32);
            this.iconCurrent.TabIndex = 0;
            this.iconCurrent.TabStop = false;
            // 
            // panelSombra
            // 
            this.panelSombra.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(24)))), ((int)(((byte)(58)))));
            this.panelSombra.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelSombra.Location = new System.Drawing.Point(220, 75);
            this.panelSombra.Name = "panelSombra";
            this.panelSombra.Size = new System.Drawing.Size(962, 9);
            this.panelSombra.TabIndex = 2;
            // 
            // panelDesktop
            // 
            this.panelDesktop.BackColor = System.Drawing.Color.White;
            this.panelDesktop.Controls.Add(this.lblNomes);
            this.panelDesktop.Controls.Add(this.lblDesenvolvimento);
            this.panelDesktop.Controls.Add(this.pictureBox1);
            this.panelDesktop.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelDesktop.Location = new System.Drawing.Point(220, 84);
            this.panelDesktop.Name = "panelDesktop";
            this.panelDesktop.Size = new System.Drawing.Size(962, 749);
            this.panelDesktop.TabIndex = 3;
            // 
            // lblNomes
            // 
            this.lblNomes.AutoSize = true;
            this.lblNomes.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblNomes.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(0)))), ((int)(((byte)(36)))));
            this.lblNomes.Location = new System.Drawing.Point(3, 684);
            this.lblNomes.Name = "lblNomes";
            this.lblNomes.Size = new System.Drawing.Size(228, 62);
            this.lblNomes.TabIndex = 2;
            this.lblNomes.Text = "João Luís Cardoso\r\nLeonardo Paiva Pinto";
            // 
            // lblDesenvolvimento
            // 
            this.lblDesenvolvimento.AutoSize = true;
            this.lblDesenvolvimento.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblDesenvolvimento.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(0)))), ((int)(((byte)(36)))));
            this.lblDesenvolvimento.Location = new System.Drawing.Point(0, 653);
            this.lblDesenvolvimento.Name = "lblDesenvolvimento";
            this.lblDesenvolvimento.Size = new System.Drawing.Size(197, 31);
            this.lblDesenvolvimento.TabIndex = 1;
            this.lblDesenvolvimento.Text = "Desenvolvido por:";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(22, 56);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(877, 658);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // Sistema
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1182, 833);
            this.Controls.Add(this.panelDesktop);
            this.Controls.Add(this.panelSombra);
            this.Controls.Add(this.panelTitleBar);
            this.Controls.Add(this.panelMenu);
            this.ForeColor = System.Drawing.Color.Gainsboro;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.IsMdiContainer = true;
            this.Name = "Sistema";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panelMenu.ResumeLayout(false);
            this.panelLogo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btnHome)).EndInit();
            this.panelTitleBar.ResumeLayout(false);
            this.panelTitleBar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconCurrent)).EndInit();
            this.panelDesktop.ResumeLayout(false);
            this.panelDesktop.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel panelMenu;
        private FontAwesome.Sharp.IconButton btnRemover;
        private FontAwesome.Sharp.IconButton btnAlterar;
        private FontAwesome.Sharp.IconButton btnBusca;
        private FontAwesome.Sharp.IconButton btnCadastro;
        private Panel panelLogo;
        private Panel panelTitleBar;
        private FontAwesome.Sharp.IconPictureBox iconCurrent;
        private Label lblTitleBar;
        private Panel panelSombra;
        private Panel panelDesktop;
        private FontAwesome.Sharp.IconButton iconExit;
        private FontAwesome.Sharp.IconButton iconMin;
        private Label lblmsgerro;
        private PictureBox pictureBox1;
        public PictureBox btnHome;
        private Label lblDesenvolvimento;
        private Label lblNomes;
    }
}