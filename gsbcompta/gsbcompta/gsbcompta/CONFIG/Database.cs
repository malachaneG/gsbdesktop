using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace gsbcompta
{
    class Database
    {
        public MySqlConnection Mysql { get; set; }

        public Database()
        {
            this.connect();
        }

        private void connect()
        {
            string connectionString = "SERVER=cj654063-002.dbaas.ovh.net; PORT=35305; DATABASE=gsbmalachane; UID=gsbmalachane; PASSWORD=gsbmalachaneSU2020";
            this.Mysql = new MySqlConnection(connectionString);
        }
    }
}
