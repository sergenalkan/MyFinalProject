using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using DataAccess.Concrete.InMemory;
using System;

namespace ConsoleUI
{
    //SOLID
    //Open Closed Principle : Yaptığın yazılıma yeni özellik ekliyorsan, mevcuttaki hiçbir koda dokunmayacaksın
    class Program
    {
        static void Main(string[] args)
        {
            ProductManager productManager = new ProductManager(new EfProductDal());
                      
            foreach (var product in productManager.GetByUnitPrice(10,100))
            {
                Console.WriteLine(product.ProductName);
            }

            PersonelManager personelManager = new PersonelManager(new EfPersonelDal());
            foreach (var personel in personelManager.GetAll())
            {
                Console.WriteLine("{0} / {1} / {2}",personel.Id, personel.Name, personel.Surname);
            }
        }
    }
}
