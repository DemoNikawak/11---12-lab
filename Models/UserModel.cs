using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab9_WebDriver.Models
{
    public class UserModel
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Phone { get; set; }
        public string Password { get; set; }

        public UserModel()
        {
            Id = Guid.NewGuid();
        }
        public override string ToString()
        {
            return $"User: {Id}," +
                   $"Name: {Name}," +
                   $"Phone: {Phone}";

        }
    }
}
