using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace E_Comm.App_Code
{
    //BO- business object
    public class Users
    {
        public int Id { get; set; }
        public string UserName { get; set; }
        public string  FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
    }
}