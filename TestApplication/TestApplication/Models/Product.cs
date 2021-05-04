using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TestApplication.Models
{
    public class Product
    {
        public string _productName;
        public string ProductName { get { return _productName; } }
        public decimal _price;
        public decimal Price { get { return _price; } }
        public string _description;
        public string Description { get { return _description; } }

        public Product(string productNm, decimal price, string description)
        {
            _productName = productNm;
            _price = price;
            _description = description;
        }
    }

    public class Offer
    {
        private string _offerName;
        public string OfferName { get { return _offerName; } }
        private Product _productList;
        public Product ProductList { get { return _productList; } }

        public Offer(string offername, Product productlist)
        {
            _offerName = offername;
            _productList = productlist;
        }

    }
    public class OfferService
    {
        private List<Product> Inventory { get; set; }

        public OfferService()
        {
            Inventory = InsertProduct();
        }

        private List<Product> InsertProduct()
        {
            List<Product> _list = new List<Product>()
            {
                new Product("P1", 1000,"P1 desc"),
                new Product("P2", 200,"P2 desc"),
                new Product("P3", 400,"P3 desc"),
                new Product("P4", 700,"P4 desc"),
                new Product("P5", 600,"P5 desc"),
                new Product("P6", 800,"P6 desc")
            };

            return _list;
        }

        public List<Product> GetAllProducts()
        {
            return Inventory;
        }
    }


}