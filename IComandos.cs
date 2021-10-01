
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
        /// <param name="pWhere"></param>
        /// <returns></returns>
        SqlDataReader consultar(string pWhere = "");

        /// <summary>
        /// Método para INSERT
        /// </summary>
        /// <param name="pNome"></param>
        /// <param name="pObs"></param>
        /// <param name="pAtivo"></param>
        /// <param name="pQtd"></param>
        void gravar(string pNome, string pObs, int pAtivo = 0 , int pQtd = 0);

        /// <summary>
        /// Método para DELETE
        /// </summary>
        /// <param name="pWhere"></param>
        void deletar(string pWhere);

        /// <summary>
        /// Método para UPDATE
        /// </summary>
        /// <param name="pNome"></param>
        /// <param name="pObs"></param>
        /// <param name="pWhere"></param>
        /// <param name="pQtd"></param>
        /// <param name="pAtivo"></param>
        void alterar(string pNome, string pObs, string pWhere, string pQtd = "", string pAtivo = "");

        /// <summary>
        /// Método para Conexão com Banco de Dados
        /// </summary>
        SqlConnection BancoDados();

        /// <summary>
        /// Vai tratar o 0 e 1 do banco para false e true 
        /// </summary>
        /// <param name="bCheck"></param>
        /// <returns></returns>
        int iAtivo(bool bCheck); 
    }
}
