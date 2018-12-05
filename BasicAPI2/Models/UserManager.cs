using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Text;

namespace BasicAPI2.Models
{
    public class UserManager
    {
        private UserContext _Context;

        public UserManager()
        {
            _Context = new UserContext();
        }

        public bool ValidateUser(string userName, string password)

        {
            var result = _Context.UserMasters.SingleOrDefault(x => x.UserName.Equals(userName, StringComparison.OrdinalIgnoreCase) && x.Password == password);
            return result != null ? true : false;
        }
    }
}