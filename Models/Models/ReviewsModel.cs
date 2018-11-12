using Models.EF;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.Models
{
    public class ReviewsModel
    {
        private NamiraDbContext context = null;

        public ReviewsModel()
        {
            context = new NamiraDbContext();
        }

        public List<vreviews> getReview(float productID)
        {
            object[] sqlParams =
            {
                new SqlParameter("@productID", productID),
            };
            var res = context.Database.SqlQuery<vreviews>("getReviews @productID", sqlParams).ToList();
            return res;

        }
    }
}
