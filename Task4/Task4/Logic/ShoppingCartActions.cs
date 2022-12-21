using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Task4.Models;
using Task4;

namespace Task4.Logic
{
    public class ShoppingCartActions : IDisposable
    {
        public string ShoppingCartId { get; set; }

        private foodcontext _db = new foodcontext();

        public const string CartSessionKey = "CartId";

        public void AddToCart(int id)
        {       
            ShoppingCartId = GetCartId();

            var cartItem = _db.ShoppingCartItems.SingleOrDefault(
                c => c.CartId == ShoppingCartId
                && c.FoodId == id);
            if (cartItem == null)
            {               
                cartItem = new CartItem
                {
                    ItemId = Guid.NewGuid().ToString(),
                    FoodId = id,
                    CartId = ShoppingCartId,
                    Food = _db.Food.SingleOrDefault(
                   f => f.FoodID == id),
                    Quantity = 1
                };

                _db.ShoppingCartItems.Add(cartItem);
            }
            else
            {            
                cartItem.Quantity++;
            }
            _db.SaveChanges();
        }

        public void Dispose()
        {
            if (_db != null)
            {
                _db.Dispose();
                _db = null;
            }
        }

        public string GetCartId()
        {
            if (HttpContext.Current.Session[CartSessionKey] == null)
            {
                if (!string.IsNullOrWhiteSpace(HttpContext.Current.User.Identity.Name))
                {
                    HttpContext.Current.Session[CartSessionKey] = HttpContext.Current.User.Identity.Name;
                }
                else
                {
                    // Generate a new random GUID using System.Guid class.     
                    Guid tempCartId = Guid.NewGuid();
                    HttpContext.Current.Session[CartSessionKey] = tempCartId.ToString();
                }
            }
            return HttpContext.Current.Session[CartSessionKey].ToString();
        }

        public List<CartItem> GetCartItems()
        {
            ShoppingCartId = GetCartId();

            return _db.ShoppingCartItems.Where(
                c => c.CartId == ShoppingCartId).ToList();
        }
    }
}