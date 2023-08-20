using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CKK.Logic.Models
{
   internal class ShoppingCartItem
   {
      private Product Product;
      private int Quantity;

      public ShoppingCartItem(Product product, int quantity)
      {
         Product = product;
         Quantity = quantity;
      }

      public int GetQuantity()
      {
         return Quantity;
      }

      public void SetQuantity(int quantity)
      {
         Quantity = quantity;
      }
      public Product GetProduct()
      {
         return Product;
      }
      public void SetProduct(Product product)
      {
         Product = product;
      }
   }
}
