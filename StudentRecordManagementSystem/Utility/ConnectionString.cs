using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StudentRecordManagementSystem.Utility
{
    public static class ConnectionString
    {

        private static string cName = "Data Source=LAPTOP-FRAFK372\\SQLEXPRESS;Initial Catalog=StudentManagement;Integrated Security=True;";

        public static string CName { get => cName; }
    }
}
