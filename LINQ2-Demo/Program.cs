using System.Collections.Generic;
using System;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.Intrinsics.X86;
using System.Collections;
using System.Text.RegularExpressions;
using System.Xml.Linq;
using static LINQ2_Demo.ListGenerator;
namespace LINQ2_Demo
{
    internal class Program
    {
        static void Main(string[] args)
        {

            #region --> Element Operators

            //// First , Last
            //var Result = ProductList.First(); //May Through Exception
            //var Result = ProductList.Last();  //May Through Exception
            //// FirstOrDefault , LastOrDefault
            //var Result = ProductList.FirstOrDefault();
            //var Result = ProductList.LastOrDefault();
            //// FirstOrDefault , LastOrDefault
            //var Result = ProductList.LastOrDefault((P) => P.UnitsInStock == 0);      //May Through Exception    
            //var Result = ProductList.FirstOrDefault((P) => P.UnitsInStock == 0);     //May Through Exception    
            //// FirstOrDefault , LastOrDefault
            //var Result = ProductList.FirstOrDefault((P) => P.UnitsInStock == 0, new Product { ProductName = "Default Value" });
            //var Result = ProductList.LastOrDefault((P) => P.UnitsInStock == 0, new Product { ProductName = "Default Value" });
            //// ElementAt , ElementAtOrDefault
            //var Result = ProductList.ElementAt(0);
            //var Result = ProductList.ElementAtOrDefault(0);
            //// Single , SingleOrDefault
            //var Result = ProductList.Single();
            //var Result = ProductList.SingleOrDefault();
            //var Result = ProductList.SingleOrDefault((P) => P.UnitPrice > 5000);
            //var Result = ProductList.SingleOrDefault((P) => P.UnitPrice > 5000, new Product() { ProductName = "Default Value" });
            //var Result = ProductList.SingleOrDefault(new Product() { ProductName = "Default Value" });



            //Console.WriteLine(Result);




            #endregion


            #region --> Aggregate Operators

            ////(sum, avg, max, min, count)

            //// Count
            //var Result = ProductList.Count(); // List Property
            //var Result = ProductList.Count(P => P.UnitsInStock == 0); // LINQ Operartor

            //// Sum
            //var Result = ProductList.Sum(P => P.UnitPrice);

            //// Average
            //var Result = ProductList.Average(P => P.UnitPrice);

            //// Max
            //var Result = ProductList.Max();

            //// Min
            //var Result = ProductList.Min();

            //// Aggregate
            //List<string> list = new List<string>() { "Aya", "Omar", "Amr" };

            //var Result = list.Aggregate((S01, S02) => $"{S01} {S02}");

            //Console.WriteLine(Result);


            #endregion


            #region --> Casting Operators


            //List<Product> Result = new List<Product>();
            //Result = ProductList.Where((P) => P.ProductID > 20).ToList();


            //Product[] arr = ProductList.Where((P) => P.ProductID < 20).ToArray();

            //Dictionary<long, Product> arr = ProductList.Where((P) => P.ProductID < 20).ToDictionary((P) => P.ProductID);

            //HashSet<Product> arr = ProductList.Where((P) => P.ProductID < 20).ToHashSet();

            //foreach (var item in arr)
            //{
            //    Console.WriteLine(item);
            //}

            //ArrayList obj = new ArrayList()
            //{
            //    "Abdelrahman",
            //    "Omar",
            //    "Ahmed",
            //    1,
            //    2,
            //    3,
            //    'A'
            //};
            //var Result = obj.OfType<string>();
            //foreach (var item in Result)
            //    Console.WriteLine(item);

            #endregion



            #region --> Generation Operators

            ////Only way to call it ====> ( class member method through  Enumerable class )

            //var Result = Enumerable.Range(1, 20);

            //var Result = Enumerable.Repeat(new Product(), 20);

            //var Result = Enumerable.Empty<int>();


            //foreach (var item in Result)
            //{
            //    Console.WriteLine(item);
            //}

            //var Result = Enumerable.Empty<Product>().ToArray();
            //foreach (var item in Result)
            //    Console.WriteLine(item);

            #endregion


            #region --> Set Operators


            //var Seq01 = Enumerable.Range(0, 100);
            //var Seq02 = Enumerable.Range(50, 100);

            ////var Result = Seq01.Union(Seq02);

            ////var Result = Seq01.UnionBy(Seq02, X => X > 0);


            ////var Result = Seq01.Intersect(Seq02);
            ////var Result = Seq01.IntersectBy(Seq02, X => X = 1);

            ////var Result = Seq01.Distinct();
            ////var Result = Seq01.Except(Seq02);
            //var Result = Seq01.Concat(Seq02);

            //Console.WriteLine(Result);





            #endregion



            #region --> Zipping Operators

            //string[] Names = { "Abdelrahman", "Omar", "Amr", "Ahmed", "May", "Aya" };

            //int[] Numbers = Enumerable.Range(1,10).ToArray();

            //var Result = Names.Zip(Numbers, (Name, Num) => $"{Name} ===> {Num}");

            //foreach (var item in Result)
            //{
            //    Console.WriteLine(item);
            //}



            #endregion


        }
    }
}
