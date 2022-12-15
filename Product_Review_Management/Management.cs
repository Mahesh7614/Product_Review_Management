
using System.Data;

namespace Product_Review_Management
{
    public class Management
    {
        public readonly DataTable dataTable = new DataTable();
        /// <summary>
        /// Tops the records.
        /// </summary>
        /// <param name="review">The list.</param>
        public void TopRecords(List<ProductReview> review)
        {
            var recordData = (from productReviews in review orderby productReviews.Rating descending select productReviews).Take(3);
            Console.WriteLine("************************** Top Records **************************\n");
            foreach (ProductReview product in recordData)
            {
                Console.WriteLine("ProductID : " + product.ProductID + " UserID : " + product.UserID + " Rating : " + product.Rating + " Review : " + product.Review + " IsLike : " + product.IsLike);
            }
        }
    }
}
