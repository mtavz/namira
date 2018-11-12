using Models.EF;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.Models
{
    public class AccountModel
    {
        private NamiraDbContext context = null;

        public AccountModel()
        {
            context = new NamiraDbContext();
        }

        public bool Login(string username, string pass)
        {
            object[] sqlParams =
          {
                new SqlParameter("@userName", username),
                new SqlParameter("@pass", pass),
            };
            var res = context.Database.SqlQuery<bool>("namiraLogin @userName, @pass", sqlParams).SingleOrDefault();
            return res;
        }

    }
}
