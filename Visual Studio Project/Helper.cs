using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YM
{
    public enum UserType
    {
        admin, student, teacher
    }

    public class Helper
    {
        public static string connectionString = "Server=HOSTING_ADDRESS; Port=3306; Database=DATABASE_NAME; Uid=USER_ID; Pwd=PASSWORD;";
        public static string nickname = "admin";
        public static UserType userType;
        public static string selectedNickname;
    }
}