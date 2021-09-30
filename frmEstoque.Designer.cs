
namespace Facul
{
    partial class frmEstoque
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
            this.tbpConsulta = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.pnlTabela = new System.Windows.Forms.Panel();
            this.grdEstoques = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewButtonColumn();
            this.clmNome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmObs = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmAtivo = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.toolStrip2 = new System.Windows.Forms.ToolStrip();
            this.btnPesquisar = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.tbpCadastro = new System.Windows.Forms.TabPage();
            this.btnDeletar = new System.Windows.Forms.Button();
            this.btnAlterar = new System.Windows.Forms.Button();
            this.btnGravar = new System.Windows.Forms.Button();
            this.pnlComandos = new System.Windows.Forms.Panel();
            this.lblObs = new System.Windows.Forms.Label();
            this.lblNome = new System.Windows.Forms.Label();
            this.lblId = new System.Windows.Forms.Label();
            this.chkAtivo = new System.Windows.Forms.CheckBox();
            this.txtObs = new System.Windows.Forms.TextBox();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.txtId = new System.Windows.Forms.TextBox();
            this.statusStrip1.SuspendLayout();
            this.tbpConsulta.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.pnlTabela.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdEstoques)).BeginInit();
            this.toolStrip2.SuspendLayout();
            this.tbpCadastro.SuspendLayout();
            this.pnlComandos.SuspendLayout();
            this.SuspendLayout();
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lblStatus});
            this.statusStrip1.Location = new System.Drawing.Point(0, 179);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(543, 22);
            this.statusStrip1.TabIndex = 0;
            // 
            // lblStatus
            // 
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(353, 17);
            this.lblStatus.Text = "Tela onde poderá ser consultado, criado ou inativado um estoque";
            // 
            // tbpConsulta
            // 
            this.tbpConsulta.Controls.Add(this.tabPage1);
            this.tbpConsulta.Controls.Add(this.tbpCadastro);
            this.tbpConsulta.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbpConsulta.Location = new System.Drawing.Point(0, 0);
            this.tbpConsulta.Name = "tbpConsulta";
            this.tbpConsulta.SelectedIndex = 0;
            this.tbpConsulta.Size = new System.Drawing.Size(543, 179);
            this.tbpConsulta.TabIndex = 8;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.pnlTabela);
            this.tabPage1.Location = new System.Drawing.Point(4, 24);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(535, 151);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Consulta";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // pnlTabela
            // 
            this.pnlTabela.Controls.Add(this.grdEstoques);
            this.pnlTabela.Controls.Add(this.toolStrip2);
            this.pnlTabela.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlTabela.Location = new System.Drawing.Point(3, 3);
            this.pnlTabela.Name = "pnlTabela";
            this.pnlTabela.Size = new System.Drawing.Size(529, 145);
            this.pnlTabela.TabIndex = 4;
            // 
            // grdEstoques
            // 
            this.grdEstoques.AllowUserToDeleteRows = false;
            this.grdEstoques.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.grdEstoques.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdEstoques.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.clmNome,
            this.clmObs,
            this.clmAtivo});
            this.grdEstoques.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grdEstoques.Location = new System.Drawing.Point(0, 25);
            this.grdEstoques.Name = "grdEstoques";
            this.grdEstoques.ReadOnly = true;
            this.grdEstoques.RowTemplate.Height = 25;
            this.grdEstoques.Size = new System.Drawing.Size(529, 120);
            this.grdEstoques.TabIndex = 0;
            this.grdEstoques.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdEstoques_CellContentClick);
            // 
            // ID
            // 
            this.ID.HeaderText = "ID";
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            this.ID.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.ID.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // clmNome
            // 
            this.clmNome.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.clmNome.HeaderText = "Nome";
            this.clmNome.Name = "clmNome";
            this.clmNome.ReadOnly = true;
            this.clmNome.Width = 65;
            // 
            // clmObs
            // 
            this.clmObs.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.clmObs.HeaderText = "Observação";
            this.clmObs.Name = "clmObs";
            this.clmObs.ReadOnly = true;
            this.clmObs.Width = 94;
            // 
            // clmAtivo
            // 
            this.clmAtivo.HeaderText = "Ativo";
            this.clmAtivo.Name = "clmAtivo";
            this.clmAtivo.ReadOnly = true;
            // 
            // toolStrip2
            // 
            this.toolStrip2.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnPesquisar,
            this.toolStripSeparator2});
            this.toolStrip2.Location = new System.Drawing.Point(0, 0);
            this.toolStrip2.Name = "toolStrip2";
            this.toolStrip2.Size = new System.Drawing.Size(529, 25);
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
            this.tbpCadastro.Controls.Add(this.btnDeletar);
            this.tbpCadastro.Controls.Add(this.btnAlterar);
            this.tbpCadastro.Controls.Add(this.btnGravar);
            this.tbpCadastro.Controls.Add(this.pnlComandos);
            this.tbpCadastro.Location = new System.Drawing.Point(4, 24);
            this.tbpCadastro.Name = "tbpCadastro";
            this.tbpCadastro.Padding = new System.Windows.Forms.Padding(3);
            this.tbpCadastro.Size = new System.Drawing.Size(535, 151);
            this.tbpCadastro.TabIndex = 1;
            this.tbpCadastro.Text = "Cadastro";
            this.tbpCadastro.UseVisualStyleBackColor = true;
            // 
            // btnDeletar
            // 
            this.btnDeletar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnDeletar.Location = new System.Drawing.Point(157, 123);
            this.btnDeletar.Name = "btnDeletar";
            this.btnDeletar.Size = new System.Drawing.Size(213, 25);
            this.btnDeletar.TabIndex = 9;
            this.btnDeletar.Text = "Deletar";
            this.btnDeletar.UseVisualStyleBackColor = true;
            this.btnDeletar.Click += new System.EventHandler(this.btnDeletar_Click);
            // 
            // btnAlterar
            // 
            this.btnAlterar.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnAlterar.Location = new System.Drawing.Point(370, 123);
            this.btnAlterar.Name = "btnAlterar";
            this.btnAlterar.Size = new System.Drawing.Size(162, 25);
            this.btnAlterar.TabIndex = 10;
            this.btnAlterar.Text = "Alterar";
            this.btnAlterar.UseVisualStyleBackColor = true;
            this.btnAlterar.Visible = false;
            this.btnAlterar.Click += new System.EventHandler(this.btnAlterar_Click);
            // 
            // btnGravar
            // 
            this.btnGravar.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnGravar.Location = new System.Drawing.Point(3, 123);
            this.btnGravar.Name = "btnGravar";
            this.btnGravar.Size = new System.Drawing.Size(154, 25);
            this.btnGravar.TabIndex = 8;
            this.btnGravar.Text = "Gravar";
            this.btnGravar.UseVisualStyleBackColor = true;
            this.btnGravar.Click += new System.EventHandler(this.btnGravar_Click);
            // 
            // pnlComandos
            // 
            this.pnlComandos.Controls.Add(this.lblObs);
            this.pnlComandos.Controls.Add(this.lblNome);
            this.pnlComandos.Controls.Add(this.lblId);
            this.pnlComandos.Controls.Add(this.chkAtivo);
            this.pnlComandos.Controls.Add(this.txtObs);
            this.pnlComandos.Controls.Add(this.txtNome);
            this.pnlComandos.Controls.Add(this.txtId);
            this.pnlComandos.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlComandos.Location = new System.Drawing.Point(3, 3);
            this.pnlComandos.Name = "pnlComandos";
            this.pnlComandos.Size = new System.Drawing.Size(529, 120);
            this.pnlComandos.TabIndex = 3;
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
            // chkAtivo
            // 
            this.chkAtivo.AutoSize = true;
            this.chkAtivo.Location = new System.Drawing.Point(211, 30);
            this.chkAtivo.Name = "chkAtivo";
            this.chkAtivo.Size = new System.Drawing.Size(97, 19);
            this.chkAtivo.TabIndex = 3;
            this.chkAtivo.Text = "Estoque ativo";
            this.chkAtivo.UseVisualStyleBackColor = true;
            // 
            // txtObs
            // 
            this.txtObs.Location = new System.Drawing.Point(5, 71);
            this.txtObs.Name = "txtObs";
            this.txtObs.Size = new System.Drawing.Size(519, 23);
            this.txtObs.TabIndex = 2;
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
            this.txtId.Location = new System.Drawing.Point(12, 28);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(39, 23);
            this.txtId.TabIndex = 0;
            // 
            // frmEstoque
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(543, 201);
            this.Controls.Add(this.tbpConsulta);
            this.Controls.Add(this.statusStrip1);
            this.Name = "frmEstoque";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "..:: Estoques ::..";
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.tbpConsulta.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.pnlTabela.ResumeLayout(false);
            this.pnlTabela.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdEstoques)).EndInit();
            this.toolStrip2.ResumeLayout(false);
            this.toolStrip2.PerformLayout();
            this.tbpCadastro.ResumeLayout(false);
            this.pnlComandos.ResumeLayout(false);
            this.pnlComandos.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel lblStatus;
        private System.Windows.Forms.TabControl tbpConsulta;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Panel pnlTabela;
        private System.Windows.Forms.DataGridView grdEstoques;
        private System.Windows.Forms.ToolStrip toolStrip2;
        private System.Windows.Forms.ToolStripButton btnPesquisar;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.TabPage tbpCadastro;
        private System.Windows.Forms.Panel pnlComandos;
        private System.Windows.Forms.Label lblObs;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.CheckBox chkAtivo;
        private System.Windows.Forms.TextBox txtObs;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Label lblId;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.Button btnDeletar;
        private System.Windows.Forms.Button btnGravar;
        private System.Windows.Forms.Button btnAlterar;
        private System.Windows.Forms.DataGridViewButtonColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmNome;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmObs;
        private System.Windows.Forms.DataGridViewCheckBoxColumn clmAtivo;
    }
}