﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace InventorySystem
{
    class database
    {
        public MySqlConnection adminn;
        public MySqlDataReader admin1;
        public MySqlCommand admin2;

        public void Connect()
        {
            adminn = new MySqlConnection("server=127.0.0.1;user=root;database=berbs");
            adminn.Open();
        }
        public void Disconnect()
        {
            if (adminn.State == System.Data.ConnectionState.Open)
            {
                adminn.Close();
                adminn.Dispose();

            }
        }
    }
}