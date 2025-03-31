using asp.net_assignment_3.Models;
using Microsoft.AspNetCore.Mvc;

namespace asp.net_assignment_3.Controllers
{
    public class BookController : Controller
    {
        // Get all books
        [HttpGet]
        [Route("books")]
        public IActionResult Index()
        {                                                   
            return View(BookRepo.GetBookList()); 
        }

        // Get certain book
        [HttpGet]
        [Route("books/{id}")]
        public IActionResult Details(int id)
        {
            return View(BookRepo.GetBookById(id));
        }

        // Get Book add page
        [HttpGet]
        [Route("books/add")]
        public IActionResult Add()
        {
            return View();
        }

        // Add a book
        [HttpPost]
        [Route("books/add")]
        public IActionResult Add(Book book)
        {
            if (ModelState.IsValid)
            {
                BookRepo.AddBook(book);
                return RedirectToAction("Index");
            }
            return View(book);
        }

        // Get book edit page
        [HttpGet]
        [Route("books/edit/{id}")]
        public IActionResult Edit(int id)
        {
            return View(BookRepo.GetBookById(id));
        }

        // edit book
        [HttpPost]
        [Route("books/edit/{id}")]
        public IActionResult Edit(Book book)
        {
            if (ModelState.IsValid)
            {
                BookRepo.UpdateBook(book);
                return RedirectToAction("Index");
            }
            return View(book);
        }

        // Delete book
        [HttpGet]
        [Route("books/delete/{id}")]
        public IActionResult Delete(Book book)
        {
            BookRepo.DeleteBook(book.Id);
            return RedirectToAction("Index");
        }
    }
}
