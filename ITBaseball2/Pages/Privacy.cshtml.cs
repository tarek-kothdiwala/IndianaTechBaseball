using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Data.SqlClient;

namespace ITBaseball2.Pages
{
    public class PrivacyModel : PageModel
    {
        public List<ClientInfo> listClients = new List<ClientInfo>();
        public void OnGet()
        {
            try
            {
                string connectionString = "Data Source=itbaseballserver.database.windows.net;Initial Catalog=ITBaseball2;User ID=tarekk13;Password=Lefty.pitcher13";
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    string sql = "SELECT * FROM dbo.clients";
                    using (SqlCommand command = new SqlCommand(sql, connection))
                    {
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                ClientInfo client = new ClientInfo();
                                client.id = reader.GetInt32(0);
                                client.player = reader.GetString(1);
                                client.era = reader.GetDecimal(2);
                                client.ip = reader.GetDecimal(3);
                                client.h = reader.GetInt32(4);
                                client.r = reader.GetInt32(5);
                                client.er = reader.GetInt32(6);
                                client.bb = reader.GetInt32(7);
                                client.so = reader.GetInt32(8);

                                listClients.Add(client); 
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {

            }
        }
    }

    public class ClientInfo
    {
        public int id;
        public string? player;
        public decimal? era;
        public decimal? ip;
        public int? h;
        public int? r;
        public int? er;
        public int? bb;
        public int? so;
    }
}