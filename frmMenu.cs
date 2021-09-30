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

        private void button1_Click(object sender, EventArgs e)
        {
            frmEstoque oEstoque = new frmEstoque();
            oEstoque.Show();
        }

        private void btnProduto_Click(object sender, EventArgs e)
        {
            frmProduto oProduto = new frmProduto();
            oProduto.Show();
        }

        private void frmMenu_Load(object sender, EventArgs e)
        {

            
        }


    }
}
