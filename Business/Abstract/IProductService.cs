using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities.Concrete;
using Entities.DTOs;

namespace Business.Abstract
{
    public interface IProductService
    {
        List<Product> GetAll();
        List<Product> GetAllByCategories(int id);
        List<Product> GetAllByUnitPrice(decimal min, decimal max);
        List<ProductDetailDto> GetProductDetails();
    }
}
