using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using KYS.Business.Abstract;
using KYS.Data.Abstract;
using KYS.Entity;

namespace KYS.Business.Concrete
{
   public class CartManager : ICartService
    {
        private readonly IUnitOfWork _unitofwork;
        public CartManager(IUnitOfWork unitofwork)
        {
            _unitofwork = unitofwork;
        }

        public void AddToCart(string userId, int firmaId, int quantity)
        {
            var cart = GetCartByUserId(userId);

            if(cart!=null)
            {
                // eklenmek isteyen ürün sepette varmı (güncelleme)
                // eklenmek isteyen ürün sepette var ve yeni kayıt oluştur. (kayıt ekleme)

                var index = cart.CartItems.FindIndex(i=>i.FirmaId==firmaId);                
                if(index<0)
                {
                    cart.CartItems.Add(new CartItem(){
                        FirmaId = firmaId,
                        Quantity = quantity,
                        CartId = cart.Id
                    });
                }
                else{
                    cart.CartItems[index].Quantity += quantity;
                }

                _unitofwork.Carts.Update(cart);
                _unitofwork.Save();

            }
        }

        public void ClearCart(int cartId)
        {
            _unitofwork.Carts.ClearCart(cartId);
        }

        public void DeleteFromCart(string userId, int productId)
        {
            var cart = GetCartByUserId(userId);
            if(cart!=null)
            {
                _unitofwork.Carts.DeleteFromCart(cart.Id,productId);
            }   
        }

        public Cart GetCartByUserId(string userId)
        {
            return _unitofwork.Carts.GetByUserId(userId);
        }

        public void InitializeCart(string userId)
        {
            _unitofwork.Carts.Create(new Cart(){UserId = userId});
            _unitofwork.Save();
        }
    }
}