using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using KYS.Entity;

namespace KYS.Business.Abstract
{
    public interface ICartService
    {
        void InitializeCart(string userId);
        Cart GetCartByUserId(string userId);
        void AddToCart(string userId,int productId,int quantity);
        void DeleteFromCart(string userId, int productId);
        void ClearCart(int cartId);
    }
}