using System;
using System.Collections.Generic;


namespace Assignment_7
{
    class Program
    {
        static void Main(string[] args)
        {
            
            ProductsList pl = new ProductsList();

        }

    }
    public class ProductsList
    {
        Product p1, p2, p3, p4, p5, p6, p7, p8;

        static List<Product> product;

        //instance objects with values that have been added to the products list
        public ProductsList()
        {
            p1 = new Product(121, "swing tee shirt");
            p2 = new Product(123, "v-neck tunic shirt");
            p3 = new Product(454, "wrap dress");
            p4 = new Product(444, "summer maxi dress");
            p5 = new Product(747, "pull-on stretch jean");
            p6 = new Product(725, "bleach wash jean");
            p7 = new Product(858, "light weight rain jacket");
            p8 = new Product(899, "wool cardigan");


            product = new List<Product>()
            {
                p1,p2,p3,p4,p5,p6,p7,p8
            };

            Product pd = product.Find(uuu => uuu.itemNumber == 899);
            Console.WriteLine(pd.productName);
			Console.ReadLine();

        }
        //constructor
        public class Product
        {
            public int itemNumber { get; set; }
            public string productName { get; set; }

            //constructor
            public Product(int itemnumber, string productname)
            {
                itemNumber = itemnumber;
                productName = productname;
            }
            


        }
    }

    
}
