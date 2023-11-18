using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface ICategoryService
    {
        //kategori ile ilgili dis dunyaya neyi servis etmek istiyorsam onu yaziyorum.
        List<Category> GetAll();
        Category GetById(int categoryId); //category id'ye  gore filtreleme.
    }
}
