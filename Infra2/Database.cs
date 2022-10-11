using System;
using System.Data.SqlClient;

namespace Infra2
{
    public static class Database
    {
        public static SqlConnectionStringBuilder connectionStringBuider = new SqlConnectionStringBuilder

        {
            DataSource = @"localhost",
            UserID = "BDSebrae",
            Password = "#password@",
            InitialCatalog = "BDSebrae"
        };

        public static SqlConnection open()
        {
            int nretrys = 0;
            int max_retrys = 3;

            SqlConnection _conexao = null;

            while (nretrys < max_retrys)
            {
                try
                {
                    _conexao = new SqlConnection(Database.connectionStringBuider.ConnectionString.ToString());
                    _conexao.Open();
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.ToString());
                    nretrys++;
                    System.Threading.Thread.Sleep(1000);
                }
            }

            return _conexao;

        }

    }
}
