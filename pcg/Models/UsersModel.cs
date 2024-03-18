using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;

namespace pcg.Models
{
    public class UsersModel
    {
        public string Username { get; set; }
        public string Usernamecheck { get; set; }        
        public string Password { get; set; }
        public string Confirm { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Position { get; set; }
        public string ContactNo{ get; set; }
    }
    public class Login
    {

        public string Username { get; set; }

        public string Password { get; set; }
    }
    public class ChangeInfo
    {
        public string Name { get; set; }
        public string Password { get; set;}
        public string Confirm { get; set; }
        public string Email { get; set;}
        public string ContactNo { get; set; }
        public string CurName { get; set; }
        public string CurPass { get; set; }
        public string CurEmail { get; set; }
        public string CurContact { get; set; }
    }
}
