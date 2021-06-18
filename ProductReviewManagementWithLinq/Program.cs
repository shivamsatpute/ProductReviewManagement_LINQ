using System;
using System.Collections.Generic;
using System.Data;

namespace ProductReviewManagementWithLinq
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to product review management");

            //UC1
            List<ProductReview> productReviewList = new List<ProductReview>()
            {
                new ProductReview(){ProducID=1,UserID=1,Rating=2,Review="Good",isLike=true},
                new ProductReview(){ProducID=2,UserID=1,Rating=4,Review="Good",isLike=true},
                new ProductReview(){ProducID=3,UserID=1,Rating=5,Review="Good",isLike=true},
                new ProductReview(){ProducID=4,UserID=1,Rating=6,Review="Good",isLike=false},
                new ProductReview(){ProducID=5,UserID=1,Rating=2,Review="nice",isLike=true},
                new ProductReview(){ProducID=6,UserID=1,Rating=1,Review="bas",isLike=true},
                new ProductReview(){ProducID=8,UserID=1,Rating=10,Review="Good",isLike=false},
                new ProductReview(){ProducID=8,UserID=1,Rating=9,Review="nice",isLike=true},
                new ProductReview(){ProducID=2,UserID=1,Rating=10,Review="nice",isLike=true},
                new ProductReview(){ProducID=10,UserID=1,Rating=8,Review="nice",isLike=true},
                new ProductReview(){ProducID=11,UserID=1,Rating=3,Review="nice",isLike=true}

            };
            //UC 8
            foreach (var list in productReviewList)
            {
                Console.WriteLine("ProductID:- " + list.ProducID + " " + "UserID:- " + list.UserID
                    + " " + "Rating:- " + list.Rating + " " + "Review:- " + list.Review + " " + "isLike:- " + list.isLike);
            }

            //UC2
            Management management = new Management();
            // management.TopRecords(productReviewList);

            //UC3
            //  management.SelectedRecords(productReviewList);

            //UC4
            // management.RetrieveCountOfRecords(productReviewList);
            //UC5
            //  management.RetrieveProductIdAndReview(productReviewList);
            // UC6
            //  management.SkipTop_5_Records(productReviewList);
            // UC 9
            DataTable dataTable = management.AddToDataTable();
            management.RetrieveRecordsWhoLikeIsTrue(dataTable);
            // UC 11
            // management.RetrieveRecordsWhoReviewIsNice(productReviewList);
           
            Console.ReadKey();
        }

    }
}
