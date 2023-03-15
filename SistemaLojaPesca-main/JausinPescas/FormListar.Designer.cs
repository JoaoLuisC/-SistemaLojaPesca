namespace JausinPescas
{
    partial class FormListar
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgProduto = new System.Windows.Forms.DataGridView();
            this.lblTitleListar = new System.Windows.Forms.Label();
            this.iconRemove = new FontAwesome.Sharp.IconButton();
            this.iconAltera = new FontAwesome.Sharp.IconButton();
            this.panelDesktop2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.txtBusca = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgProduto)).BeginInit();
            this.panelDesktop2.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgProduto
            // 
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.NullValue = "-";
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black;
            this.dgProduto.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgProduto.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.dgProduto.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgProduto.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgProduto.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.NullValue = "-";
            dataGridViewCellStyle3.Padding = new System.Windows.Forms.Padding(2);
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgProduto.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgProduto.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(0)))), ((int)(((byte)(36)))));
            this.dgProduto.Location = new System.Drawing.Point(54, 181);
            this.dgProduto.Name = "dgProduto";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgProduto.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgProduto.RowHeadersWidth = 51;
            this.dgProduto.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(0)))), ((int)(((byte)(36)))));
            this.dgProduto.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.White;
            this.dgProduto.RowTemplate.Height = 29;
            this.dgProduto.Size = new System.Drawing.Size(820, 406);
            this.dgProduto.TabIndex = 0;
            // 
            // lblTitleListar
            // 
            this.lblTitleListar.AutoSize = true;
            this.lblTitleListar.Font = new System.Drawing.Font("Segoe UI", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblTitleListar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(0)))), ((int)(((byte)(36)))));
            this.lblTitleListar.Location = new System.Drawing.Point(289, 41);
            this.lblTitleListar.Name = "lblTitleListar";
            this.lblTitleListar.Size = new System.Drawing.Size(324, 50);
            this.lblTitleListar.TabIndex = 1;
            this.lblTitleListar.Text = "Lista de Produtos";
            // 
            // iconRemove
            // 
            this.iconRemove.AutoSize = true;
            this.iconRemove.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.iconRemove.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.iconRemove.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(0)))), ((int)(((byte)(36)))));
            this.iconRemove.IconChar = FontAwesome.Sharp.IconChar.TrashAlt;
            this.iconRemove.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(0)))), ((int)(((byte)(36)))));
            this.iconRemove.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconRemove.IconSize = 32;
            this.iconRemove.Location = new System.Drawing.Point(729, 624);
            this.iconRemove.Name = "iconRemove";
            this.iconRemove.Size = new System.Drawing.Size(145, 54);
            this.iconRemove.TabIndex = 21;
            this.iconRemove.Text = "Remover";
            this.iconRemove.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconRemove.UseVisualStyleBackColor = true;
            this.iconRemove.Click += new System.EventHandler(this.iconRemove_Click);
            // 
            // iconAltera
            // 
            this.iconAltera.AutoSize = true;
            this.iconAltera.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.iconAltera.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.iconAltera.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(0)))), ((int)(((byte)(36)))));
            this.iconAltera.IconChar = FontAwesome.Sharp.IconChar.FileAlt;
            this.iconAltera.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(0)))), ((int)(((byte)(36)))));
            this.iconAltera.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconAltera.IconSize = 32;
            this.iconAltera.Location = new System.Drawing.Point(568, 624);
            this.iconAltera.Name = "iconAltera";
            this.iconAltera.Size = new System.Drawing.Size(145, 54);
            this.iconAltera.TabIndex = 22;
            this.iconAltera.Text = "Alterar";
            this.iconAltera.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconAltera.UseVisualStyleBackColor = true;
            this.iconAltera.Click += new System.EventHandler(this.iconAltera_Click);
            // 
            // panelDesktop2
            // 
            this.panelDesktop2.Controls.Add(this.panel3);
            this.panelDesktop2.Controls.Add(this.txtBusca);
            this.panelDesktop2.Controls.Add(this.iconAltera);
            this.panelDesktop2.Controls.Add(this.dgProduto);
            this.panelDesktop2.Controls.Add(this.iconRemove);
            this.panelDesktop2.Location = new System.Drawing.Point(-3, -1);
            this.panelDesktop2.Name = "panelDesktop2";
            this.panelDesktop2.Size = new System.Drawing.Size(949, 705);
            this.panelDesktop2.TabIndex = 56;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(0)))), ((int)(((byte)(36)))));
            this.panel3.Location = new System.Drawing.Point(54, 155);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(337, 1);
            this.panel3.TabIndex = 48;
            // 
            // txtBusca
            // 
            this.txtBusca.BackColor = System.Drawing.Color.White;
            this.txtBusca.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtBusca.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtBusca.Location = new System.Drawing.Point(57, 129);
            this.txtBusca.Name = "txtBusca";
            this.txtBusca.PlaceholderText = "Pesquise um Produto";
            this.txtBusca.Size = new System.Drawing.Size(337, 27);
            this.txtBusca.TabIndex = 23;
            this.txtBusca.TextChanged += new System.EventHandler(this.txtBusca_TextChanged);
            // 
            // FormListar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(944, 702);
            this.Controls.Add(this.lblTitleListar);
            this.Controls.Add(this.panelDesktop2);
            this.Name = "FormListar";
            this.Text = "FormListar";
            this.Load += new System.EventHandler(this.FormListar_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgProduto)).EndInit();
            this.panelDesktop2.ResumeLayout(false);
            this.panelDesktop2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DataGridView dgProduto;
        private Label lblTitleListar;
        private FontAwesome.Sharp.IconButton iconRemove;
        private FontAwesome.Sharp.IconButton iconAltera;
        private Panel panelDesktop2;
        private TextBox txtBusca;
        private Panel panel3;
    }
}