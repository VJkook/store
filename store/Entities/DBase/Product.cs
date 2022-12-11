using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace store.Entities.DBase
{
    public class Product: BaseEntity
    {
        public string ProductName { get; set; } = null!;
        public string? ProductDescription { get; set; }
        public double ProductPrice { get; set; }
        public string size { get; set; } = null!;
    }

    public class ProductCategory
    {
        public string Name { get; private set; }
        public ICollection<Product> Products { get; set; }
        public ProductCategory(string name)
        {
            this.Name = name;
            this.Products = new List<Product>();
        }
    }

    /* public class Data
     {
         public static ICollection<ProductCategory> Comp_Part { get; private set; }

         public Data()
         {
             Comp_Part = new List<ProductCategory>();
         }

         public static void Init()
         {
             /*ProductCategory gpus = new ProductCategory("GraphicCard");
             Product g1 = new Product() { Name = "Nvidia Geforce GTX 1050 Ti", Price = 500, Id = 198511 }; 
             Product g2 = new Product() { Name = "Nvidia Geforce GTX 1060 Ti", Price = 640, Id = 187515 };
             Product g3 = new Product() { Name = "Nvidia Geforce RTX 2060", Price = 710, Id = 125921 };
             Product g4 = new Product() { Name = "Nvidia Geforce RTX 2070", Price = 999, Id = 110818 };
             Product g5 = new Product() { Name = "AMD RX 470", Price = 300, Id = 158105 };
             Product g6 = new Product() { Name = "AMD RX 580", Price = 450, Id = 199182 };
             Product g7 = new Product() { Name = "AMD Radeon HD7450", Price = 840, Id = 178781 };
             Product g8 = new Product() { Name = "AMD Radeon HD7850", Price = 920, Id = 158299 };
             gpus.Products.Add(g1);
             gpus.Products.Add(g2);
             gpus.Products.Add(g3);
             gpus.Products.Add(g4);
             gpus.Products.Add(g5);
             gpus.Products.Add(g6);
             gpus.Products.Add(g7);
             gpus.Products.Add(g8);
           Comp_Part.Add(gpus);     */
}
