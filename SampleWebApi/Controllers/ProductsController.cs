using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using SampleWebApi.Models;
using SampleWebApi.IDAL;
using SampleWebApi.DAL;
using System.Collections;

namespace SampleWebApi.Controllers
{
    public class ProductsController : ApiController
    {
        static readonly IDAL.IDAL repository = new DAL.DAL();

        public IEnumerable GetAllProducts()
        {
            return repository.GetAll();
        }

        public product PostProduct(product item)
        {
            return repository.Add(item);
        }

        public IEnumerable PutProduct(int id, product product)
        {
            product.Id = id;
            if (repository.Update(product))
            {
                return repository.GetAll();
            }
            else
            {
                return null;
            }
        }

        public bool DeleteProduct(int id)
        {
            if (repository.Delete(id))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
