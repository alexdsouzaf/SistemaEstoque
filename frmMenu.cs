using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//using MySqlConnector;

namespace Facul
{
    public partial class frmMenu : Form
    {
        clsProduto oProduto = new clsProduto();
        
        
        public frmMenu()
        {
            InitializeComponent();
        }


        private void frmMenu_Load(object sender, EventArgs e)
        {
            grdMenu.Rows.Add("ESTOQUE");
            grdMenu.Rows.Add("PRODUTO");
        }

        private void grdMenu_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
            string sTela = grdMenu.CurrentCell.Value.ToString();

            if (sTela == "PRODUTO")
            {
                frmProduto frmPro = new frmProduto();                
                frmPro.Show();
            }

            if (sTela == "ESTOQUE")
            {
                frmEstoque frmEst = new frmEstoque();
                frmEst.Show();                
            }

            
        }
    }
}
