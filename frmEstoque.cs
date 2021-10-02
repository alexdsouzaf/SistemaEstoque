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
    public partial class frmEstoque : Form
    {
        ClsEstoque oEstoque = new ClsEstoque();
        SqlDataReader oRetorno;

        public frmEstoque()
        {
            InitializeComponent();
        }

        private void toolStrip2_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            oRetorno =  oEstoque.consultar();
            grdEstoques.Rows.Clear();

            while ( oRetorno.Read() )
            {
                DataGridViewRow linha = (DataGridViewRow)grdEstoques.Rows[0].Clone();
                linha.Cells[0].Value = oRetorno.GetInt32(0);
                linha.Cells[1].Value = oRetorno.GetString(1);
                linha.Cells[2].Value = oRetorno.IsDBNull(2) ? string.Empty : oRetorno.GetString(2);
                linha.Cells[3].Value = oRetorno.GetInt32(3);
                grdEstoques.Rows.Add(linha);
            }

            oEstoque.Conexao.Close();
        }


        private void btnGravar_Click(object sender, EventArgs e)
        {

            if (ValidaCampos().ToString() != string.Empty)
            {
                oEstoque.gravar(txtNome.Text, txtObs.Text, "",oEstoque.iAtivo(chkAtivo.Checked));
                LimparCampos();
            }
            else
                MessageBox.Show("Não foi possível gravar o estoque por um ou mais motivos:\r\n" + ValidaCampos().ToString());

        }

        private void btnDeletar_Click(object sender, EventArgs e)
        {
            oEstoque.deletar(txtId.Text);
            LimparCampos();
            tbpConsulta.SelectedTab = tabPage1;
            btnAlterar.Visible = false;
            btnGravar.Visible = true;

        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {

            if (ValidaCampos().ToString() != string.Empty)
            {
                oEstoque.alterar(txtNome.Text, txtObs.Text, txtId.Text, string.Empty, oEstoque.iAtivo(chkAtivo.Checked).ToString());
                LimparCampos();
                tbpConsulta.SelectedTab = tabPage1;
                btnAlterar.Visible = false;
                btnGravar.Visible = true;
            }
            else
                MessageBox.Show("Não foi possível alterar o estoque por um ou mais motivos:\r\n" + ValidaCampos().ToString());

        }

        private void LimparCampos()
        {
            txtId.Clear();
            txtNome.Clear();
            txtObs.Clear();
        }

        private void grdEstoques_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (grdEstoques.Columns.Contains("ID"))
            {
                string sID = grdEstoques.CurrentCell.Value.ToString();
                LimparCampos();

                oRetorno = oEstoque.consultar(sID);

                if (oRetorno != null)
                {
                    while (oRetorno.Read())
                    {

                        txtId.Text = oRetorno.GetInt32(0).ToString();
                        txtNome.Text = oRetorno.GetString(1);
                        txtObs.Text = oRetorno.IsDBNull(2) ? string.Empty : oRetorno.GetString(2);

                        if (oRetorno.GetInt32(3) == 1)
                            chkAtivo.Checked = true;
                        else
                            chkAtivo.Checked = false;

                    }
                    oEstoque.Conexao.Close();
                    btnAlterar.Visible = true;
                    btnGravar.Visible = false;
                    tbpConsulta.SelectedTab = tbpCadastro;
                }

            }
        }

        private bool MaskText(string pNome)
        {
            //Regex num = new Regex("[A-Za-z]"); //apenas letras
            Regex texto = new Regex(@" ^[a - zA - Z á] * $"); //letras , espaço , acentos
            if (!texto.IsMatch(pNome))
                return true;
            else
                return false;
        }

        /// <summary>
        /// Método para validar o valor dos campos antes de tentar executar a query no banco
        /// Evita anomalias no sql
        /// </summary>
        private StringBuilder ValidaCampos()
        {
            StringBuilder sbMensagem = new StringBuilder();

            if (MaskText(txtNome.Text))
                sbMensagem.AppendLine(" - Campo nome deve conter apenas letras.");

            return sbMensagem;
        }
    }
}
