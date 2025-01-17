using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace KYS.Entity
{
    public class CartItem
    {
       public int Id { get; set; }

        public int FirmaId { get; set; }
        public Firma Firma { get; set; }
        public int CartId { get; set; }
        public Cart Cart { get; set; }

        public int Quantity { get; set; }
    }
}