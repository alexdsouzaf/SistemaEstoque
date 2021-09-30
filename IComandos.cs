
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Facul
{
    interface IComandos
    {
        /// <summary>
        /// Método para SELECT 
        /// </summary>
        SqlDataReader consultar(string pWhere = "");

        /// <summary>
        /// Método para INSERT
        /// </summary>
        void gravar(string pNome, string pObs, int pAtivo = 0 , int pQtd = 0);

        /// <summary>
        /// Método para DELETE
        /// </summary>
        void deletar(string pWhere);

        /// <summary>
        /// Método para UPDATE
        /// </summary>
        void alterar(string pNome, string pObs, string pWhere, string pQtd = "", string pAtivo = "");

        /// <summary>
        /// Método para Conexão com Banco de Dados
        /// </summary>
        SqlConnection BancoDados();

        int iAtivo(bool bCheck); 
    }
}
