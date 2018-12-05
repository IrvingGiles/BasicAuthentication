using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using System.Threading.Tasks;



namespace WebAppBA.Models
{
    public class UserManager
    {
        private Database1Entities _Context;

        public UserManager()
        {
            _Context = new Database1Entities();
        }

        public bool ValidateUser(string userName, string Password)
        {
            var result =_Context.UserMasters.SingleOrDefault(x => x.UserName.Equals(userName, StringComparison.OrdinalIgnoreCase)
                                                                    && x.Password == Password);
            return result != null ? true : false;
        }

    }
}