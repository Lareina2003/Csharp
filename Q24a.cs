using System;
using System.Data.SqlClient;

class Program
{
    static void Main()
    {
        // 1️⃣ Connection string – make sure Database=DemoDB
        string connectionString = "Server=PSILENL103;Database=DemoDB;Trusted_Connection=True;";

        // 2️⃣ SQL query – use dbo.Products
        string query = "SELECT Id, Name, Price FROM dbo.Products";

        using (SqlConnection connection = new SqlConnection(connectionString))
        {
            try
            {
                connection.Open();
                Console.WriteLine("Connected to database successfully!");

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        Console.WriteLine("Products:");
                        while (reader.Read())
                        {
                            int id = reader.GetInt32(0);
                            string name = reader.GetString(1);
                            decimal price = reader.GetDecimal(2);

                            Console.WriteLine($"Id: {id}, Name: {name}, Price: {price:C}");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }
        }
    }
}
