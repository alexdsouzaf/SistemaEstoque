
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Facul
{
    public partial class frmProduto : Form
    {
        clsProduto oProduto = new clsProduto();
        SqlDataReader oRetorno;
        public frmProduto()
        {
            InitializeComponent();
        }

        private void toolStrip2_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            oRetorno = oProduto.consultar();
            grdProdutos.Rows.Clear();

            while (oRetorno.Read())
            {
                DataGridViewRow linha = (DataGridViewRow)grdProdutos.Rows[0].Clone();
                linha.Cells[0].Value = oRetorno.GetInt16(0);
                linha.Cells[1].Value = oRetorno.GetString(1);
                linha.Cells[2].Value = oRetorno.IsDBNull(2) ? string.Empty : oRetorno.GetString(2);
                linha.Cells[3].Value = oRetorno.GetInt16(3);
                grdProdutos.Rows.Add(linha);
            }

            oProduto.Conexao.Close();
        }
        private void btnGravar_Click(object sender, EventArgs e)
        {

            oProduto.gravar(txtNome.Text, txtObs.Text, 0, Convert.ToInt32(txtQuant.Text));
        }

        private void btnDeletar_Click(object sender, EventArgs e)
        {
            oProduto.deletar(txtId.Text);
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            oProduto.alterar(txtNome.Text, txtObs.Text, txtId.Text, txtQuant.Text, string.Empty); //tem que passar a quantidade
        }

        private void LimparCampos()
        {
            txtId.Clear();
            txtNome.Clear();
            txtObs.Clear();
        }

        private void grdProdutos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (grdProdutos.Columns.Contains("ID"))
            {
                string sId = grdProdutos.CurrentCell.Value.ToString();
                LimparCampos();

                oRetorno = oProduto.consultar(sId); 

                while (oRetorno.Read())
                {

                    txtId.Text = oRetorno.GetInt16(0).ToString();
                    txtNome.Text = oRetorno.GetString(1);
                    txtObs.Text = oRetorno.IsDBNull(2) ? string.Empty : oRetorno.GetString(2);
                    txtQuant.Text = oRetorno.GetInt32(3).ToString();

                }
                oProduto.Conexao.Close();
                btnAlterar.Visible = true;
                btnGravar.Visible = false;
                tabControl1.SelectedTab = tbpCadastro;
            }
        }
    }
}
