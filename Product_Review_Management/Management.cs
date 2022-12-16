
using System.Data;

namespace Product_Review_Management
{
    public class Management
    {
        public readonly DataTable dataTable = new DataTable("Product Review");

        /// <summary>
        /// Top records.
        /// </summary>
        /// <param name="review">The list.</param>
        public void TopRecords(List<ProductReview> review)
        {
            var recordData = (from productReviews in review orderby productReviews.Rating descending select productReviews).Take(3);
            Console.WriteLine("\n************************** Top Records **************************\n");
            foreach (ProductReview product in recordData)
            {
                Console.WriteLine("ProductID : " + product.ProductID + " UserID : " + product.UserID + " Rating : " + product.Rating + " Review : " + product.Review + " IsLike : " + product.IsLike);
            }
            Console.WriteLine();
        }
        /// <summary>
        /// Selected records.
        /// </summary>
        /// <param name="review">The review.</param>
        public void SelectedRecords(List<ProductReview> review)
        {
            var recordData = (from productReviews in review where productReviews.Rating > 3 && (productReviews.ProductID == 1 || productReviews.ProductID == 4 || productReviews.ProductID == 9) select productReviews);
            Console.WriteLine("\n************************** Selected Records **************************\n");
            foreach (ProductReview product in recordData)
            {
                Console.WriteLine("ProductID : " + product.ProductID + " UserID : " + product.UserID + " Rating : " + product.Rating + " Review : " + product.Review + " IsLike : " + product.IsLike);
            }
        }
        /// <summary>
        /// Count of review presen for each productID.
        /// </summary>
        /// <param name="review">The review.</param>
        public void CountOfReviewPresenForEachProductID(List<ProductReview> review)
        {
            //var recordData = review.GroupBy(u => u.ProductID).Select(u => new { ProductID = u.Key, Count = u.Count() });
            var recordData = (from productReviews in review group productReviews by productReviews.ProductID into product select new { ProductID = product.Key, Count = product.Count() });

            Console.WriteLine("\n************************** Count Of Review Presen For Each ProductID **************************\n");
            foreach (var product in recordData)
            {
                Console.WriteLine("Product Id : " + product.ProductID + "\tCount is : " + product.Count);
            }
        }
        /// <summary>
        /// Retrive only productID and review from all records UC-5 and UC-7.
        /// </summary>
        /// <param name="review">The review.</param>
        public void RetriveOnlyProductIdAndReviewFromAllRecords(List<ProductReview> review)
        {
            var recordData = (from productReviews in review select (productReviews.ProductID, productReviews.Review));
            Console.WriteLine("\n************************** ProductId And Review From All Records **************************\n");
            foreach (var product in recordData)
            {
                Console.WriteLine("ProductID : " + product.ProductID + " \tReview : " + product.Review);
            }
        }
        /// <summary>
        /// Skip top five records.
        /// </summary>
        /// <param name="review">The review.</param>
        public void SkipTopFiveRecords(List<ProductReview> review)
        {
            List<ProductReview> recordData = (from productReviews in review orderby productReviews.Rating descending select productReviews).Skip(5).ToList();
            Console.WriteLine("\n************************** Top Records Skip (5) **************************\n");
            foreach (ProductReview product in recordData)
            {
                Console.WriteLine("ProductID : " + product.ProductID + " UserID : " + product.UserID + " Rating : " + product.Rating + " Review : " + product.Review + " IsLike : " + product.IsLike);
            }
        }
        /// <summary>
        /// Create Product Review Table
        /// </summary>
        /// <param name="review"></param>
        public void CreateProductReviewTable(List<ProductReview> review)
        {
            dataTable.Columns.Add("ProductID", typeof(Int32));
            dataTable.Columns.Add("UserID", typeof(Int32));
            dataTable.Columns.Add("Rating", typeof(double));
            dataTable.Columns.Add("Review", typeof(string));
            dataTable.Columns.Add("IsLike", typeof(bool));
            Console.WriteLine("\n************************** Data Table Product Review **************************\n");
            foreach (ProductReview product in review)
            {
                dataTable.Rows.Add(product.ProductID, product.UserID, product.Rating, product.Review, product.IsLike);
            }
            foreach (DataRow dataRow in dataTable.Rows)
            {
                Console.WriteLine("ProductID : " + dataRow[0] + " UserID : " + dataRow[1] + " Rating : " + dataRow[2] + " Review : " + dataRow[3] + " IsLike : " + dataRow[4]);
            }
        }
        /// <summary>
        /// Average Rating For Each ProductID
        /// </summary>
        /// <param name="review"></param>
        public void AverageRatingForEachProductID(List<ProductReview> review)
        {
            var recordData = (from productReviews in review group productReviews by (productReviews.ProductID) into product select new { ProductID = product.Key, AverageRating = product.Average(Key => Key.Rating) });
            //var recordData = (review.GroupBy(g => g.ProductID).Select(s=> new { ProductID = s.Key ,Rating = s.Average(Key => Key.Rating)}));
            Console.WriteLine("\n************************** Average Rating For Each ProductID **************************\n");
            foreach (var product in recordData)
            {
                Console.WriteLine("ProductID : " + product.ProductID + " \tAvergae Rating : " + product.AverageRating);
            }
        }
        /// <summary>
        /// All Records From List Whose Review Contains 'nice'
        /// </summary>
        /// <param name="review"></param>
        public void Retrive_AllRecords_FromList_Whose_Review_Contains_nice(List<ProductReview> review)
        {
            var recordData = (from productReviews in review where productReviews.Review.Contains("nice") select productReviews);
            Console.WriteLine("\n************************** All Records From List Whose Review Contains 'nice' **************************\n");
            foreach (ProductReview product in recordData)
            {
                Console.WriteLine("ProductID : " + product.ProductID + " UserID : " + product.UserID + " Rating : " + product.Rating + " Review : " + product.Review + " IsLike : " + product.IsLike);
            }
        }
        /// <summary>
        /// All Records From List Whose UserId = 10 and order By Rating
        /// </summary>
        /// <param name="review"></param>
        public void Retrive_AllRecords_FromList_Whose_UserID_10_And_OrderBy_Rating(List<ProductReview> review)
        {
            var recordData = (from productReviews in review orderby productReviews.Rating descending where productReviews.UserID == 10  select productReviews);
            Console.WriteLine("\n************************** All Records From List Whose UserId = 10 and order By Rating **************************\n");
            foreach (ProductReview product in recordData)
            {
                Console.WriteLine("ProductID : " + product.ProductID + " UserID : " + product.UserID + " Rating : " + product.Rating + " Review : " + product.Review + " IsLike : " + product.IsLike);
            }
        }
    }
}
