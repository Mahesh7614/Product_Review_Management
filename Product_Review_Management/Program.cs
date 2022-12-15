namespace Product_Review_Management
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Product review management problem statement");

            List<ProductReview> productReviewList = new List<ProductReview>()
            {
                new ProductReview() { ProductID = 1, UserID = 1, Rating = 5, Review = "Good", IsLike = true },
                new ProductReview() { ProductID = 2, UserID = 1, Rating = 4, Review = "Good", IsLike = true },
                new ProductReview() { ProductID = 3, UserID = 2, Rating = 5, Review = "Good", IsLike = true },
                new ProductReview() { ProductID = 4, UserID = 2, Rating = 4, Review = "Good", IsLike = true },
                new ProductReview() { ProductID = 5, UserID = 3, Rating = 2, Review = "nice", IsLike = false },
                new ProductReview() { ProductID = 6, UserID = 4, Rating = 1, Review = "Bad", IsLike = false },
                new ProductReview() { ProductID = 1, UserID = 3, Rating = 1.5, Review = "nice", IsLike = false },
                new ProductReview() { ProductID = 11, UserID = 10, Rating = 4, Review = "nice", IsLike = true },
                new ProductReview() { ProductID = 12, UserID = 10, Rating = 4, Review = "nice", IsLike = true },
                new ProductReview() { ProductID = 13, UserID = 10, Rating = 4, Review = "nice", IsLike = true },
                new ProductReview() { ProductID = 14, UserID = 10, Rating = 4, Review = "nice", IsLike = true },
                new ProductReview() { ProductID = 15, UserID = 10, Rating = 4, Review = "nice", IsLike = true }

            };
            foreach (ProductReview product in productReviewList)
            {
                Console.WriteLine("ProductID : " + product.ProductID + " UserID : " + product.UserID + " Rating : " + product.Rating + " Review : " + product.Review + " IsLike : " + product.IsLike);
            }
        }
    }
}