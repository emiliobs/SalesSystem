using LinqToDB;
using LinqToDB.Data;
using LinqToDB.DataProvider.MySql;
using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Connection
{
    public class Connections : DataConnection
    {
        public Connections() : base(new MySqlDataProvider(),
            "Server=localhost;port=3306;Database=SalesSystemDB;Uid=root;Pwd='Eabs123.';charset=utf8;SslMode=none")
        {

        }
        //public Connections() : base(new LinqToDB.DataProvider.SqlServer.SqlServerDataProvider("", LinqToDB.DataProvider.SqlServer.SqlServerVersion.v2012), 
        //    "Data Source =.; Database=SalesSystemDB; Integrated Security=True;")
        //{

        //}

        public ITable<User> Users => GetTable<User>();
    }
}
