namespace JausinPescas
{
    partial class FormAddCategoria
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.iconConfirmaCadastro = new FontAwesome.Sharp.IconButton();
            this.panel3 = new System.Windows.Forms.Panel();
            this.txtTipo = new System.Windows.Forms.TextBox();
            this.lblTipoCategoria = new System.Windows.Forms.Label();
            this.lblAddCategoria = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblmsgerro = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.iconConfirmaCadastro);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.txtTipo);
            this.panel1.Controls.Add(this.lblTipoCategoria);
            this.panel1.Location = new System.Drawing.Point(56, 135);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(687, 274);
            this.panel1.TabIndex = 53;
            // 
            // iconConfirmaCadastro
            // 
            this.iconConfirmaCadastro.AutoSize = true;
            this.iconConfirmaCadastro.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.iconConfirmaCadastro.Font = new System.Drawing.Font("Segoe UI", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.iconConfirmaCadastro.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(0)))), ((int)(((byte)(36)))));
            this.iconConfirmaCadastro.IconChar = FontAwesome.Sharp.IconChar.Check;
            this.iconConfirmaCadastro.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(0)))), ((int)(((byte)(36)))));
            this.iconConfirmaCadastro.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconConfirmaCadastro.Location = new System.Drawing.Point(223, 187);
            this.iconConfirmaCadastro.Name = "iconConfirmaCadastro";
            this.iconConfirmaCadastro.Size = new System.Drawing.Size(227, 56);
            this.iconConfirmaCadastro.TabIndex = 55;
            this.iconConfirmaCadastro.Text = "Confirmar";
            this.iconConfirmaCadastro.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconConfirmaCadastro.UseVisualStyleBackColor = true;
            this.iconConfirmaCadastro.Click += new System.EventHandler(this.iconConfirmaCadastro_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(0)))), ((int)(((byte)(36)))));
            this.panel3.Location = new System.Drawing.Point(203, 118);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(425, 1);
            this.panel3.TabIndex = 25;
            // 
            // txtTipo
            // 
            this.txtTipo.BackColor = System.Drawing.Color.White;
            this.txtTipo.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtTipo.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtTipo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(0)))), ((int)(((byte)(36)))));
            this.txtTipo.HideSelection = false;
            this.txtTipo.Location = new System.Drawing.Point(203, 92);
            this.txtTipo.Multiline = true;
            this.txtTipo.Name = "txtTipo";
            this.txtTipo.Size = new System.Drawing.Size(425, 27);
            this.txtTipo.TabIndex = 24;
            // 
            // lblTipoCategoria
            // 
            this.lblTipoCategoria.AutoSize = true;
            this.lblTipoCategoria.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblTipoCategoria.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(0)))), ((int)(((byte)(36)))));
            this.lblTipoCategoria.Location = new System.Drawing.Point(49, 88);
            this.lblTipoCategoria.Name = "lblTipoCategoria";
            this.lblTipoCategoria.Size = new System.Drawing.Size(68, 31);
            this.lblTipoCategoria.TabIndex = 23;
            this.lblTipoCategoria.Text = "Tipo:";
            // 
            // lblAddCategoria
            // 
            this.lblAddCategoria.AutoSize = true;
            this.lblAddCategoria.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblAddCategoria.ForeColor = System.Drawing.Color.White;
            this.lblAddCategoria.Location = new System.Drawing.Point(270, 27);
            this.lblAddCategoria.Name = "lblAddCategoria";
            this.lblAddCategoria.Size = new System.Drawing.Size(237, 41);
            this.lblAddCategoria.TabIndex = 46;
            this.lblAddCategoria.Text = "Nova Categoria";            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(0)))), ((int)(((byte)(36)))));
            this.panel2.Controls.Add(this.lblAddCategoria);
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(799, 94);
            this.panel2.TabIndex = 54;
            // 
            // lblmsgerro
            // 
            this.lblmsgerro.AutoSize = true;
            this.lblmsgerro.ForeColor = System.Drawing.Color.Red;
            this.lblmsgerro.Location = new System.Drawing.Point(347, 129);
            this.lblmsgerro.Name = "lblmsgerro";
            this.lblmsgerro.Size = new System.Drawing.Size(104, 20);
            this.lblmsgerro.TabIndex = 52;
            this.lblmsgerro.Text = "teste msg erro";
            // 
            // FormAddCategoria
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.lblmsgerro);
            this.Name = "FormAddCategoria";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormAddCategoria";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Panel panel1;
        private Panel panel3;
        private TextBox txtTipo;
        private Label lblTipoCategoria;
        private Label lblAddCategoria;
        private Panel panel2;
        private Label lblmsgerro;
        private FontAwesome.Sharp.IconButton iconConfirmaCadastro;
    }
}