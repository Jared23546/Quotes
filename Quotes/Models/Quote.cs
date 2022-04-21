using System;
using System.ComponentModel.DataAnnotations;

namespace Quotes.Models
{
    public class Quote
    {
        [Key]
        [Required]
        public int QuoteId { get; set; }
        [Required]
        public string TheQuote { get; set; }
        [Required]
        public string Author { get; set; }
        public DateTime Date { get; set; }
        public string Subject { get; set; }
        public string Citation { get; set; }
    }
}
