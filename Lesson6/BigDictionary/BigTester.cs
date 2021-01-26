using System;
using System.Collections.Generic;
using System.Text;

namespace Lesson6.BigDictionary
{
    public class BigTester
    {
        public static void RunTest()
        {
            Console.Clear();

            OrderedMultiDictionary<double, Article> articles = new OrderedMultiDictionary<double, Article>(true);

            int range = 10;
            for (int i = 0; i < range; i++)
            {
                var article = new Article { Barcode = "newBarcode" + i, Vendor = "newVendor" + i, Title = "newTitle" + i, Price = i };
                articles.Add(article.Price, article);
            }

            int from = 5;
            int to = 8;

            //Make some duplications
            for (int i = from; i < to; i++)
            {
                var article = new Article { Barcode = "newBarcode" + i, Vendor = "newVendor" + i, Title = "newTitle" + i, Price = i };
                articles.Add(article.Price, article);
            }

            var articlesInGivenRange = articles.Range(3, true, 9, true);

            foreach (var article in articlesInGivenRange)
            {
                foreach (var item in article.Value)
                {
                    Console.WriteLine("Title: {0}, Vendor: {1}, Barcode: {2}, Price: {3}",
                    item.Title, item.Vendor, item.Barcode, item.Price);
                }
                Console.WriteLine();
            }

            Console.ReadLine();
        }
    }
}


    

