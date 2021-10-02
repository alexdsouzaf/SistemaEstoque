
namespace Facul
{
    partial class frmMenu
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.grdMenu = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblWellcome = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.grdMenu)).BeginInit();
            this.SuspendLayout();
            // 
            // grdMenu
            // 
            this.grdMenu.AllowUserToDeleteRows = false;
            this.grdMenu.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.grdMenu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdMenu.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1});
            this.grdMenu.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.grdMenu.Location = new System.Drawing.Point(0, 40);
            this.grdMenu.Name = "grdMenu";
            this.grdMenu.ReadOnly = true;
            this.grdMenu.RowTemplate.Height = 25;
            this.grdMenu.Size = new System.Drawing.Size(384, 222);
            this.grdMenu.TabIndex = 2;
            this.grdMenu.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdMenu_CellContentClick);
            // 
            // Column1
            // 
            this.Column1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.Column1.DefaultCellStyle = dataGridViewCellStyle2;
            this.Column1.HeaderText = "";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // lblWellcome
            // 
            this.lblWellcome.AutoSize = true;
            this.lblWellcome.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblWellcome.Location = new System.Drawing.Point(96, 8);
            this.lblWellcome.Name = "lblWellcome";
            this.lblWellcome.Size = new System.Drawing.Size(168, 21);
            this.lblWellcome.TabIndex = 3;
            this.lblWellcome.Text = "Bem-Vindo ao Sistema";
            this.lblWellcome.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // frmMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 262);
            this.Controls.Add(this.lblWellcome);
            this.Controls.Add(this.grdMenu);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(400, 300);
            this.Name = "frmMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "..:: Menu ::..";
            this.Load += new System.EventHandler(this.frmMenu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grdMenu)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView grdMenu;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.Label lblWellcome;
    }
}