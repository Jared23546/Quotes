using System;
using System.Linq;
using Quotes.Models;

namespace Quotes.Models
{
    public interface IQuotesRepository
    {
        IQueryable<Quote> quotes { get; }

        public void Save();

        public void Add(Quote p);

        public void Delete(Quote p);

        public void Update(Quote p);
    }
}
