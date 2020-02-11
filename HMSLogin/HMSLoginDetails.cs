using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HMSLogin
{
    class HMSLoginDetails
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Password { get; set; }
        public string Role { get; set; }

        public override string ToString()
        {
            string newline = Environment.NewLine;
            return $"Id: {Id} {newline}" +
                $"Name: {Name} {newline}" +
                $"Password: {Password} {newline}" +
                $"Role: {Role}";
        }
    }
}
