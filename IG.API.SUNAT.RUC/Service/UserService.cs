using IG.API.SUNAT.RUC.Model;
using System.Data;
using System.Data.SqlClient;

namespace IG.API.SUNAT.RUC.Service
{
    public class UserService
    {
        private readonly string _connectionString;
       public UserService(string connectionString)
        {
            _connectionString = connectionString;
        }
        public async Task<User> GetUserCredentialsAsync(string username)
        {
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                await connection.OpenAsync();

                using (SqlCommand command = new SqlCommand("SELECT cod_usuario, password, nivel as Rol FROM tab_usuarios WHERE cod_usuario = @Username", connection))
                {
                    command.Parameters.Add("@Username", SqlDbType.VarChar).Value = username;

                    using (SqlDataReader reader = await command.ExecuteReaderAsync())
                    {
                        if (await reader.ReadAsync())
                        {
                            User usuario = new User
                            {
                                Cod = reader.GetString(0),
                                Password = reader.GetString(1)
                            };
                            return usuario;
                        }
                    }
                }
            }

            return null;
        }

    }
}
