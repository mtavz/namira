using Models.EF;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.Models
{
    public class ProductModel
    {
        private NamiraDbContext context = null;

        public ProductModel()
        {
            context = new NamiraDbContext();
        }

        public void AddCart(float productID, float number, float userID)
        {
            object[] sqlParams =
           {
                new SqlParameter("@productvariantID", productID),
                new SqlParameter("@userID", number),
                new SqlParameter("@number", userID),

            };
            context.Database.ExecuteSqlCommand(sql: "add_item_to_cart @productvariantID, @userID, @number", parameters: sqlParams);
        }

        public List<vproducts> getLatest()
        {
            var latestList = context.Database.SqlQuery<vproducts>(sql: "getLatest").ToList();
            return latestList;
        }


      
        public List<vproduct> getDetail (float productID)
        {
            object[] sqlParams =
            {
                new SqlParameter("@productID", productID),
            };

            var res = context.Database.SqlQuery<vproduct>("getProductDetail @productID", sqlParams).ToList();
            return res;
        }

        public List<products> getProduct(float productID)
        {
            object[] sqlParams =
            {
                new SqlParameter("@productID", productID),
            };

            var res = context.Database.SqlQuery<products>("getProduct @productID", sqlParams).ToList();
            return res;
        }

    }
}
