using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;


namespace HOWComBancoDiferente
{
    public partial class Form1 : Form
    {
        public string strConn;
        public SqlConnection conn;
        public Form1()
        {
            InitializeComponent();
            strConn = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Userwin\source\repos\HOWComBancoDiferente\DB_HOWTESTE.mdf;Integrated Security=True";            
        }


        private SqlConnection banco()
        {
            SqlConnection conn = new SqlConnection(strConn);
            return conn;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection conectado = banco();
            conectado.Open();

            string sCmd = "INSERT INTO PRODUTO (ID,NOME,OBS,QUANTIDADE) values ( 1,'alex','teste',1) ";
            SqlCommand comando = new SqlCommand(sCmd);
            comando.Connection = conectado;
            comando.ExecuteNonQuery();
        }
    }
}
