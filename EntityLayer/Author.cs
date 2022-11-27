using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer
{
    public class Author
    {
        // Atributos
        private int author_id;
        private string nickname;
        private string email;
        private string accountname;
        private string password;
        private string birthdate;
        private string country;

        // Propiedades
        public int Author_id { get => author_id; set => author_id = value; }
        public string Nickname { get => nickname; set => nickname = value; }
        public string Email { get => email; set => email = value; }
        public string Accountname { get => accountname; set => accountname = value; }
        public string Password { get => password; set => password = value; }
        public string Birthdate { get => birthdate; set => birthdate = value; }
        public string Country { get => country; set => country = value; }
    }
}
