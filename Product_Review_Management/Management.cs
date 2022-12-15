
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
            Console.WriteLine();
        }
        /// <summary>
        /// Selecteds the records.
        /// </summary>
        /// <param name="review">The review.</param>
        public void SelectedRecords(List<ProductReview> review)
        {
            var recordData = (from productReviews in review where productReviews.Rating > 3 && (productReviews.ProductID == 1 || productReviews.ProductID == 4 || productReviews.ProductID == 9) select productReviews);
            Console.WriteLine("************************** Selected Records **************************\n");
            foreach (ProductReview product in recordData)
            {
                Console.WriteLine("ProductID : " + product.ProductID + " UserID : " + product.UserID + " Rating : " + product.Rating + " Review : " + product.Review + " IsLike : " + product.IsLike);
            }
        }
        /// <summary>
        /// Counts the of review presen for each productID.
        /// </summary>
        /// <param name="review">The review.</param>
        public void CountOfReviewPresenForEachProductID(List<ProductReview> review)
        {
            //var recordData = review.GroupBy(u => u.ProductID).Select(u => new { ProductID = u.Key, Count = u.Count() });
            var recordData = (from productReviews in review group productReviews by productReviews.ProductID into product select new { ProductID = product.Key, Count = product.Count() });

            Console.WriteLine("************************** Count Of Review Presen For Each ProductID **************************\n");
            foreach (var product in recordData)
            {
                Console.WriteLine("Product Id : " + product.ProductID + "\tCount is : " + product.Count);
            }
            Console.WriteLine();
        }
        /// <summary>
        /// Retrives the only productID and review from all records UC-5 and UC-7.
        /// </summary>
        /// <param name="review">The review.</param>
        public void RetriveOnlyProductIdAndReviewFromAllRecords(List<ProductReview> review)
        {
            var recordData = (from productReviews in review select (productReviews.ProductID, productReviews.Review));
            Console.WriteLine("************************** ProductId And Review From All Records **************************\n");
            foreach (var product in recordData)
            {
                Console.WriteLine("ProductID : " + product.ProductID + " \tReview : " + product.Review);
            }
            Console.WriteLine();
        }
        /// <summary>
        /// Skips the top five records.
        /// </summary>
        /// <param name="review">The review.</param>
        public void SkipTopFiveRecords(List<ProductReview> review)
        {
            var recordData = (from productReviews in review orderby productReviews.Rating descending select productReviews).Skip(5);
            Console.WriteLine("************************** Top Records Skip (5) **************************\n");
            foreach (ProductReview product in recordData)
            {
                Console.WriteLine("ProductID : " + product.ProductID + " UserID : " + product.UserID + " Rating : " + product.Rating + " Review : " + product.Review + " IsLike : " + product.IsLike);
            }
            Console.WriteLine();
        }
    }
}
