using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Quotes.Models;

namespace Quotes.Controllers
{
    public class HomeController : Controller
    {
        private IQuotesRepository repo { get; set; }

        public HomeController(IQuotesRepository temp)
        {
            repo = temp;
        }

        public IActionResult Index()
        {
            var quotes = repo.quotes
                .OrderBy(x => x.Author)
                .ToList();
            return View(quotes);
        }

        [HttpGet]
        public IActionResult Enter()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Enter(Quote q)
        {
            
            if (ModelState.IsValid)
            {
                repo.Add(q);
                repo.Save();
                return RedirectToAction("Index");
            }
            else
            {
                return View("Enter", q);
            }

            
        }

        [HttpGet]
        public IActionResult Edit(int QuoteId)
        {
            var quote = repo.quotes.Single(x => x.QuoteId == QuoteId);
            return View("Enter", quote);

        }

        [HttpPost]
        public IActionResult Edit(Quote q)
        {
            if (ModelState.IsValid)
            {
                repo.Update(q);
                
                return RedirectToAction("Index");
            }
            else
            {
                return View("Enter", q);
            }
        }

        public IActionResult Details(int QuoteId)
        {
            var quote = repo.quotes.Single(x => x.QuoteId == QuoteId);
            return View(quote);
        }

        [HttpGet]
        public IActionResult Delete(int QuoteId)
        {
            var quote = repo.quotes.Single(x => x.QuoteId == QuoteId);
            return View(quote);
        }

        [HttpPost]
        public IActionResult Delete(Quote q)
        {
            repo.Delete(q);
            
            return RedirectToAction("Index");
        }

        
    }
}
