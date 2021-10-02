
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
                MessageBox.Show("Registro alterado com sucesso!");
            }
            catch (Exception)
            {
                MessageBox.Show("Algo deu errado");
            }
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
                return leitor;
            }
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
                MessageBox.Show("Registro removido com sucesso!");
            }
            catch (Exception)
            {
                MessageBox.Show("Algo deu errado");                
            }
        }

        public void gravar(string pNome, string pObs, string pEstoqueDes = "", int pAtivo = 0, int pQtd = 0)
        {
            pEstoqueDes = pEstoqueDes.Trim();
            try
            {
                SqlDataReader oRetorno = PegaId(pEstoqueDes);
                int i = 0;
                if (oRetorno.Read())
                    i = oRetorno.GetInt32(0);

                using (SqlConnection conectado = BancoDados())
                {
                    
                    string sCmd = $"INSERT INTO PRODUTO (NOME,OBS,QUANTIDADE, ESTOQUE_ATUAL, DES_ESTOQUE) values ( '{pNome}','{pObs}',{pQtd}, {i}, '{pEstoqueDes}') ";
                    SqlCommand oCmd = new SqlCommand(sCmd);
                    conectado.Open();
                    oCmd.Connection = conectado;
                    oCmd.ExecuteNonQuery();

                    conectado.Close();
                }
                MessageBox.Show("Registro gravado com sucesso!");

            }
            catch (Exception)
            {
                MessageBox.Show("Algo deu errado");                
            }
        }

        public SqlDataReader ComboEstoque()
        {
            try
            {
                string sCmd;
                Conexao = BancoDados();

                sCmd = "SELECT NOME FROM ESTOQUE WHERE ATIVO = 1";

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
                return leitor;
            }
        }

        public SqlConnection BancoDados()
        {
            SqlConnection conection = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Userwin\source\repos\HOWComBancoDiferente\DB_HOWTESTE.mdf;Integrated Security=True");
            return conection;
        }

        public int iAtivo(bool bCheck){ return 0; }

        private SqlDataReader PegaId(string pDesEstoque)
        {
            SqlConnection conectado = BancoDados();
            
            string sCmd = $"SELECT ID FROM ESTOQUE WHERE NOME = '{pDesEstoque}'";
            SqlCommand oCmd = new SqlCommand(sCmd);
            conectado.Open();
            oCmd.Connection = conectado;
            oCmd.ExecuteNonQuery();
            leitor = oCmd.ExecuteReader();
            return leitor;
            //conectado.Close();
                
            
        }
    }
}
