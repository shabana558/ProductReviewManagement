using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductReviewManagement
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Product Review Management");
            Console.WriteLine("Adding a Product Review In list");
            Console.WriteLine("Enter Option");
            int option = Convert.ToInt32(Console.ReadLine());
            //Creating a list for Product Review
            List<ProductReview> productReviews = new List<ProductReview>();
            switch (option)
            {
                case 1:
                    ProductReviewManager.AddingProductReview(productReviews);
                    break;
                case 2:
                    ProductReviewManager.RetrieveTopThreeRating(productReviews);
                    break;
                case 3:
                    ProductReviewManager.RetrieveRecordsBasedOnRatingAndProductId(productReviews);
                    break;

                case 4:
                    ProductReviewManager.CountingProductId(productReviews);
                    break;
                case 5:
                    ProductReviewManager.RetrieveOnlyProductIdAndReviews(productReviews);
                    break;
                case 6:
                    ProductReviewManager.SkipTopFiveRecords(productReviews);
                    break;
                case 7:
                    ProductReviewManager.RetrieveOnlyProductIdAndReviews(productReviews);
                    break;
                case 8:
                    ProductReviewManager.AddingProductReview(productReviews);
                    ProductReviewManager.CreateDataTable(productReviews);
                    break;
                case 9:
                    ProductReviewManager.CreateDataTable(productReviews);
                    break;
                case 10:
                    ProductReviewManager.CreateDataTable(productReviews);
                    ProductReviewManager.AverageOfRating();
                    break;
                case 11:
                    ProductReviewManager.ReturnsReviewMessageContainsGood();
                    break;
            }
        }
    }
}
