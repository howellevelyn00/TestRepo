using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CKK.Logic.Models
{
   internal class Product
   {
      private int Id;
      private string Name;
      private double Price;

      public Product(int id, string name, double price)
      {
         Id = id;
         Name = name;
         Price = price;
      }

      public int GetId()
      {
         return Id;
      }
      public void SetId(int id)
      {
         Id = id;
      }
      public string GetName()
      {
         return Name;
      }
      public void SetName(string name)
      {
         Name = name;
      }

      public double GetPrice()
      {
         return Price;
      }

      public void SetPrice(double price)
      {
         Price = price;
      }
   }
}
