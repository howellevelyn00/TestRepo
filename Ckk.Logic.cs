using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace CKK.Logic.Models
{
   class Logic
   { 
      static void Main(string[] args)
      {
         // variables for customers
         Console.Write("What is your name: ");
         string name = Console.ReadLine();
         Console.WriteLine();
         Console.Write("What is you ID number: ");
         int number = Convert.ToInt32(Console.ReadLine());
         Console.WriteLine();
         Console.Write("What is your address: ");
         string address = Console.ReadLine();
         Console.WriteLine();

         // making customers
         Customer customer1 = new Customer(number,name,address);
         customer1.SetId(number);
         customer1.SetName(name);
         customer1.SetAddress(address);

         // variables for Products
         int id = 1234;
         string carrot = "Carrot";
         double price = 1.0;
         int id2 = 2345;
         string pineapple = "pineapple";
         double price2 = 2.0; 

         // making product1 carrots
         Product product1 = new Product(id,carrot,price);
         product1.SetId(id);
         product1.SetName(carrot);
         product1.SetPrice(price);


         // Shopping variables
         int howmany;
         string stuff;
         Console.WriteLine("would you like some carrots cause that is all that we have?: ");
         //silly joke
         string toobad = Console.ReadLine();
         if (toobad == "no" | toobad == "No")
         {
            Console.WriteLine("Well that is too bad!");
         }
         // back to serious stuff
         Console.WriteLine("How many do you want?: ");
         howmany = int.Parse(Console.ReadLine());
         Product product = new Product(1, "Carrot", 5.99);

         // the making of the Shopping cart
         ShoppingCartItem shopping = new ShoppingCartItem(product, howmany);
         shopping.SetQuantity(howmany);
         shopping.SetProduct(product);
         // making shopping Cart

         //StorIems stuff
         product = new Product (2, "Cheezewhiz", 8.59);
         int howmuch = 40;
         StoreItem item = new StoreItem(product, howmuch);
         item.SetQuantity(howmuch);
         item.SetProduct(product);

         Console.WriteLine($"So{customer1.GetName()}this is your id{customer1.GetId()}and this is your adress {customer1.GetAddress()}");
      


      }
   }
}
