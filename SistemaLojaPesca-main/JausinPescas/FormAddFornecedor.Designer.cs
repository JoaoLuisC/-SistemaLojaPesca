namespace JausinPescas
{
    partial class FormAddFornecedor
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
            this.lblNovoFornecedor = new System.Windows.Forms.Label();
            this.lblmsgerro = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.iconConfirmaCadastro = new FontAwesome.Sharp.IconButton();
            this.panel3 = new System.Windows.Forms.Panel();
            this.txtNomeFornecedor = new System.Windows.Forms.TextBox();
            this.lblNomeFornecedor = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.txtCnpj = new System.Windows.Forms.TextBox();
            this.lblCnpj = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Controls.Add(this.txtCnpj);
            this.panel1.Controls.Add(this.lblCnpj);
            this.panel1.Controls.Add(this.iconConfirmaCadastro);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.txtNomeFornecedor);
            this.panel1.Controls.Add(this.lblNomeFornecedor);
            this.panel1.Location = new System.Drawing.Point(56, 135);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(687, 274);
            this.panel1.TabIndex = 50;
            // 
            // lblNovoFornecedor
            // 
            this.lblNovoFornecedor.AutoSize = true;
            this.lblNovoFornecedor.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblNovoFornecedor.ForeColor = System.Drawing.Color.White;
            this.lblNovoFornecedor.Location = new System.Drawing.Point(269, 31);
            this.lblNovoFornecedor.Name = "lblNovoFornecedor";
            this.lblNovoFornecedor.Size = new System.Drawing.Size(261, 41);
            this.lblNovoFornecedor.TabIndex = 46;
            this.lblNovoFornecedor.Text = "Novo Fornecedor";
            // 
            // lblmsgerro
            // 
            this.lblmsgerro.AutoSize = true;
            this.lblmsgerro.ForeColor = System.Drawing.Color.Red;
            this.lblmsgerro.Location = new System.Drawing.Point(344, -20);
            this.lblmsgerro.Name = "lblmsgerro";
            this.lblmsgerro.Size = new System.Drawing.Size(104, 20);
            this.lblmsgerro.TabIndex = 49;
            this.lblmsgerro.Text = "teste msg erro";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(0)))), ((int)(((byte)(36)))));
            this.panel2.Controls.Add(this.lblNovoFornecedor);
            this.panel2.Location = new System.Drawing.Point(1, 1);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(799, 94);
            this.panel2.TabIndex = 51;
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
            this.iconConfirmaCadastro.Location = new System.Drawing.Point(229, 197);
            this.iconConfirmaCadastro.Name = "iconConfirmaCadastro";
            this.iconConfirmaCadastro.Size = new System.Drawing.Size(227, 56);
            this.iconConfirmaCadastro.TabIndex = 62;
            this.iconConfirmaCadastro.Text = "Confirmar";
            this.iconConfirmaCadastro.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconConfirmaCadastro.UseVisualStyleBackColor = true;
            this.iconConfirmaCadastro.Click += new System.EventHandler(this.iconConfirmaCadastro_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(0)))), ((int)(((byte)(36)))));
            this.panel3.Location = new System.Drawing.Point(213, 74);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(425, 1);
            this.panel3.TabIndex = 61;
            // 
            // txtNomeFornecedor
            // 
            this.txtNomeFornecedor.BackColor = System.Drawing.Color.White;
            this.txtNomeFornecedor.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtNomeFornecedor.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtNomeFornecedor.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(0)))), ((int)(((byte)(36)))));
            this.txtNomeFornecedor.HideSelection = false;
            this.txtNomeFornecedor.Location = new System.Drawing.Point(213, 48);
            this.txtNomeFornecedor.Multiline = true;
            this.txtNomeFornecedor.Name = "txtNomeFornecedor";
            this.txtNomeFornecedor.Size = new System.Drawing.Size(425, 27);
            this.txtNomeFornecedor.TabIndex = 60;
            // 
            // lblNomeFornecedor
            // 
            this.lblNomeFornecedor.AutoSize = true;
            this.lblNomeFornecedor.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblNomeFornecedor.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(0)))), ((int)(((byte)(36)))));
            this.lblNomeFornecedor.Location = new System.Drawing.Point(59, 44);
            this.lblNomeFornecedor.Name = "lblNomeFornecedor";
            this.lblNomeFornecedor.Size = new System.Drawing.Size(85, 31);
            this.lblNomeFornecedor.TabIndex = 59;
            this.lblNomeFornecedor.Text = "Nome:";
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(0)))), ((int)(((byte)(36)))));
            this.panel4.Location = new System.Drawing.Point(213, 155);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(425, 1);
            this.panel4.TabIndex = 65;
            // 
            // txtCnpj
            // 
            this.txtCnpj.BackColor = System.Drawing.Color.White;
            this.txtCnpj.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtCnpj.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtCnpj.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(0)))), ((int)(((byte)(36)))));
            this.txtCnpj.HideSelection = false;
            this.txtCnpj.Location = new System.Drawing.Point(213, 129);
            this.txtCnpj.Multiline = true;
            this.txtCnpj.Name = "txtCnpj";
            this.txtCnpj.Size = new System.Drawing.Size(425, 27);
            this.txtCnpj.TabIndex = 64;
            // 
            // lblCnpj
            // 
            this.lblCnpj.AutoSize = true;
            this.lblCnpj.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblCnpj.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(0)))), ((int)(((byte)(36)))));
            this.lblCnpj.Location = new System.Drawing.Point(59, 125);
            this.lblCnpj.Name = "lblCnpj";
            this.lblCnpj.Size = new System.Drawing.Size(76, 31);
            this.lblCnpj.TabIndex = 63;
            this.lblCnpj.Text = "CPNJ:";
            // 
            // FormAddFornecedor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.lblmsgerro);
            this.Name = "FormAddFornecedor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormAddFuncionario";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Panel panel1;
        private Label lblNovoFornecedor;
        private Label lblmsgerro;
        private Panel panel2;
        private Panel panel4;
        private TextBox txtCnpj;
        private Label lblCnpj;
        private FontAwesome.Sharp.IconButton iconConfirmaCadastro;
        private Panel panel3;
        private TextBox txtNomeFornecedor;
        private Label lblNomeFornecedor;
    }
}