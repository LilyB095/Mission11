using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Bookstore.Models
{
    public class EFCheckoutRepository : ICheckoutRepository
    {
        //Prepare context variable
        private BookstoreContext context;

        //Constructor
        public EFCheckoutRepository(BookstoreContext temp)
        {
            //Initialize context
            context = temp;
        }
        public IQueryable<Checkout> Checkouts => context.Checkouts
            .Include(x => x.Lines)
            .ThenInclude(x => x.Book);

        public void SaveCheckout(Checkout checkout)
        {
            context.AttachRange(checkout.Lines.Select(x => x.Book));

            if (checkout.OrderId == 0)
            {
                context.Checkouts.Add(checkout);
            }

            context.SaveChanges();
        }
    }
}
