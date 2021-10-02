
namespace Facul
{
    partial class frmProduto
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
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.lblStatus = new System.Windows.Forms.ToolStripStatusLabel();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.pnlTabela = new System.Windows.Forms.Panel();
            this.grdProdutos = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewButtonColumn();
            this.clmProduto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmDes = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmQtd = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.toolStrip2 = new System.Windows.Forms.ToolStrip();
            this.btnPesquisar = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.tbpCadastro = new System.Windows.Forms.TabPage();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnDeletar = new System.Windows.Forms.Button();
            this.btnAlterar = new System.Windows.Forms.Button();
            this.btnGravar = new System.Windows.Forms.Button();
            this.pnlComandos = new System.Windows.Forms.Panel();
            this.lblComboEstoque = new System.Windows.Forms.Label();
            this.cboEstoque = new System.Windows.Forms.ComboBox();
            this.lblQuant = new System.Windows.Forms.Label();
            this.txtQuant = new System.Windows.Forms.TextBox();
            this.lblObs = new System.Windows.Forms.Label();
            this.lblNome = new System.Windows.Forms.Label();
            this.lblId = new System.Windows.Forms.Label();
            this.txtObs = new System.Windows.Forms.TextBox();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.txtId = new System.Windows.Forms.TextBox();
            this.statusStrip1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.pnlTabela.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdProdutos)).BeginInit();
            this.toolStrip2.SuspendLayout();
            this.tbpCadastro.SuspendLayout();
            this.panel1.SuspendLayout();
            this.pnlComandos.SuspendLayout();
            this.SuspendLayout();
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lblStatus});
            this.statusStrip1.Location = new System.Drawing.Point(0, 240);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(584, 22);
            this.statusStrip1.TabIndex = 1;
            // 
            // lblStatus
            // 
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(457, 17);
            this.lblStatus.Text = "Tela onde poderá ser consultado, adicionado ou excluido um produto de um estoque";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tbpCadastro);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(584, 240);
            this.tabControl1.TabIndex = 10;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.pnlTabela);
            this.tabPage1.Location = new System.Drawing.Point(4, 24);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(576, 212);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Consulta";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // pnlTabela
            // 
            this.pnlTabela.Controls.Add(this.grdProdutos);
            this.pnlTabela.Controls.Add(this.toolStrip2);
            this.pnlTabela.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlTabela.Location = new System.Drawing.Point(3, 3);
            this.pnlTabela.Name = "pnlTabela";
            this.pnlTabela.Size = new System.Drawing.Size(570, 206);
            this.pnlTabela.TabIndex = 5;
            // 
            // grdProdutos
            // 
            this.grdProdutos.AllowUserToDeleteRows = false;
            this.grdProdutos.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.grdProdutos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdProdutos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.clmProduto,
            this.clmDes,
            this.clmQtd,
            this.Column2});
            this.grdProdutos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grdProdutos.Location = new System.Drawing.Point(0, 25);
            this.grdProdutos.Name = "grdProdutos";
            this.grdProdutos.ReadOnly = true;
            this.grdProdutos.RowTemplate.Height = 25;
            this.grdProdutos.Size = new System.Drawing.Size(570, 181);
            this.grdProdutos.TabIndex = 0;
            this.grdProdutos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdProdutos_CellContentClick);
            // 
            // ID
            // 
            this.ID.HeaderText = "Id";
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            this.ID.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.ID.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.ID.Width = 50;
            // 
            // clmProduto
            // 
            this.clmProduto.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.clmProduto.HeaderText = "Produto";
            this.clmProduto.Name = "clmProduto";
            this.clmProduto.ReadOnly = true;
            this.clmProduto.Width = 75;
            // 
            // clmDes
            // 
            this.clmDes.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.clmDes.HeaderText = "Descrição";
            this.clmDes.Name = "clmDes";
            this.clmDes.ReadOnly = true;
            this.clmDes.Width = 83;
            // 
            // clmQtd
            // 
            this.clmQtd.HeaderText = "Quantidade";
            this.clmQtd.Name = "clmQtd";
            this.clmQtd.ReadOnly = true;
            this.clmQtd.Width = 75;
            // 
            // Column2
            // 
            this.Column2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Column2.HeaderText = "Estoque";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.Width = 74;
            // 
            // toolStrip2
            // 
            this.toolStrip2.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnPesquisar,
            this.toolStripSeparator2});
            this.toolStrip2.Location = new System.Drawing.Point(0, 0);
            this.toolStrip2.Name = "toolStrip2";
            this.toolStrip2.Size = new System.Drawing.Size(570, 25);
            this.toolStrip2.TabIndex = 8;
            this.toolStrip2.Text = "toolStrip2";
            this.toolStrip2.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.toolStrip2_ItemClicked);
            // 
            // btnPesquisar
            // 
            this.btnPesquisar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.btnPesquisar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnPesquisar.Name = "btnPesquisar";
            this.btnPesquisar.Size = new System.Drawing.Size(61, 22);
            this.btnPesquisar.Text = "Pesquisar";
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // tbpCadastro
            // 
            this.tbpCadastro.Controls.Add(this.panel1);
            this.tbpCadastro.Controls.Add(this.pnlComandos);
            this.tbpCadastro.Location = new System.Drawing.Point(4, 24);
            this.tbpCadastro.Name = "tbpCadastro";
            this.tbpCadastro.Padding = new System.Windows.Forms.Padding(3);
            this.tbpCadastro.Size = new System.Drawing.Size(576, 212);
            this.tbpCadastro.TabIndex = 2;
            this.tbpCadastro.Text = "Cadastro";
            this.tbpCadastro.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnDeletar);
            this.panel1.Controls.Add(this.btnAlterar);
            this.panel1.Controls.Add(this.btnGravar);
            this.panel1.Location = new System.Drawing.Point(3, 123);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(570, 28);
            this.panel1.TabIndex = 4;
            // 
            // btnDeletar
            // 
            this.btnDeletar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnDeletar.Location = new System.Drawing.Point(154, 0);
            this.btnDeletar.Name = "btnDeletar";
            this.btnDeletar.Size = new System.Drawing.Size(254, 28);
            this.btnDeletar.TabIndex = 9;
            this.btnDeletar.Text = "Deletar";
            this.btnDeletar.UseVisualStyleBackColor = true;
            this.btnDeletar.Click += new System.EventHandler(this.btnDeletar_Click);
            // 
            // btnAlterar
            // 
            this.btnAlterar.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnAlterar.Location = new System.Drawing.Point(408, 0);
            this.btnAlterar.Name = "btnAlterar";
            this.btnAlterar.Size = new System.Drawing.Size(162, 28);
            this.btnAlterar.TabIndex = 10;
            this.btnAlterar.Text = "Alterar";
            this.btnAlterar.UseVisualStyleBackColor = true;
            this.btnAlterar.Visible = false;
            this.btnAlterar.Click += new System.EventHandler(this.btnAlterar_Click);
            // 
            // btnGravar
            // 
            this.btnGravar.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnGravar.Location = new System.Drawing.Point(0, 0);
            this.btnGravar.Name = "btnGravar";
            this.btnGravar.Size = new System.Drawing.Size(154, 28);
            this.btnGravar.TabIndex = 8;
            this.btnGravar.Text = "Gravar";
            this.btnGravar.UseVisualStyleBackColor = true;
            this.btnGravar.Click += new System.EventHandler(this.btnGravar_Click);
            // 
            // pnlComandos
            // 
            this.pnlComandos.Controls.Add(this.lblComboEstoque);
            this.pnlComandos.Controls.Add(this.cboEstoque);
            this.pnlComandos.Controls.Add(this.lblQuant);
            this.pnlComandos.Controls.Add(this.txtQuant);
            this.pnlComandos.Controls.Add(this.lblObs);
            this.pnlComandos.Controls.Add(this.lblNome);
            this.pnlComandos.Controls.Add(this.lblId);
            this.pnlComandos.Controls.Add(this.txtObs);
            this.pnlComandos.Controls.Add(this.txtNome);
            this.pnlComandos.Controls.Add(this.txtId);
            this.pnlComandos.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlComandos.Location = new System.Drawing.Point(3, 3);
            this.pnlComandos.Name = "pnlComandos";
            this.pnlComandos.Size = new System.Drawing.Size(570, 120);
            this.pnlComandos.TabIndex = 3;
            // 
            // lblComboEstoque
            // 
            this.lblComboEstoque.AutoSize = true;
            this.lblComboEstoque.Location = new System.Drawing.Point(330, 10);
            this.lblComboEstoque.Name = "lblComboEstoque";
            this.lblComboEstoque.Size = new System.Drawing.Size(49, 15);
            this.lblComboEstoque.TabIndex = 11;
            this.lblComboEstoque.Text = "Estoque";
            // 
            // cboEstoque
            // 
            this.cboEstoque.FormattingEnabled = true;
            this.cboEstoque.Location = new System.Drawing.Point(330, 28);
            this.cboEstoque.Name = "cboEstoque";
            this.cboEstoque.Size = new System.Drawing.Size(121, 23);
            this.cboEstoque.TabIndex = 10;
            // 
            // lblQuant
            // 
            this.lblQuant.AutoSize = true;
            this.lblQuant.Location = new System.Drawing.Point(211, 11);
            this.lblQuant.Name = "lblQuant";
            this.lblQuant.Size = new System.Drawing.Size(69, 15);
            this.lblQuant.TabIndex = 8;
            this.lblQuant.Text = "Quantidade";
            // 
            // txtQuant
            // 
            this.txtQuant.Location = new System.Drawing.Point(211, 28);
            this.txtQuant.Name = "txtQuant";
            this.txtQuant.Size = new System.Drawing.Size(113, 23);
            this.txtQuant.TabIndex = 2;
            // 
            // lblObs
            // 
            this.lblObs.AutoSize = true;
            this.lblObs.Location = new System.Drawing.Point(12, 54);
            this.lblObs.Name = "lblObs";
            this.lblObs.Size = new System.Drawing.Size(69, 15);
            this.lblObs.TabIndex = 6;
            this.lblObs.Text = "Observação";
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Location = new System.Drawing.Point(57, 11);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(40, 15);
            this.lblNome.TabIndex = 5;
            this.lblNome.Text = "Nome";
            // 
            // lblId
            // 
            this.lblId.AutoSize = true;
            this.lblId.Location = new System.Drawing.Point(15, 11);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(17, 15);
            this.lblId.TabIndex = 4;
            this.lblId.Text = "Id";
            // 
            // txtObs
            // 
            this.txtObs.Location = new System.Drawing.Point(5, 71);
            this.txtObs.Name = "txtObs";
            this.txtObs.Size = new System.Drawing.Size(560, 23);
            this.txtObs.TabIndex = 3;
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(57, 28);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(148, 23);
            this.txtNome.TabIndex = 1;
            // 
            // txtId
            // 
            this.txtId.Enabled = false;
            this.txtId.Location = new System.Drawing.Point(12, 28);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(39, 23);
            this.txtId.TabIndex = 0;
            // 
            // frmProduto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 262);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.statusStrip1);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(600, 300);
            this.Name = "frmProduto";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "..:: Produto ::..";
            this.Load += new System.EventHandler(this.frmProduto_Load);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.pnlTabela.ResumeLayout(false);
            this.pnlTabela.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdProdutos)).EndInit();
            this.toolStrip2.ResumeLayout(false);
            this.toolStrip2.PerformLayout();
            this.tbpCadastro.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.pnlComandos.ResumeLayout(false);
            this.pnlComandos.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel lblStatus;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Panel pnlTabela;
        private System.Windows.Forms.DataGridView grdProdutos;
        private System.Windows.Forms.ToolStrip toolStrip2;
        private System.Windows.Forms.ToolStripButton btnPesquisar;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.TabPage tbpCadastro;
        private System.Windows.Forms.Button btnDeletar;
        private System.Windows.Forms.Button btnAlterar;
        private System.Windows.Forms.Button btnGravar;
        private System.Windows.Forms.Panel pnlComandos;
        private System.Windows.Forms.Label lblQuant;
        private System.Windows.Forms.TextBox txtQuant;
        private System.Windows.Forms.Label lblObs;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.Label lblId;
        private System.Windows.Forms.TextBox txtObs;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblComboEstoque;
        private System.Windows.Forms.ComboBox cboEstoque;
        private System.Windows.Forms.DataGridViewButtonColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmProduto;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmDes;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmQtd;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
    }
}