
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Facul
{
    class clsProduto : IComandos
    {
        SqlDataReader leitor;
        public SqlConnection Conexao { get; set; }
        public void alterar(string pNome, string pObs, string pWhere, string pQtd = "", string pAtivo = "")
        {
            try
            {
                using (SqlConnection conectado = BancoDados())
                {

                    string sCmd = $"UPDATE PRODUTO SET NOME = '{pNome}', OBS = '{pObs}', QUANTIDADE = {pQtd} WHERE ID = {pWhere}";
                    SqlCommand oCmd = new SqlCommand(sCmd);
                    conectado.Open();
                    oCmd.Connection = conectado;
                    oCmd.ExecuteNonQuery();

                    conectado.Close();
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Algo deu errado");
                throw;
            }
            //throw new NotImplementedException();
        }

        public SqlDataReader consultar(string pWhere = "")
        {
            try
            {
                string sCmd;
                Conexao = BancoDados();

                if (pWhere != string.Empty)
                    sCmd = $"SELECT * FROM PRODUTO WHERE ID = {pWhere}";
                else
                    sCmd = "SELECT * FROM PRODUTO";


                SqlCommand oCmd = new SqlCommand(sCmd);
                Conexao.Open();
                oCmd.Connection = Conexao;
                oCmd.ExecuteNonQuery();
                leitor = oCmd.ExecuteReader();
                
                return leitor;
            }
            catch (Exception)
            {
                MessageBox.Show("Algo deu errado");
                throw;
            }
            //throw new NotImplementedException();
        }

        public void deletar(string pWhere)
        {
            try
            {
                using (SqlConnection conectado = BancoDados())
                {

                    string sCmd = $"DELETE FROM PRODUTO WHERE ID = {pWhere}";
                    SqlCommand oCmd = new SqlCommand(sCmd);
                    conectado.Open();
                    oCmd.Connection = conectado;
                    oCmd.ExecuteNonQuery();

                    conectado.Close();
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Algo deu errado");
                throw;
            }
            //throw new NotImplementedException();
        }

        public void gravar(string pNome, string pObs, int pAtivo = 0, int pQtd = 0)
        {
            try
            {
                using (SqlConnection conectado = BancoDados())
                {
                    
                    string sCmd = $"INSERT INTO PRODUTO (NOME,OBS,QUANTIDADE) values ( '{pNome}','{pObs}',{pQtd}) ";
                    SqlCommand oCmd = new SqlCommand(sCmd);
                    conectado.Open();
                    oCmd.Connection = conectado;
                    oCmd.ExecuteNonQuery();

                    conectado.Close();
                }

            }
            catch (Exception)
            {
                MessageBox.Show("Algo deu errado");
                throw;
            }
            //throw new NotImplementedException();
        }

        public SqlConnection BancoDados()
        {
            SqlConnection conection = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Userwin\source\repos\HOWComBancoDiferente\DB_HOWTESTE.mdf;Integrated Security=True");
            return conection;
        }

        public int iAtivo(bool bCheck){ return 0; }
    }
}
