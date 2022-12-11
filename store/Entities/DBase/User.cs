using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel.DataAnnotations;
using System.Threading.Tasks;

namespace store.Entities.DBase
{
    public class User : BaseEntity
    {
        public string UserName { get; set; } = null!;
        public string UserSurname { get; set; } = null!;
        public string? UserSecondname { get; set; }
        public DateTime Birthday { get; set; } 
        public string Email { get; set; } = null!;
        public string Password { get; set; } = null!;
        public string Phone { get; set; } = null!;
        public string City { get; set; } = null!;
        public string Street { get; set; } = null!;
    }
}
