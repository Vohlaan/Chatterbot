using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Loginsystem
{
    class Data
    {
        private static string Username;

        public static string GetUsername() {
            return Username;
        }

        public static void SetUsername(string Value) {
            Username = Value;
        }
    }
}
