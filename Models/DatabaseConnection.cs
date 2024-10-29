using System.Data.SqlClient;

public static class DatabaseConnection
{

    // String de conexão centralizada
    private static readonly string connectionString = @"Server=DESKTOP-VQFPMN5; Database=tcc; Integrated Security=true;";

    // Método para obter uma nova conexão
    public static SqlConnection GetConnection()
    {
        return new SqlConnection(connectionString);
    }
}
