using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Bookstore.Models
{
    public interface ICheckoutRepository
    {
        IQueryable<Checkout> Checkouts { get; }
        void SaveCheckout(Checkout checkout);
    }
}
