using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using DataAccess.Concrete.InMemory;



ProductTest();
//CategoryTest();






static void ProductTest()
{
    ProductManager productManager = new ProductManager(new EFProductDal());

    foreach (var item in productManager.GetProductDetails())
    {
        Console.WriteLine(item.ProductName + " / " + item.ProductName);
    }
}

static void CategoryTest()
{
    CategoryManager categoryManager = new CategoryManager(new EFCategoryDal());
    foreach (var category in categoryManager.GetAll())
    {
        Console.WriteLine(category.CategoryName);
    }
}