using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface IProductServise
    {
        List<Product> GetAll();
        List<Product> GetAllByCategoryId(int id);
    }
}
