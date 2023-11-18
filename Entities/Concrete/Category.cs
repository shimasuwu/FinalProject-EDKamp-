using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.Entities;

namespace Entities.Concrete
{
    //Entities'in Concrete klasorunde yer alan classlarin birer veritabani tablosuna karsilik geldigini belirtmek icin bu classlara bir interface eklenmelidir(isaretleme teknigi).
    public class Category :IEntity
    {
        public int CategoryId { get; set; }
        public string CategoryName { get; set; }
    }
}
