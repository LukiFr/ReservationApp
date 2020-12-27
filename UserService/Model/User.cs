using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace UserService.Model
{
    public class User
    {
        public int id { get; set; }

        public string first_name { get; set; }

        public string last_name { get; set; }

        public string age { get; set; }

        public string email_adress { get; set; }

        public string password { get; set; }

    }
}
