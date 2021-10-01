
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Facul
{
    class ClsEstoque : IComandos        
    {
        public SqlConnection Conexao { get; set; }

        SqlDataReader leitor;

        public void alterar(string pNome, string pObs, string pWhere, string pQtd = "", string pAtivo = "")
        {
            try
            {
                using (SqlConnection conectado = BancoDados())
                {
                    
                    string sCmd = $"UPDATE ESTOQUE SET NOME = '{pNome}', OBS = '{pObs}', ATIVO = {pAtivo} WHERE ID = {pWhere}";
                    SqlCommand oCmd = new SqlCommand(sCmd);
                    conectado.Open();
                    oCmd.Connection = conectado;
                    oCmd.ExecuteNonQuery();

                    conectado.Close();
                }
                //return leitor;
                MessageBox.Show("Registro alterado com sucesso!");
            }
            catch (Exception)
            {
                MessageBox.Show("Algo deu errado");
                //throw;
            }
        }

        public SqlDataReader consultar(string pWhere = "")
        {
            try
            {
                string sCmd;
                Conexao = BancoDados();

                if (pWhere != string.Empty)
                    sCmd = $"SELECT * FROM ESTOQUE WHERE ID = {pWhere}";
                else
                    sCmd = "SELECT * FROM ESTOQUE";

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

        }

        public void deletar(string pWhere)
        {
            try
            {
                using (SqlConnection conectado = BancoDados())
                {

                    string sCmd = $"DELETE FROM ESTOQUE WHERE ID = {pWhere}";
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
                //throw;
            }
            
            //return leitor;
        }

        public void gravar(string pNome, string pObs, int pAtivo, int pQtd = 0)
        {
            try
            {
                using (SqlConnection conectado = BancoDados())
                {
                    
                    string sCmd = $"INSERT INTO ESTOQUE (NOME,OBS,ATIVO) values ('{pNome}','{pObs}',{pAtivo}) ";
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

        public  SqlConnection BancoDados()
        {
            SqlConnection conection = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Userwin\source\repos\HOWComBancoDiferente\DB_HOWTESTE.mdf;Integrated Security=True") ;

            return conection;
        }

        public int iAtivo(bool bCheck)
        {
            int iAtivo = 0;

            if (bCheck)
                iAtivo = 1;

            return iAtivo;
        }
    }
}
