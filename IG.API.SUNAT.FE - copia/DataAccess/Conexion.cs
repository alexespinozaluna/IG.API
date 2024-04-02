using System.Collections;
using System.Data;
using System.Data.SqlClient;

namespace IG.API.SUNAT.FE.DataAccess
{
    public class Conexion : IConexion 
    {
        private readonly string _connectionString = string.Empty;


        public Conexion(string connectionString)
        {

            _connectionString = connectionString;

        }

        public async Task<DataTable> getDataAsync(string sql)
        {
            //DataTable tb = new DataTable();

            //using (var connection = new SqlConnection(_connectionString))
            //{
            //     //connection.Open();

            //    using (var command = new SqlCommand(sql, connection))
            //    using (var reader = await command.ExecuteReaderAsync())
            //    {
            //        tb.Load(reader);
            //    }
            //}

            //return tb;


            DataTable tb = new DataTable();
            using (var da = new SqlDataAdapter(sql, _connectionString))
                da.Fill(tb);

            return tb;
        }

        public string getNamespaceData(string cod, string nom)
        {
            string data;
            try
            {
                using (var cnx = new SqlConnection(_connectionString))
                {
                    cnx.Open();
                    var cmd = new SqlCommand($"SELECT  {nom} FROM   SUNAT_FE_CLR_XML_EspacioNombre_Tag where codigo ='{cod}' ", cnx);
                    cmd.CommandType = CommandType.Text;
                    data = Convert.ToString(cmd.ExecuteScalar());
                    cmd.Dispose();
                    if (cnx.State == System.Data.ConnectionState.Open)
                        cnx.Close();
                    if (string.IsNullOrEmpty(data))
                        throw new ApplicationException($"Codigo: {cod} es Nulo en el campo {nom}");
                }
            }
            catch (Exception ex)
            {

                throw ex;
            }
            return data;

        }

        public async Task<string> getNamespaceDataAsync(string cod, string nom)
        {
            string data;

            try
            {
                using (var connection = new SqlConnection(_connectionString))
                {
                    await connection.OpenAsync();

                    var commandText = $"SELECT {nom} FROM SUNAT_FE_CLR_XML_EspacioNombre_Tag WHERE codigo = '{cod}'";

                    using (var command = new SqlCommand(commandText, connection))
                    {
                        command.CommandType = CommandType.Text;
                        var result = await command.ExecuteScalarAsync();

                        data = result != null ? result.ToString() : null;
                    }
                }

                if (string.IsNullOrEmpty(data))
                {
                    throw new ApplicationException($"Codigo: {cod} es Nulo en el campo {nom}");
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return data;
        }
        public int Insert(string sql, ArrayList sqlParametros)
        {


            int x = 0;
            try
            {
                using (SqlCommand cmd = new SqlCommand(sql, new SqlConnection(_connectionString)))
                {
                    if ((!(cmd.Connection.State == ConnectionState.Open)))
                    {
                        cmd.Connection.Open();
                    }

                    if ((sqlParametros != null))
                    {
                        int i = 0;
                        int inum = sqlParametros.Count - 1;
                        while ((i <= inum))
                        {
                            SqlParameter sq = (SqlParameter)sqlParametros[i];
                            cmd.Parameters.Add(sq);
                            i += 1;
                        }
                    }

                    x = Convert.ToInt32(cmd.ExecuteScalar());
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return x;

        }

        public async Task<int> InsertAsync(string sql, ArrayList sqlParametros)
        {
            int x = 0;
            //try
            //{
                using (SqlCommand cmd = new SqlCommand(sql, new SqlConnection(_connectionString)))
                {
                    if (!(cmd.Connection.State == ConnectionState.Open))
                    {
                        await cmd.Connection.OpenAsync();
                    }

                    if (sqlParametros != null)
                    {
                        int i = 0;
                        int inum = sqlParametros.Count - 1;

                        while (i <= inum)
                        {
                            SqlParameter sq = (SqlParameter)sqlParametros[i];
                        sq.Value = ToDB(sq.Value);
                            cmd.Parameters.Add(sq);
                            i += 1;
                        }
                    }

                    x = Convert.ToInt32(await cmd.ExecuteScalarAsync());
                }
            //}
            //catch (Exception ex)
            //{
            //    throw ex;
            //}

            return x;
        }
        public object ToDB<T>(T value)
        {
            return value == null ? (object)DBNull.Value : value;
        }

        public int UpdateTabla(string Sql, ArrayList sqlParametros)
        {
            int x = 0;
            try
            {
                using (SqlCommand cmd = new SqlCommand(Sql, new SqlConnection(_connectionString)))
                {
                    if ((!(cmd.Connection.State == ConnectionState.Open)))
                    {
                        cmd.Connection.Open();
                    }

                    if ((sqlParametros != null))
                    {
                        int i = 0;
                        int inum = sqlParametros.Count - 1;
                        while ((i <= inum))
                        {                            
                            SqlParameter sq = (SqlParameter)sqlParametros[i];
                            sq.Value = ToDB(sq.Value);
                            cmd.Parameters.Add(sq);
                            i += 1;
                        }
                    }

                    x = cmd.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return x;

        }
    }
}
