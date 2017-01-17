using SampleWebApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SampleWebApi.IDAL
{
    public interface IDAL
    {        
        

        IEnumerable<product> GetAll();
        product Get(int id);
        product Add(product item);
        bool Update(product item);
        bool Delete(int id);
    }
}