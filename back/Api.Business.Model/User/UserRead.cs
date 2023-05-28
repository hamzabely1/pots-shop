using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Api.Business.Model.User
{
    public class UserRead 
    {

        public string? LastName { get; set; }

        public string? FirstName { get; set; }

        public string? Email { get; set; }

        public string? Password { get; set; }

        public object Address { get; set; }
    }
}
