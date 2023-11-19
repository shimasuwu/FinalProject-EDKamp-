using Business.Concrete;
using Core.Utilities.Results;
using DataAccess.Concrete.EntityFramework;
using DataAccess.Concrete.InMemory;



ProductTest();
//CategoryTest();






static void ProductTest()
{
    ProductManager productManager = new ProductManager(new EFProductDal());

    /*
    foreach (var item in productManager.GetProductDetails())
    {
        Console.WriteLine(item.ProductName + " / " + item.ProductName);
    }
    */

    var result = productManager.GetProductDetails();

    if (result.Success == true)
    {
        foreach (var product in result.Data)
        {
            Console.WriteLine(product.ProductName + "/" + product.CategoryName);
        }
    }
    else
    {
        Console.WriteLine(result.Message);
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
