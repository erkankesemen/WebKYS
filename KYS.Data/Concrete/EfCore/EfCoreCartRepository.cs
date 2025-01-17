using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using KYS.Data.Abstract;
using KYS.Entity;
using Microsoft.EntityFrameworkCore;

namespace KYS.Data.Concrete.EfCore
{
   public class EfCoreCartRepository : EfCoreGenericRepository<Cart>, ICartRepository
    {
        public EfCoreCartRepository(NetContext context): base(context)
        {
            
        }

        private NetContext NetContext
        {
            get {return context as NetContext; }
        }
        public void ClearCart(int cartId)
        {
               var cmd = @"delete from CartItems where CartId=@p0";
               NetContext.Database.ExecuteSqlRaw(cmd,cartId);
        }

        public void DeleteFromCart(int cartId, int productId)
        {
               var cmd = @"delete from CartItems where CartId=@p0 and ProductId=@p1";
               NetContext.Database.ExecuteSqlRaw(cmd,cartId,productId);
        }

        public Cart GetByUserId(string userId)
        {
                return NetContext.Carts
                            .Include(i=>i.CartItems)
                            .ThenInclude(i=>i.Firma)
                            .FirstOrDefault(i=>i.UserId==userId);
        }

        public override void Update(Cart entity)
        {
               NetContext.Carts.Update(entity);
        } 
    }
}