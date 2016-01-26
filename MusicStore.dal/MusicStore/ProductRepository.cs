﻿using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MusicStore.DAL.Interfaces;
using MusicStore.DAL.Repository;




namespace MusicStore.DAL.MusicStore
{
    public class ProductRepository : IProductRepository 
    {
        private MusicStoreContext context = new MusicStoreContext();
        static ProductRepository()
        {
            Database.SetInitializer<MusicStoreContext>(null);
        }
        public IEnumerable<Product> Products
        {
            get { return context.Products; }
        }


        public void SaveProduct(Product product)
        {

            if (product.ProductID == 0)
            {
                context.Products.Add(product);
            }
            else
            {
                Product dbEntry = context.Products.Find(product.ProductID);
                if (dbEntry != null)
                {
                    dbEntry.Name = product.Name;
                    dbEntry.Description = product.Description;
                    dbEntry.Price = product.Price;
                    dbEntry.Category = product.Category;
                  
                }
            }
            context.SaveChanges();
        }

        public Product DeleteProduct(int productID)
        {
            Product dbEntry = context.Products.Find(productID);
            if (dbEntry != null)
            {
                context.Products.Remove(dbEntry);
                context.SaveChanges();
            }
            return dbEntry;
        }

    }
}


