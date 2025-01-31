using System.Collections.Generic;
using System;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.Intrinsics.X86;
using System.Collections;
using System.Text.RegularExpressions;
using System.Xml.Linq;
using static LINQ2_Asssignment.ListGenerator;
namespace LINQ2_Asssignment
{
    internal class Program
    {
        static void Main(string[] args)
        {

            #region Element Operators



            // // 1 -

            // var Result = ProductList.FirstOrDefault(P => P.UnitsInStock == 0, new Product() { ProductName = "No Name" });
            // Console.WriteLine(Result?.ProductName ?? " NA ");





            // // 2 -

            //var Result = ProductList.FirstOrDefault(P => P.UnitPrice > 1000, new Product() { ProductName = "No Products more than 1000" });

            // Console.WriteLine($" Name : {Result?.ProductName ?? " NP"} ");




            // // 3 -

            //int[] Arr = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };

            // var Result = Arr.Where(n => n > 5).Skip(1).FirstOrDefault();

            // Console.WriteLine(Result);


            #endregion




            #region Aggregate Operators



            // //1 -

            //int[] Arr = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };
            // var Result = Arr.Count(n => n % 2 != 0);
            // Console.WriteLine(Result);





            //// 2 - 

            //var Result = CustomerList.Select(c =>
            //                                     new
            //                                     {
            //                                         customerName = c.CustomerName,
            //                                         CountOfOrders = c.Orders.Count()
            //                                     });

            //Result = from c in CustomerList
            //         select new
            //         {
            //             customerName = c.CustomerName,
            //             CountOfOrders = c.Orders.Count()
            //         };


            //foreach (var item in Result)
            //{
            //    Console.WriteLine($"Customer Name : {item.customerName} ::: Count Of Orders : {item.CountOfOrders}");
            //}







            //// 3 - 


            //var Result = ProductList.Select(c =>
            //                                     new
            //                                     {
            //                                         category = c.Category,
            //                                         CountOfProducts = c.ProductName.Count()
            //                                     });

            //Result = from c in ProductList
            //         select new
            //         {
            //             category = c.Category,
            //             CountOfProducts = c.ProductName.Count()
            //         };


            //foreach (var item in Result)
            //{
            //    Console.WriteLine($"Category  : {item.category} ::: Count Of Products : {item.CountOfProducts}");
            //}








            //// 4 - 

            //int[] Arr = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };
            //var Result = Arr.Sum();
            //Console.WriteLine(Result);




            //// 5 -

            //string[] StrArr = File.ReadAllLines("dictionary_english.txt");
            //int total = 0;

            //foreach (string word in StrArr)
            //{
            //    total += word.Length;
            //}
            //Console.WriteLine(total);




            //// 6 - 

            //string[] StrArr = File.ReadAllLines("dictionary_english.txt");

            //int ShortLength = StrArr.Min(w => w.Length);

            //Console.WriteLine(ShortLength);









            // 7 - 

            //string[] StrArr = File.ReadAllLines("dictionary_english.txt");

            //int LongtLength = StrArr.Max(w => w.Length);

            //Console.WriteLine(LongtLength);





            //// 8 - 

            //string[] StrArr = File.ReadAllLines("dictionary_english.txt");

            //int TotalLength = StrArr.Sum(w => w.Length);

            //int AverageLength = TotalLength / StrArr.Length;

            //Console.WriteLine(AverageLength);





            //// 9 - 

            //var Result = ProductList.GroupBy(p => p.Category)
            //                              .Select(c => new
            //                              {
            //                                  CategoryName = c.Key,
            //                                  TotalUnitsInStock = c.Sum(p => p.UnitsInStock)
            //                              });


            ////var Result = from P in ProductList
            ////         where P.UnitsInStock > 0
            ////         group P by P.Category
            ////         into Category
            ////         select new
            ////         {
            ////             CategoryName = Category.Key,
            ////             TotalCategory = Category.Sum(p => p.UnitsInStock)
            ////         };

            //foreach (var item in Result)
            //{
            //    Console.WriteLine(item);
            //}







            // 10 - 


            //var Result = from P in ProductList
            //             where P.UnitsInStock > 0
            //             group P by P.Category
            //             into Category
            //             select new
            //             {
            //                 CategoryName = Category.Key,
            //                 CheapestPrice = Category.Min(p => p.UnitPrice)
            //             };

            //Result = ProductList.GroupBy(P => P.Category)
            //                                .Select(c => new
            //                                {
            //                                    CategoryName = c.Key,
            //                                    CheapestPrice = c.Min(p => p.UnitPrice)
            //                                });

            //foreach (var item in Result)
            //{
            //    Console.WriteLine(item);
            //}






            // 11 - 


            //var Result = from P in ProductList
            //             where P.UnitsInStock > 0
            //             group P by P.Category
            //             into Category
            //             let MinPrice = Category.Min(P => P.UnitPrice)
            //             from p in Category
            //             where p.UnitPrice == MinPrice
            //             select p;


            //foreach (var item in Result)
            //{
            //    Console.WriteLine(item);
            //}









            // 12 - 

            //var Result = from P in ProductList
            //             where P.UnitsInStock > 0
            //             group P by P.Category
            //             into Category
            //             let MaxnPrice = Category.Max(P => P.UnitPrice)
            //             from p in Category
            //             where p.UnitPrice == MaxnPrice
            //             select p;


            //foreach (var item in Result)
            //{
            //    Console.WriteLine(item);
            //}







            // 13 - 



            //var Result = from P in ProductList
            //             group P by P.Category
            //             into Category
            //             let ExpensivePrice = Category.Max(P => P.UnitPrice)
            //             from   p in Category
            //             where  p.UnitPrice == ExpensivePrice
            //             select p;

            //foreach (var item in Result)
            //{
            //    Console.WriteLine(item);
            //}








            //  14 - 

            //var Result = ProductList.Where(P => P.UnitsInStock > 0)
            //                        .GroupBy(p => p.Category)
            //                        .Select(c => new
            //                        {
            //                            Category = c.Key,
            //                            AveragePrice = c.Average(p => p.UnitPrice)
            //                        });


            ////var Result = from P in ProductList
            ////         where P.UnitsInStock > 0
            ////         group P by P.Category
            ////             into Category
            ////         select new
            ////         {
            ////             CategoryName = Category.Key,
            ////             AveragePrice = Category.Average(p => p.UnitPrice)
            ////         };


            //foreach (var item in Result)
            //{
            //    Console.WriteLine(item);
            //}


            #endregion




            #region  Set Operators


            //// 1 - 

            //var Result = ProductList.Select(P => P.Category).Distinct();

            //foreach (var item in Result)
            //{
            //    Console.WriteLine(item);
            //}



            //// 2 - 

            //var Result = ProductList.Select(P => P.ProductName.First())
            //                        .Concat(CustomerList.Select(C => C.CustomerName.First()) ) .Distinct();

            //foreach (var item in Result)
            //{
            //    Console.WriteLine(item);    
            //}



            ////  3 - 

            //var Seq01 = ProductList.Select(P => P.ProductName.First());
            //var Seq02 = CustomerList.Select(C => C.CustomerName.First());
            //var Result = Seq01.Intersect(Seq02);


            //foreach (var item in Result)
            //{
            //    Console.WriteLine(item);
            //}



            //// 4 - 

            //var Seq01 = ProductList.Select(P => P.ProductName.First());
            //var Seq02 = CustomerList.Select(C => C.CustomerName.First());
            //var Result = Seq01.Except(Seq02);


            //foreach (var item in Result)
            //{
            //    Console.WriteLine(item);
            //}



            //// 5 - 

            //var Seq01 = ProductList.Select( P => P.ProductName.Substring( Math.Max( 0, P.ProductName.Length - 3 ) ) );
            //var Seq02 = CustomerList.Select(C => C.CustomerName.Substring(Math.Max( 0, C.CustomerName.Length - 3) ) );
            //var Result = Seq01.Concat(Seq02);


            //foreach (var item in Result)
            //{
            //    Console.WriteLine(item);
            //}




            #endregion




            #region Partitioning Operators



            // 1 - 


            //var Result = CustomerList.Where(C => C.Region == "WA")
            //                          .SelectMany(C => C.Orders)
            //                          .Take(3);


            //foreach (var item in Result)
            //{
            //    Console.WriteLine(item);
            //}



            // 2 - 


            //var Result = CustomerList.Where(C => C.Region == "WA")
            //                         .SelectMany(C => C.Orders)
            //                         .Skip(2);


            //foreach (var item in Result)
            //{
            //    Console.WriteLine(item);
            //}




            // 3 -

            //int[] Numbers = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };

            //var Result = Numbers.TakeWhile((N, I) => N >= I );

            //foreach (var item in Result)
            //{
            //    Console.WriteLine(item);
            //}




            // 4 - 

            //int[] numbers = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };

            //var Result = numbers.SkipWhile(num => num % 3 != 0);


            //foreach (var item in Result)
            //{
            //    Console.WriteLine(item);
            //}



            // 5 - 


            //int[] Numbers = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };

            //var Result = Numbers.SkipWhile((N, I) => N >= I);

            //foreach (var item in Result)
            //{
            //    Console.WriteLine(item);
            //}




            #endregion




            #region Quantifiers 


            //// 1 -

            //string[] words = File.ReadAllLines("dictionary_english.txt");


            //var Result = words.Any(W => W.Contains(" ei "));

            //Console.WriteLine(Result);




            //// 2 -



            //var Result = ProductList.Where(P => P.UnitsInStock == 0)
            //                        .GroupBy(P => P.Category)
            //                         .Where( C => C.Any() );

            //foreach (var item in Result)
            //{
            //    Console.WriteLine("  =========================  ");

            //    Console.WriteLine($" Category  :  {item.Key} ");

            //    foreach (var p in item)
            //    {
            //        Console.WriteLine($" Product Name  : {p.ProductName} ::: UnitsInStock : { p.UnitsInStock } ");
            //    }

            //}






            //// 3 -


            //var Result = ProductList.Where(P => P.UnitsInStock > 0)
            //                        .GroupBy(P => P.Category)
            //                        .Where(C => C.Any());

            //foreach (var item in Result)
            //{
            //    Console.WriteLine("  =========================  ");

            //    Console.WriteLine($" Category  :  {item.Key} ");

            //    foreach (var p in item)
            //    {
            //        Console.WriteLine($" Product Name  : {p.ProductName} ::: UnitsInStock : {p.UnitsInStock} ");
            //    }

            //}






            #endregion





            #region Grouping Operators



            //// 1 - 

            //List<int> numbers = new List<int> { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15 };

            //var Result = numbers.GroupBy(n => n % 5);

            //foreach (var item in Result)
            //{
            //    Console.WriteLine($" Numbers with a remainder {item.Key} when divided by 5 : ");

            //    foreach (var num in item)
            //    {
            //        Console.WriteLine(num);
            //    }

            //}





            //// 2 - 

            //string[] words = File.ReadAllLines("dictionary_english.txt");
            //var Result = words.GroupBy(w => w.First());

            //foreach (var item in Result)
            //{
            //    Console.WriteLine($" \n Words start with ( {item.Key} ) \n");

            //    foreach (var W in item)
            //    {
            //        Console.WriteLine(W);
            //    }

            //}





            //// 3 - 


            //String[] Arr = { "from", "salt", "earn", " last", "near", "form" };

            //var Result = Arr.GroupBy(W => W.Trim().ToLower(), new CustomCompare());

            //foreach (var word in Result)
            //{

            //    Console.WriteLine(string.Join(Environment.NewLine, word));
            //    Console.WriteLine("\n.....\n");
            //}


            #endregion





        }
    }
}
