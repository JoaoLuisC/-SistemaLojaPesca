namespace JausinPescas
{
    partial class FormCadastro
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
            this.lblNomeProduto = new System.Windows.Forms.Label();
            this.lblQtdEstoque = new System.Windows.Forms.Label();
            this.lblPrecoCusto = new System.Windows.Forms.Label();
            this.lblPrecoVenda = new System.Windows.Forms.Label();
            this.lblDataInsercao = new System.Windows.Forms.Label();
            this.lblObsProduto = new System.Windows.Forms.Label();
            this.lblMarca = new System.Windows.Forms.Label();
            this.lblCategoria = new System.Windows.Forms.Label();
            this.lblFornecedor = new System.Windows.Forms.Label();
            this.txtNomeProduto = new System.Windows.Forms.TextBox();
            this.txtQtdEstoque = new System.Windows.Forms.TextBox();
            this.txtPrecoCusto = new System.Windows.Forms.TextBox();
            this.txtPrecoVenda = new System.Windows.Forms.TextBox();
            this.txtDataInsercao = new System.Windows.Forms.TextBox();
            this.cbCategoria = new System.Windows.Forms.ComboBox();
            this.cbMarca = new System.Windows.Forms.ComboBox();
            this.cbFornecedor = new System.Windows.Forms.ComboBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.rtxtObsProduto = new System.Windows.Forms.RichTextBox();
            this.iconConfirmaCadastro = new FontAwesome.Sharp.IconButton();
            this.lblmsgerro = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.iconAddFornecedor = new FontAwesome.Sharp.IconButton();
            this.iconAddMarca = new FontAwesome.Sharp.IconButton();
            this.iconAddCategoria = new FontAwesome.Sharp.IconButton();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.panel7 = new System.Windows.Forms.Panel();
            this.panel8 = new System.Windows.Forms.Panel();
            this.panel9 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblNomeProduto
            // 
            this.lblNomeProduto.AutoSize = true;
            this.lblNomeProduto.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblNomeProduto.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(0)))), ((int)(((byte)(36)))));
            this.lblNomeProduto.Location = new System.Drawing.Point(135, 71);
            this.lblNomeProduto.Name = "lblNomeProduto";
            this.lblNomeProduto.Size = new System.Drawing.Size(85, 31);
            this.lblNomeProduto.TabIndex = 0;
            this.lblNomeProduto.Text = "Nome:";
            // 
            // lblQtdEstoque
            // 
            this.lblQtdEstoque.AutoSize = true;
            this.lblQtdEstoque.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblQtdEstoque.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(0)))), ((int)(((byte)(36)))));
            this.lblQtdEstoque.Location = new System.Drawing.Point(135, 122);
            this.lblQtdEstoque.Name = "lblQtdEstoque";
            this.lblQtdEstoque.Size = new System.Drawing.Size(151, 31);
            this.lblQtdEstoque.TabIndex = 1;
            this.lblQtdEstoque.Text = "Qtd Estoque:";
            // 
            // lblPrecoCusto
            // 
            this.lblPrecoCusto.AutoSize = true;
            this.lblPrecoCusto.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblPrecoCusto.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(0)))), ((int)(((byte)(36)))));
            this.lblPrecoCusto.Location = new System.Drawing.Point(135, 175);
            this.lblPrecoCusto.Name = "lblPrecoCusto";
            this.lblPrecoCusto.Size = new System.Drawing.Size(147, 31);
            this.lblPrecoCusto.TabIndex = 2;
            this.lblPrecoCusto.Text = "Preço Custo:";
            // 
            // lblPrecoVenda
            // 
            this.lblPrecoVenda.AutoSize = true;
            this.lblPrecoVenda.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblPrecoVenda.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(0)))), ((int)(((byte)(36)))));
            this.lblPrecoVenda.Location = new System.Drawing.Point(135, 231);
            this.lblPrecoVenda.Name = "lblPrecoVenda";
            this.lblPrecoVenda.Size = new System.Drawing.Size(152, 31);
            this.lblPrecoVenda.TabIndex = 3;
            this.lblPrecoVenda.Text = "Preço Venda:";
            // 
            // lblDataInsercao
            // 
            this.lblDataInsercao.AutoSize = true;
            this.lblDataInsercao.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblDataInsercao.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(0)))), ((int)(((byte)(36)))));
            this.lblDataInsercao.Location = new System.Drawing.Point(135, 286);
            this.lblDataInsercao.Name = "lblDataInsercao";
            this.lblDataInsercao.Size = new System.Drawing.Size(197, 31);
            this.lblDataInsercao.TabIndex = 4;
            this.lblDataInsercao.Text = "Data de Inserção:";
            // 
            // lblObsProduto
            // 
            this.lblObsProduto.AutoSize = true;
            this.lblObsProduto.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblObsProduto.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(0)))), ((int)(((byte)(36)))));
            this.lblObsProduto.Location = new System.Drawing.Point(135, 493);
            this.lblObsProduto.Name = "lblObsProduto";
            this.lblObsProduto.Size = new System.Drawing.Size(155, 31);
            this.lblObsProduto.TabIndex = 5;
            this.lblObsProduto.Text = "Obs Produto:";
            // 
            // lblMarca
            // 
            this.lblMarca.AutoSize = true;
            this.lblMarca.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblMarca.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(0)))), ((int)(((byte)(36)))));
            this.lblMarca.Location = new System.Drawing.Point(135, 390);
            this.lblMarca.Name = "lblMarca";
            this.lblMarca.Size = new System.Drawing.Size(86, 31);
            this.lblMarca.TabIndex = 6;
            this.lblMarca.Text = "Marca:";
            // 
            // lblCategoria
            // 
            this.lblCategoria.AutoSize = true;
            this.lblCategoria.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblCategoria.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(0)))), ((int)(((byte)(36)))));
            this.lblCategoria.Location = new System.Drawing.Point(135, 338);
            this.lblCategoria.Name = "lblCategoria";
            this.lblCategoria.Size = new System.Drawing.Size(123, 31);
            this.lblCategoria.TabIndex = 7;
            this.lblCategoria.Text = "Categoria:";
            // 
            // lblFornecedor
            // 
            this.lblFornecedor.AutoSize = true;
            this.lblFornecedor.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblFornecedor.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(0)))), ((int)(((byte)(36)))));
            this.lblFornecedor.Location = new System.Drawing.Point(135, 443);
            this.lblFornecedor.Name = "lblFornecedor";
            this.lblFornecedor.Size = new System.Drawing.Size(142, 31);
            this.lblFornecedor.TabIndex = 8;
            this.lblFornecedor.Text = "Fornecedor:";
            // 
            // txtNomeProduto
            // 
            this.txtNomeProduto.BackColor = System.Drawing.Color.White;
            this.txtNomeProduto.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtNomeProduto.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtNomeProduto.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(0)))), ((int)(((byte)(36)))));
            this.txtNomeProduto.HideSelection = false;
            this.txtNomeProduto.Location = new System.Drawing.Point(334, 75);
            this.txtNomeProduto.Multiline = true;
            this.txtNomeProduto.Name = "txtNomeProduto";
            this.txtNomeProduto.Size = new System.Drawing.Size(425, 27);
            this.txtNomeProduto.TabIndex = 9;
            // 
            // txtQtdEstoque
            // 
            this.txtQtdEstoque.BackColor = System.Drawing.Color.White;
            this.txtQtdEstoque.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtQtdEstoque.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtQtdEstoque.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(0)))), ((int)(((byte)(36)))));
            this.txtQtdEstoque.Location = new System.Drawing.Point(334, 128);
            this.txtQtdEstoque.Name = "txtQtdEstoque";
            this.txtQtdEstoque.Size = new System.Drawing.Size(233, 27);
            this.txtQtdEstoque.TabIndex = 10;
            // 
            // txtPrecoCusto
            // 
            this.txtPrecoCusto.BackColor = System.Drawing.Color.White;
            this.txtPrecoCusto.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtPrecoCusto.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtPrecoCusto.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(0)))), ((int)(((byte)(36)))));
            this.txtPrecoCusto.Location = new System.Drawing.Point(334, 181);
            this.txtPrecoCusto.Name = "txtPrecoCusto";
            this.txtPrecoCusto.Size = new System.Drawing.Size(233, 27);
            this.txtPrecoCusto.TabIndex = 11;
            // 
            // txtPrecoVenda
            // 
            this.txtPrecoVenda.BackColor = System.Drawing.Color.White;
            this.txtPrecoVenda.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtPrecoVenda.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtPrecoVenda.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(0)))), ((int)(((byte)(36)))));
            this.txtPrecoVenda.Location = new System.Drawing.Point(334, 237);
            this.txtPrecoVenda.Name = "txtPrecoVenda";
            this.txtPrecoVenda.Size = new System.Drawing.Size(233, 27);
            this.txtPrecoVenda.TabIndex = 12;
            // 
            // txtDataInsercao
            // 
            this.txtDataInsercao.BackColor = System.Drawing.Color.White;
            this.txtDataInsercao.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtDataInsercao.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtDataInsercao.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(0)))), ((int)(((byte)(36)))));
            this.txtDataInsercao.Location = new System.Drawing.Point(334, 292);
            this.txtDataInsercao.Name = "txtDataInsercao";
            this.txtDataInsercao.Size = new System.Drawing.Size(233, 27);
            this.txtDataInsercao.TabIndex = 13;
            // 
            // cbCategoria
            // 
            this.cbCategoria.BackColor = System.Drawing.Color.White;
            this.cbCategoria.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.cbCategoria.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(0)))), ((int)(((byte)(36)))));
            this.cbCategoria.FormattingEnabled = true;
            this.cbCategoria.Location = new System.Drawing.Point(334, 344);
            this.cbCategoria.Name = "cbCategoria";
            this.cbCategoria.Size = new System.Drawing.Size(425, 28);
            this.cbCategoria.TabIndex = 14;
            // 
            // cbMarca
            // 
            this.cbMarca.BackColor = System.Drawing.Color.White;
            this.cbMarca.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.cbMarca.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(0)))), ((int)(((byte)(36)))));
            this.cbMarca.FormattingEnabled = true;
            this.cbMarca.Location = new System.Drawing.Point(334, 393);
            this.cbMarca.Name = "cbMarca";
            this.cbMarca.Size = new System.Drawing.Size(425, 28);
            this.cbMarca.TabIndex = 15;
            // 
            // cbFornecedor
            // 
            this.cbFornecedor.BackColor = System.Drawing.Color.White;
            this.cbFornecedor.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.cbFornecedor.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(0)))), ((int)(((byte)(36)))));
            this.cbFornecedor.FormattingEnabled = true;
            this.cbFornecedor.Location = new System.Drawing.Point(334, 446);
            this.cbFornecedor.Name = "cbFornecedor";
            this.cbFornecedor.Size = new System.Drawing.Size(425, 28);
            this.cbFornecedor.TabIndex = 16;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // rtxtObsProduto
            // 
            this.rtxtObsProduto.BackColor = System.Drawing.Color.White;
            this.rtxtObsProduto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.rtxtObsProduto.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.rtxtObsProduto.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(0)))), ((int)(((byte)(36)))));
            this.rtxtObsProduto.Location = new System.Drawing.Point(334, 499);
            this.rtxtObsProduto.Name = "rtxtObsProduto";
            this.rtxtObsProduto.Size = new System.Drawing.Size(425, 82);
            this.rtxtObsProduto.TabIndex = 18;
            this.rtxtObsProduto.Text = "";
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
            this.iconConfirmaCadastro.Location = new System.Drawing.Point(263, 560);
            this.iconConfirmaCadastro.Name = "iconConfirmaCadastro";
            this.iconConfirmaCadastro.Size = new System.Drawing.Size(227, 56);
            this.iconConfirmaCadastro.TabIndex = 19;
            this.iconConfirmaCadastro.Text = "Confirmar";
            this.iconConfirmaCadastro.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconConfirmaCadastro.UseVisualStyleBackColor = true;
            this.iconConfirmaCadastro.Click += new System.EventHandler(this.iconConfirmaCadastro_Click);
            // 
            // lblmsgerro
            // 
            this.lblmsgerro.AutoSize = true;
            this.lblmsgerro.ForeColor = System.Drawing.Color.Red;
            this.lblmsgerro.Location = new System.Drawing.Point(494, 24);
            this.lblmsgerro.Name = "lblmsgerro";
            this.lblmsgerro.Size = new System.Drawing.Size(0, 20);
            this.lblmsgerro.TabIndex = 20;
            // 
            // panel1
            // 
            this.panel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.iconConfirmaCadastro);
            this.panel1.Location = new System.Drawing.Point(86, 35);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(758, 639);
            this.panel1.TabIndex = 21;
            // 
            // iconAddFornecedor
            // 
            this.iconAddFornecedor.FlatAppearance.BorderSize = 0;
            this.iconAddFornecedor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconAddFornecedor.IconChar = FontAwesome.Sharp.IconChar.Plus;
            this.iconAddFornecedor.IconColor = System.Drawing.Color.Black;
            this.iconAddFornecedor.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconAddFornecedor.IconSize = 32;
            this.iconAddFornecedor.Location = new System.Drawing.Point(781, 446);
            this.iconAddFornecedor.Name = "iconAddFornecedor";
            this.iconAddFornecedor.Size = new System.Drawing.Size(22, 28);
            this.iconAddFornecedor.TabIndex = 26;
            this.iconAddFornecedor.UseVisualStyleBackColor = true;
            this.iconAddFornecedor.Click += new System.EventHandler(this.iconAddFornecedor_Click);
            // 
            // iconAddMarca
            // 
            this.iconAddMarca.FlatAppearance.BorderSize = 0;
            this.iconAddMarca.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconAddMarca.IconChar = FontAwesome.Sharp.IconChar.Plus;
            this.iconAddMarca.IconColor = System.Drawing.Color.Black;
            this.iconAddMarca.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconAddMarca.IconSize = 32;
            this.iconAddMarca.Location = new System.Drawing.Point(781, 393);
            this.iconAddMarca.Name = "iconAddMarca";
            this.iconAddMarca.Size = new System.Drawing.Size(22, 28);
            this.iconAddMarca.TabIndex = 26;
            this.iconAddMarca.UseVisualStyleBackColor = true;
            this.iconAddMarca.Click += new System.EventHandler(this.iconAddMarca_Click);
            // 
            // iconAddCategoria
            // 
            this.iconAddCategoria.FlatAppearance.BorderSize = 0;
            this.iconAddCategoria.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconAddCategoria.IconChar = FontAwesome.Sharp.IconChar.Plus;
            this.iconAddCategoria.IconColor = System.Drawing.Color.Black;
            this.iconAddCategoria.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconAddCategoria.IconSize = 32;
            this.iconAddCategoria.Location = new System.Drawing.Point(781, 344);
            this.iconAddCategoria.Name = "iconAddCategoria";
            this.iconAddCategoria.Size = new System.Drawing.Size(22, 28);
            this.iconAddCategoria.TabIndex = 20;
            this.iconAddCategoria.UseVisualStyleBackColor = true;
            this.iconAddCategoria.Click += new System.EventHandler(this.iconAddCategoria_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(0)))), ((int)(((byte)(36)))));
            this.panel2.Location = new System.Drawing.Point(334, 101);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(425, 1);
            this.panel2.TabIndex = 22;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(0)))), ((int)(((byte)(36)))));
            this.panel3.Location = new System.Drawing.Point(334, 318);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(233, 1);
            this.panel3.TabIndex = 23;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(0)))), ((int)(((byte)(36)))));
            this.panel4.Location = new System.Drawing.Point(334, 371);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(425, 1);
            this.panel4.TabIndex = 23;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(0)))), ((int)(((byte)(36)))));
            this.panel5.Location = new System.Drawing.Point(334, 420);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(425, 1);
            this.panel5.TabIndex = 23;
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(0)))), ((int)(((byte)(36)))));
            this.panel6.Location = new System.Drawing.Point(334, 473);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(425, 1);
            this.panel6.TabIndex = 23;
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(0)))), ((int)(((byte)(36)))));
            this.panel7.Location = new System.Drawing.Point(334, 207);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(233, 1);
            this.panel7.TabIndex = 24;
            // 
            // panel8
            // 
            this.panel8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(0)))), ((int)(((byte)(36)))));
            this.panel8.Location = new System.Drawing.Point(334, 263);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(233, 1);
            this.panel8.TabIndex = 25;
            // 
            // panel9
            // 
            this.panel9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(0)))), ((int)(((byte)(36)))));
            this.panel9.Location = new System.Drawing.Point(334, 154);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(233, 1);
            this.panel9.TabIndex = 25;
            // 
            // FormCadastro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(944, 702);
            this.Controls.Add(this.iconAddFornecedor);
            this.Controls.Add(this.iconAddMarca);
            this.Controls.Add(this.iconAddCategoria);
            this.Controls.Add(this.panel9);
            this.Controls.Add(this.panel8);
            this.Controls.Add(this.panel7);
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.lblmsgerro);
            this.Controls.Add(this.rtxtObsProduto);
            this.Controls.Add(this.cbFornecedor);
            this.Controls.Add(this.cbMarca);
            this.Controls.Add(this.cbCategoria);
            this.Controls.Add(this.txtDataInsercao);
            this.Controls.Add(this.txtPrecoVenda);
            this.Controls.Add(this.txtPrecoCusto);
            this.Controls.Add(this.txtQtdEstoque);
            this.Controls.Add(this.txtNomeProduto);
            this.Controls.Add(this.lblFornecedor);
            this.Controls.Add(this.lblCategoria);
            this.Controls.Add(this.lblMarca);
            this.Controls.Add(this.lblObsProduto);
            this.Controls.Add(this.lblDataInsercao);
            this.Controls.Add(this.lblPrecoVenda);
            this.Controls.Add(this.lblPrecoCusto);
            this.Controls.Add(this.lblQtdEstoque);
            this.Controls.Add(this.lblNomeProduto);
            this.Controls.Add(this.panel1);
            this.Name = "FormCadastro";
            this.Text = "FormCadastro";
            this.Load += new System.EventHandler(this.FormCadastro_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lblNomeProduto;
        private Label lblQtdEstoque;
        private Label lblPrecoCusto;
        private Label lblPrecoVenda;
        private Label lblDataInsercao;
        private Label lblObsProduto;
        private Label lblMarca;
        private Label lblCategoria;
        private Label lblFornecedor;
        private TextBox txtNomeProduto;
        private TextBox txtQtdEstoque;
        private TextBox txtPrecoCusto;
        private TextBox txtPrecoVenda;
        private TextBox txtDataInsercao;
        private ComboBox cbCategoria;
        private ComboBox cbMarca;
        private ComboBox cbFornecedor;
        private ContextMenuStrip contextMenuStrip1;
        private RichTextBox rtxtObsProduto;
        private FontAwesome.Sharp.IconButton iconConfirmaCadastro;
        private Label lblmsgerro;
        private Panel panel1;
        private Panel panel2;
        private Panel panel3;
        private Panel panel4;
        private Panel panel5;
        private Panel panel6;
        private Panel panel7;
        private Panel panel8;
        private Panel panel9;
        private FontAwesome.Sharp.IconButton iconAddFornecedor;
        private FontAwesome.Sharp.IconButton iconAddMarca;
        private FontAwesome.Sharp.IconButton iconAddCategoria;
    }
}