using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClientConsole.OrderServiceReference;

namespace ClientConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            CategoryServiceClient client = new CategoryServiceClient("BasicHttpBinding_ICategoryService");

            bool service = true;

            Console.WriteLine("======== Welcome to the Order WCF Service ============");
            Console.WriteLine("Options : ");
            Console.WriteLine("Press 1 to get Category name");
            Console.WriteLine("Press 2 to get Category's product list");
            Console.WriteLine("Press 0 to exit.");
            Console.WriteLine("======================================================");

            while(service)
            {
                Console.WriteLine("# Enter your opcion 1, 2, 0 : ");
                int opc = int.Parse(Console.ReadLine());

                Console.WriteLine("Enter your category id : ");
                int id = int.Parse(Console.ReadLine());

                switch(opc)
                {
                    case 1:
                        Console.WriteLine("The category's name is : " + client.GetCategoryNameById(id));
                        break;
                    case 2:
                        Console.WriteLine("The " + client.GetCategoryNameById(id) + "'s product list : ");
                        var products = client.GetProducts(id);
                        if (products.Count() > 0)
                        {
                            int counter = 1;

                            foreach (ProductEntity p in products)
                            {
                                Console.WriteLine("#" + counter + "Product id : " + p.Id + " Product name : " + p.Name);
                            }
                        }
                        else 
                        {
                            Console.WriteLine("Products not found!!!");
                        }
                      
                        break;
                    case 0:
                        service = false;
                        break;
                }
            }

            Console.WriteLine("Thank you!! :) for use my Order Service");
            Console.ReadLine();
        }
    }
}
