using System;
using Quotes.Models;
using Microsoft.EntityFrameworkCore;

namespace Quotes.Models
{
    public class QuotesContext : DbContext
    {
        public QuotesContext (DbContextOptions<QuotesContext> options) : base (options)
        {

        }

        public DbSet<Quote> quotes { get; set; }
    }
}
