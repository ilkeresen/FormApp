using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FormsApp.Models
{
    public static class ProductRepository
    {
        private static List<Product> _products;

        static ProductRepository()
        {
            _products = new List<Product>()
            {
                new Product(){ Id=1, Name="Product 1", Description="Description 1", Price=10, isApproved=true},
                new Product(){ Id=2, Name="Product 2", Description="Description 2", Price=20, isApproved=false},
                new Product(){ Id=3, Name="Product 3", Description="Description 3", Price=30, isApproved=true},
                new Product(){ Id=4, Name="Product 4", Description="Description 4", Price=120, isApproved=true},
                new Product(){ Id=5, Name="Product 5", Description="Description 5", Price=140, isApproved=false},
                new Product(){ Id=6, Name="Product 6", Description="Description 6", Price=160, isApproved=true},
                new Product(){ Id=7, Name="Product 7", Description="Description 7", Price=132, isApproved=true},
                new Product(){ Id=8, Name="Product 8", Description="Description 8", Price=154, isApproved=false},
                new Product(){ Id=9, Name="Product 9", Description="Description 9", Price=345, isApproved=true},
                new Product(){ Id=10, Name="Product 10", Description="Description 10", Price=100, isApproved=false}
            };
        }

        public static List<Product> Products
        {
            get { return _products; }
        }

        public static void AddProduct(int productLast, string Name, string Description, decimal Price, bool isApproved)
        {
            var item = new Product() { Id = productLast, Name = Name, Description = Description, Price = Price, isApproved = isApproved };
            _products.Add(item);
        }

    }
}
