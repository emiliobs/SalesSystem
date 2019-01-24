using LinqToDB.Mapping;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    //[Table(Name="User")]
    public class User
    {
        [PrimaryKey, Identity]
        public int UsuarioId { get; set; }
        public string NumeroIdentidad { get; set; }
        public string FirstName { get; set; }
        public string LastName{ get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string Users { get; set; }
        public string Phone { get; set; }
        public string Role { get; set; }
        public string Date { get; set; }
       
    }
}
