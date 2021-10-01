
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
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
                linha.Cells[0].Value = oRetorno.GetInt32(0);
                linha.Cells[1].Value = oRetorno.GetString(1);
                linha.Cells[2].Value = oRetorno.IsDBNull(2) ? string.Empty : oRetorno.GetString(2);
                linha.Cells[3].Value = oRetorno.GetInt32(3);
                grdProdutos.Rows.Add(linha);
            }

            oProduto.Conexao.Close();
        }
        private void btnGravar_Click(object sender, EventArgs e)
        {

            if (ValidaCampos().ToString() != string.Empty)
            {
                oProduto.gravar(txtNome.Text, txtObs.Text, 0, Convert.ToInt32(txtQuant.Text));
                LimparCampos();
            }
            else
                MessageBox.Show("Não foi possível gravar o produto por um ou mais motivos:\r\n" + ValidaCampos().ToString());

        }

        private void btnDeletar_Click(object sender, EventArgs e)
        {
            oProduto.deletar(txtId.Text);
            LimparCampos();
            tabControl1.SelectedTab = tabPage1;
            btnAlterar.Visible = false;
            btnGravar.Visible = true;
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            if (ValidaCampos().ToString() != string.Empty)
            {
                oProduto.alterar(txtNome.Text, txtObs.Text, txtId.Text, txtQuant.Text, string.Empty);
                LimparCampos();
                tabControl1.SelectedTab = tabPage1;
                btnAlterar.Visible = false;
                btnGravar.Visible = true;
            }
            else
                MessageBox.Show("Não foi possível gravar o produto por um ou mais motivos:\r\n" + ValidaCampos().ToString());

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

                    txtId.Text = oRetorno.GetInt32(0).ToString();
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

        private bool MaskNum(string pQuant)
        {
            Regex num = new Regex("[0-9]");
            if (!num.IsMatch(pQuant))
                return false;
            else            
                return true;
        }

        private bool MaskText(string pNome)
        {
            Regex num = new Regex("[A-Z][a-z]");
            if (!num.IsMatch(pNome))
                return false;
            else
                return true;
        }

        private StringBuilder ValidaCampos()
        {
            StringBuilder sbMensagem = new StringBuilder();

            if (MaskNum(txtQuant.Text))
                sbMensagem.AppendLine(" - Campo quantidade deve conter apenas números.");

            if (Convert.ToInt32(txtQuant.Text) < 0)
                sbMensagem.AppendLine(" - Campo quantidade não pode ter valor de inclusão negativo.");

            if (MaskText(txtNome.Text))
                sbMensagem.AppendLine(" - Campo nome deve conter apenas letras.");

            return sbMensagem;
        }
    }
}
