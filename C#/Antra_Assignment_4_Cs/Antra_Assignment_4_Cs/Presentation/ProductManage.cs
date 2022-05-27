using System;
using Antra_Assignment_4_Cs.DataSet;
using Antra_Assignment_4_Cs.GenericRepository;


namespace Antra_Assignment_4_Cs.Presentation
{
    public class ProductManage
    {
        ProductRepository productRepository = new ProductRepository();



        private void AddProduct()
        {
            Product p = new Product();

            Console.Write("Enter Product Id =>");
            p.Id = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter Product Name => ");
            p.PName = Console.ReadLine();
            Console.Write("Enter Product UnitPrice => ");
            p.UnitPrice = int.Parse(Console.ReadLine());
            Console.Write("Enter Product Color => ");
            p.Color = Console.ReadLine();
  
        }


        private void DeleteProduct()
        {
            Console.WriteLine("Enter id =>");
            int id = Convert.ToInt32(Console.ReadLine());
            
        }


        private void PrintAllProduct()
        {
            List<Product> allProducts = (List<Product>) productRepository.GetAll();
            foreach (var product in allProducts)
            {
                Console.WriteLine(product.Id + "\t" + product.PName + "\t" + product.UnitPrice + "\t" + product.Color);
            }
        }


        public void Run()
        {
            Console.Clear();
            Console.WriteLine("Press 1 to add");
            Console.WriteLine("Press 2 to print all");
            Console.WriteLine("Press 3 to delete");
            Console.WriteLine("Press 9 to exit");

            Console.WriteLine("Enter choice =>");
            int choice = Convert.ToInt32(Console.ReadLine());

            while (choice != 9)
            {
                switch (choice)
                {
                    case 1:
                        AddProduct();
                        break;
                    case 2:
                        PrintAllProduct();
                        break;
                    case 3:
                        DeleteProduct();
                        break;
                    default:
                        Console.WriteLine("Invalid Option");
                        break;
                }
                Console.WriteLine("Press number to continue");
                choice = Convert.ToInt32(Console.ReadLine());
            }


        }
    }
}
