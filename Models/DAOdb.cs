using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;
using System.IO;
using System.Data;

namespace TCC.Models
{
    public class DAOdb
    {
        public static string caminho = Directory.GetCurrentDirectory()+ "\\banco.sqlite";
        private static SQLiteConnection ConexaoSqlite;

        private static SQLiteConnection dbConexao()
        {
            SQLiteConnection conexaoSqlite = new SQLiteConnection("Data Source=" + caminho);
            conexaoSqlite.Open();    
            return conexaoSqlite;
                }
        public static void CriarBancoSqlite()
        {
            try
            {
                if(File.Exists(caminho) == false) {
                    SQLiteConnection.CreateFile(caminho);
                }
            }
            catch
            {
                throw;
            }

        }

      //  public static CriarTabelaSqlite()
       // {

        //}

    }
}
