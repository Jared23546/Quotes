using System;
using System.Linq;
using Quotes.Models;

namespace Quotes.Models
{
    public class EFQuotesRepository : IQuotesRepository
    {
        private QuotesContext context { get; set; }

        public EFQuotesRepository(QuotesContext temp)
        {
            context = temp;  // this is doing what we used to do in the controller
        }

        public IQueryable<Quote> quotes => context.quotes;

        public void Save()
        {
            context.SaveChanges();
        }

        public void Add(Quote p)
        {
            context.Add(p);
            context.SaveChanges();
        }

        public void Delete(Quote p)
        {
            context.Remove(p);
            context.SaveChanges();
        }

        public void Update(Quote p)
        {
            context.Update(p);
            context.SaveChanges();
        }
    }
}