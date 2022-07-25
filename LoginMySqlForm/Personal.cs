using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoginMySqlForm
{
    public class Personal
    {
        private int id;
        private string username;
        private string password;
        private string email;
        private string firstName;
        private string lastName;

        public Personal(int id, string username, string password, string email, string firstName, string lastName)
        {
            this.id = id;
            this.username = username;
            this.password = password;
            this.email = email;
            this.firstName = firstName;
            this.lastName = lastName;
        }

        public int ID { get { return id; } private set { id = value; } }
        public string Username { get { return username; } private set { username = value; } }
        public string Password { get { return password; } private set { password = value; } }
        public string Email { get { return email; } private set { email = value; } }
        public string Firstname { get { return firstName; } private set { firstName = value; } }
        public string Lastname { get { return lastName; } private set { lastName = value; } }
    }
}
