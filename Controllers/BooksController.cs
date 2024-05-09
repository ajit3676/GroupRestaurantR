using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace HamroLibrary.Controllers
{
    public class BooksController : Controller
    {

            public ActionResult Read(int id)
            {
                // Logic to retrieve the book content based on the provided ID
                var bookContent = GetBookContentFromDatabaseOrService(id);

                // Pass the book content to the view
                return View(bookContent);
            }

            private string GetBookContentFromDatabaseOrService(int id)
            {
                // Logic to retrieve the content of a specific book based on the provided ID
                // This could involve querying a database, calling an API, etc.
                return "This is the content of the book."; // Replace with your actual book content
            }
       
    }
}