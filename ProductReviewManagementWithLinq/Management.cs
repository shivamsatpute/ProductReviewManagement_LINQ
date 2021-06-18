using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace ProductReviewManagementWithLinq
{
    class Management
    {
        // public readonly DataTable dataTable = new DataTable();
        public void TopRecords(List<ProductReview> listProductReview)
        {
            var recordedData = (from productReviews in listProductReview
                                orderby productReviews.Rating descending
                                select productReviews).Take(3);

            foreach (var list in recordedData)
            {
                Console.WriteLine("ProductID:- " + list.ProducID + " " + "UserID:- " + list.UserID
                    + " " + "Rating:- " + list.Rating + " " + "Review:- " + list.Review + " " + "isLike:- " + list.isLike);
            }

        }

        public void SelectedRecords(List<ProductReview> listProductReview)
        {
            var recordedData = from productReviews in listProductReview
                               where (productReviews.ProducID == 1 || productReviews.ProducID == 4 || productReviews.ProducID == 9)
                               && productReviews.Rating > 3
                               select productReviews;
            Console.WriteLine(recordedData);
            foreach (var list in recordedData)
            {
                Console.WriteLine("ProductID:- " + list.ProducID + " " + "UserID:- " + list.UserID
                    + " " + "Rating:- " + list.Rating + " " + "Review:- " + list.Review + " " + "isLike:- " + list.isLike);
            }

        }

        public void RetrieveCountOfRecords(List<ProductReview> listProductReview)
        {
            var recordedData = listProductReview.GroupBy(y => y.ProducID).Select(x => new { ProductID = x.Key, Count = x.Count() });


            foreach (var list in recordedData)
            {
                Console.WriteLine(list.ProductID + "--------" + list.Count);

            }
        }

        public void RetrieveProductIdAndReview(List<ProductReview> listProductReview)
        {
            var recordedData = from productReviews in listProductReview
                               select productReviews;
            Console.WriteLine(recordedData);
            foreach (var list in recordedData)
            {
                Console.WriteLine("ProductID:- " + list.ProducID + " " + "Review:- " + list.Review);
            }
        }
        public void SkipTop_5_Records(List<ProductReview> listProductReview)
        {
            var recordedData = (from productReviews in listProductReview
                                orderby productReviews.Rating descending
                                select productReviews).Skip(5);

            foreach (var list in recordedData)
            {
                Console.WriteLine("ProductID:- " + list.ProducID + " " + "UserID:- " + list.UserID
                    + " " + "Rating:- " + list.Rating + " " + "Review:- " + list.Review + " " + "isLike:- " + list.isLike);
            }
        }
            public void RetrieveRecordsWhoLikeIsTrue(DataTable table)
            {
            var recordedData = table.AsEnumerable().Where(x => x.Field<string>("isLike") == "true");
            foreach (var record in recordedData)
                {
                    Console.WriteLine("ProductId:- " + record.Field<Int32>("ProductId") + " " + "UserId:- " + record.Field<Int32>("UserId")
                        + " " + "Rating:- " + record.Field<Int32>("Rating") + " " + "Review:- " + record.Field<string>("Review") + " " + "isLike:- " + record.Field<string>("isLike"));
                }
            }
        public void RetrieveRecordsWhoReviewIsNice(List<ProductReview> listProductReview)
        {
            var recordedData = from productReviews in listProductReview
                               where (productReviews.Review == "nice")
                               select productReviews;
            Console.WriteLine(recordedData);
            foreach (var list in recordedData)
            {
                Console.WriteLine("ProductID:- " + list.ProducID + " " + "UserID:- " + list.UserID
                    + " " + "Rating:- " + list.Rating + " " + "Review:- " + list.Review + " " + "isLike:- " + list.isLike);
            }
        }

        public DataTable AddToDataTable()
        {
            DataTable table = new DataTable(); 
            table.Columns.Add("ProductId", typeof(Int32)); 
            table.Columns.Add("UserId", typeof(Int32)); 
            table.Columns.Add("Rating", typeof(Int32));
            table.Columns.Add("Review", typeof(string));
            table.Columns.Add("isLike", typeof(string));


            table.Rows.Add(1, 1, 4, "Average", "true"); 
            table.Rows.Add(1, 2, 2, "Bad", "false");
            table.Rows.Add(3, 3, 4, "Nice", "true"); 
            table.Rows.Add(4, 4, 5, "Good", "false"); 
            table.Rows.Add(5, 5, 6, "Excelent", "false"); 
            table.Rows.Add(6, 10, 4, "Nice", "true"); 
            table.Rows.Add(7, 6, 3, "Average", "true"); 
            table.Rows.Add(8, 5, 2, "Bad", "true"); 
            table.Rows.Add(9, 10, 5, "Good", "true"); 
            table.Rows.Add(10, 41, 6, "Excelent", "false"); 
            table.Rows.Add(11, 5, 4, "Nice", "false"); 
            table.Rows.Add(12, 4, 1, "Very Bad", "true"); 
            table.Rows.Add(13, 48, 0, "Excelent", "false"); 
            table.Rows.Add(14, 41, 3, "Average", "true"); 
            table.Rows.Add(15, 51, 4, "Nice", "true"); 
            table.Rows.Add(16, 8, 1, "Very Bad", "false"); 
            table.Rows.Add(17, 18, 6, "Excelent", "true"); 
            table.Rows.Add(18, 9, 5, "Good", "true"); 
            table.Rows.Add(19, 10, 4, "Nice", "false"); 
            table.Rows.Add(20, 7, 3, "Average", "true"); 
            table.Rows.Add(21, 6, 2, "Bad", "true"); 
            table.Rows.Add(22, 5, 1, "Very Bad", "false"); 
            table.Rows.Add(23, 10, 5, "Good", "false"); 
            table.Rows.Add(24, 8, 2, "Bad", "true"); 
            table.Rows.Add(22, 12, 3, "Average", "false");
            return table;
            
        }
    }
}
