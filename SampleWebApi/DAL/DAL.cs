using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using SampleWebApi.Models;
using SampleWebApi.IDAL;

namespace SampleWebApi.DAL
{
    public class DAL:IDAL.IDAL
    {
        TempJayEntities ProductDB = new TempJayEntities();

        public IEnumerable<product> GetAll()
        {
            // TO DO : Code to get the list of all the records in database
            return ProductDB.products;
        }

        public product Get(int id)
        {
            // TO DO : Code to find a record in database
            return ProductDB.products.Find(id);
        }

        public product Add(product item)
        {
            if (item == null)
            {
                throw new ArgumentNullException("item");
            }

            // TO DO : Code to save record into database
            ProductDB.products.Add(item);
            ProductDB.SaveChanges();
            return item;
        }

        public bool Update(product item)
        {
            if (item == null)
            {
                throw new ArgumentNullException("item");
            }

            // TO DO : Code to update record into database
            var products = ProductDB.products.Single(a => a.Id == item.Id);
            products.Name = item.Name;
            products.Category = item.Category;
            products.Price = item.Price;
            ProductDB.SaveChanges();

            return true;
        }

        public bool Delete(int id)
        {
            // TO DO : Code to remove the records from database
            product products = ProductDB.products.Find(id);
            ProductDB.products.Remove(products);
            ProductDB.SaveChanges();
            return true;
        }
    }
}