using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Linq;
using System.Linq.Expressions;
using Entities.DTOs;

namespace DataAccess.Concrete.InMemory
{
    public class InMemoryProductDal : IProductDal //Interface'deki metotlari burada islevles hale getirip DB islemlerini gerceklestirecegiz.
    {
        List<Product> _products; //global degisken isimleri genellikle alt cizgi ile tanimlanir. _products db'ye eklenecke verileri tutacak.
        public InMemoryProductDal()
        {
            _products = new List<Product> //yapay Db'yi temsil ediyor.
            {
                //DB'den gelen verilerin simulasyonu.
                new Product{ProductId =1, CategoryId=1, ProductName = "Bardak", UnitPrice=15, UnitsInStock =15 }, //1.Urun
                new Product{ProductId =2, CategoryId=1, ProductName = "Kamera", UnitPrice=500, UnitsInStock =3 }, //2.Urun
                new Product{ProductId =3, CategoryId=2, ProductName = "Telefon", UnitPrice=1500, UnitsInStock =5 }, //3.Urun
                new Product{ProductId =4, CategoryId=2, ProductName = "Klavye", UnitPrice=150, UnitsInStock =65 }, //4.Urun
                new Product{ProductId =5, CategoryId=2, ProductName = "Fare", UnitPrice=85, UnitsInStock =1 } //5.Urun
            };  
        }
        public void Add(Product product)
        {
            _products.Add(product); //business'dan gonderilen verileri(product) db'ye ekle
        }

        public void Delete(Product product)
        {
            Product productToDelete =null;

            //LINQ - Language Integrated Query'li Yontem:
            productToDelete = _products.SingleOrDefault(p=> p.ProductId == product.ProductId ); //SOD: ayni foreach gibi _products'in icerisndeki verileri tek tek dolasmaya yarar. 
            _products.Remove(productToDelete); //disaridan girilen product id ile p.nin dolastigi id'yi db'den(_products) siler.


            //LINQ'siz yontem:
            //foreach (Product p in _products)
            //{
            //    if (p.ProductId == product.ProductId)
            //    {
            //        productToDelete = p; //disaridan gelen product id'si ile db'de bulunan urunun id degeri eslesiyorsa o zaman o urunu productToDelete degiskenine ata.
            //    }
            //    _products.Remove(productToDelete); //productToDelete' de tutulan veri db'den(_products listesi) silinecek.
            //}
        }

        public Product Get(Expression<Func<Product, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public List<Product> GetAll()
        {
            return _products; //db'yi oldugu gibi business'a gonder.
        }

        public List<Product> GetAll(Expression<Func<Product, bool>> filter = null)
        {
            throw new NotImplementedException();
        }

        public List<Product> GetAllByCategories(int categoryId)
        {
            return _products.Where(p => p.CategoryId == categoryId).ToList(); //db'deki urunun kategori id'si ile disaridan gelen kategori id'si eselesen urunleri yeni bir liste haline getirir.
        }

        public List<ProductDetailDto> GetProductDetails()
        {
            throw new NotImplementedException();
        }

        public void Update(Product product)
        {
            Product productToUpdate = _products.SingleOrDefault(p => p.ProductId == product.ProductId); //gonderdigim urun id'sine sahip olan listedeki urun id'sini bulup, bulmus oldugu urunun bilgilerini productToUpdate degiskenine atayacak.
            productToUpdate.ProductName = product.ProductName;
            productToUpdate.CategoryId =   product.CategoryId;
            productToUpdate.UnitPrice = product.UnitPrice;
            productToUpdate.UnitsInStock = product.UnitsInStock;
        }
    }
}
