namespace Product_Review_Management
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("************************ Welcome to Product review management problem statement ************************\n");

            List<ProductReview> productReviewList = new List<ProductReview>()
            {
                new ProductReview() { ProductID = 1, UserID = 1, Rating = 5, Review = "Good", IsLike = true },
                new ProductReview() { ProductID = 2, UserID = 1, Rating = 4, Review = "Good", IsLike = true },
                new ProductReview() { ProductID = 3, UserID = 2, Rating = 5, Review = "Good", IsLike = true },
                new ProductReview() { ProductID = 4, UserID = 2, Rating = 4, Review = "Good", IsLike = true },
                new ProductReview() { ProductID = 5, UserID = 3, Rating = 2, Review = "nice", IsLike = false },
                new ProductReview() { ProductID = 6, UserID = 4, Rating = 1, Review = "Bad", IsLike = false },
                new ProductReview() { ProductID = 1, UserID = 3, Rating = 3.8, Review = "nice", IsLike = false },
                new ProductReview() { ProductID = 11, UserID = 10, Rating = 4, Review = "nice", IsLike = true },
                new ProductReview() { ProductID = 9, UserID = 10, Rating = 4, Review = "nice", IsLike = true },
                new ProductReview() { ProductID = 13, UserID = 10, Rating = 4, Review = "nice", IsLike = true },
                new ProductReview() { ProductID = 14, UserID = 10, Rating = 4, Review = "nice", IsLike = true },
                new ProductReview() { ProductID = 15, UserID = 10, Rating = 4, Review = "nice", IsLike = false },
                new ProductReview() { ProductID = 16, UserID = 11, Rating = 5, Review = "nice", IsLike = true },
                new ProductReview() { ProductID = 16, UserID = 11, Rating = 4.3, Review = "Good", IsLike = true },
                new ProductReview() { ProductID = 17, UserID = 11, Rating = 4.3, Review = "nice", IsLike = false },
                new ProductReview() { ProductID = 18, UserID = 12, Rating = 4.5, Review = "Bad", IsLike = true },
                new ProductReview() { ProductID = 17, UserID = 13, Rating = 4.1, Review = "Good", IsLike = true },
                new ProductReview() { ProductID = 18, UserID = 14, Rating = 3.2, Review = "nice", IsLike = false },
                new ProductReview() { ProductID = 19, UserID = 15, Rating = 2.5, Review = "Bad", IsLike = true },
                new ProductReview() { ProductID = 20, UserID = 15, Rating = 3.5, Review = "Good", IsLike = true },
                new ProductReview() { ProductID = 9, UserID = 16, Rating = 4.8, Review = "Bad", IsLike = false },
                new ProductReview() { ProductID = 22, UserID = 17, Rating = 4.5, Review = "Good", IsLike = true },
                new ProductReview() { ProductID = 23, UserID = 18, Rating = 4.4, Review = "Bad", IsLike = true },
                new ProductReview() { ProductID = 25, UserID = 19, Rating = 2.8, Review = "Good", IsLike = false },
                new ProductReview() { ProductID = 23, UserID = 17, Rating = 3, Review = "Bad", IsLike = true },

            };
            foreach (ProductReview product in productReviewList)
            {
                Console.WriteLine("ProductID : " + product.ProductID + " UserID : " + product.UserID + " Rating : " + product.Rating + " Review : " + product.Review + " IsLike : " + product.IsLike);
            }

            Management management= new Management();
            management.TopRecords(productReviewList);
            management.SelectedRecords(productReviewList);
            management.CountOfReviewPresenForEachProductID(productReviewList);
            management.RetriveOnlyProductIdAndReviewFromAllRecords(productReviewList);
            management.SkipTopFiveRecords(productReviewList);
            management.CreateProductReviewTable(productReviewList);
            management.AverageRatingForEachProductID(productReviewList);
        }
    }
}