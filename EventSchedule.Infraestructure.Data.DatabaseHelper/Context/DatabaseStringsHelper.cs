using System;
using System.Collections.Generic;
using System.Text;

namespace EventSchedule.Infraestructure.Data.DatabaseHelper.Context
{
    public class DatabaseStringsHelper
    {
        public string MysqlConnection { get; set; }

        public DatabaseStringsHelper()
        {
            MysqlConnection = "Server=localhost; database=customer; UID=root; password=root; Port=8889; SslMode=none";
        }
    }
}
