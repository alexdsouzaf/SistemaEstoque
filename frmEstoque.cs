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
                linha.Cells[0].Value = oRetorno.GetInt16(0);
                linha.Cells[1].Value = oRetorno.GetString(1);
                linha.Cells[2].Value = oRetorno.IsDBNull(2) ? string.Empty : oRetorno.GetString(2);
                linha.Cells[3].Value = oRetorno.GetInt16(3);
                grdEstoques.Rows.Add(linha);
            }

            oEstoque.Conexao.Close();
        }


        private void btnGravar_Click(object sender, EventArgs e)
        {            
            oEstoque.gravar(txtNome.Text, txtObs.Text, oEstoque.iAtivo(chkAtivo.Checked));
        }

        private void btnDeletar_Click(object sender, EventArgs e)
        {
            oEstoque.deletar(txtId.Text);
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            oEstoque.alterar(txtNome.Text, txtObs.Text, txtId.Text, string.Empty, oEstoque.iAtivo(chkAtivo.Checked).ToString() );
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

                while (oRetorno.Read())
                {

                    txtId.Text = oRetorno.GetInt16(0).ToString();
                    txtNome.Text = oRetorno.GetString(1);
                    txtObs.Text = oRetorno.IsDBNull(2) ? string.Empty : oRetorno.GetString(2);

                    if (oRetorno.GetInt16(3) == 1)
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
}
