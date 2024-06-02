using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4
{
    public static class User
    {
        //metody get i set dla każdego z pól
        public static int Id { get; set; }
        public static string Firstname { get; set; } = string.Empty;
        public static string Lastname { get; set; } = string.Empty;
        public static string Email { get; set; } = string.Empty;
        public static string Login { get; set; } = string.Empty;
        public static string Password { get; set; } = string.Empty;
        public static byte IsAdmin { get; set; } = 0;
        public static int FailedLoginCounter { get; set; } = 0;
    }

}
