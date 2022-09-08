using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
   public class UserDTOO
    {
        public int Id { get; set; }
        public string FName { get; set; }
        public string LName { get; set; }
        public Nullable<int> Phone { get; set; }
        public string Email { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public Nullable<System.DateTime> BDate { get; set; }
        public string UserName { get; set; }
        public Nullable<bool> Status { get; set; }
        public Nullable<bool> AllowingAccess { get; set; }
        public string password { get; set; }
    }
}
