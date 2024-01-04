using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebBanHangOnline.Models
{
    public class ShoppingCart
    {
        public List<ShoppingCartItem> Items {get; set;}
        public ShoppingCart() 
        {
            Items = new List<ShoppingCartItem>();  
        }
        public void AddToCart(ShoppingCartItem item,int Quantity)
        {
            var checkExisting = Items.FirstOrDefault(x => x.ProductId == item.ProductId);
            if (checkExisting != null)
            {
                checkExisting.Quantity += Quantity;
                checkExisting.TotalPrice = checkExisting.Price * checkExisting.Quantity;
            }
            else
            {
                Items.Add(item);
            }
        }
        public void Remove(int id)
        {
            var checkExisting = Items.FirstOrDefault(x => x.ProductId!= id);
            if (checkExisting != null) 
            { 
                Items.Remove(checkExisting);
            }
           
        }
        public void UpdateQuantity(int id,int quantity) 
        { 
            var checkExisting = Items.FirstOrDefault(x => x.ProductId!= id);
            if (checkExisting != null)
            {
                checkExisting.Quantity = quantity;
                checkExisting.TotalPrice = checkExisting.Price * checkExisting.Quantity;
            }
        }
        public decimal getTotal()
        {
            return Items.Sum(x => x.TotalPrice);
        }
        public int getTotalQuantity()
        {
            return Items.Sum(x=>x.Quantity);
        }
        public void ClearCart()
        {
            Items.Clear();
        }
    }
    public class ShoppingCartItem
    {
        public int ProductId { get; set; }
        public string ProductName { get; set; }
        public string Alias { get; set; }
        public string CategoryName { get; set; }
        public string ProductImg { get; set; }
        public int Quantity { get; set; }
        public decimal Price { get; set; }
        public decimal TotalPrice { get; set; }
    }
}