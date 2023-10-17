using Microsoft.AspNetCore.Mvc;
using MySql.Data.MySqlClient;
using System.Data.Common;

namespace IskolaAPI.Controllers
{
    [Controller]
    public class DbController : Controller
    {
        public DbController()
        {
            try
            {
                var db = new MySqlConnection
                {
                    ConnectionString = "server=127.0.0.1;database=iskola"
                };
                db.Open();
                Console.WriteLine(db.State);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

        }
    }
}
