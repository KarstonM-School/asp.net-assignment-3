using asp.net_assignment_3.Models;
using Microsoft.AspNetCore.Mvc;

namespace asp.net_assignment_3.Controllers
{
    public class BorrowingController : Controller
    {

        // Get all borrowings
        [HttpGet]
        [Route("borrowings")]
        public IActionResult Index()
        {
            return View(BorrowingRepo.GetBorrowingList());
        }

        // Get certain borrowing
        [HttpGet]
        [Route("borrowings/{id}")]
        public IActionResult Details(int id)
        {
            return View(BorrowingRepo.GetBorrowingById(id));
        }

        // Get borrowing add page 
        [HttpGet]
        [Route("borrowings/add")]
        public IActionResult Add()
        {
            return View();       
        }

        //Add a borrowing
        [HttpPost]
        [Route("borrowings/add")]
        public IActionResult Add(Borrowing borrowing)
        {
            if (ModelState.IsValid)
            {
                BorrowingRepo.AddBorrowing(borrowing);
                return RedirectToAction("Index");
            }
            return View(borrowing);
        }

        // Get borrowing edit page
        [HttpGet]
        [Route("borrowings/edit/{id}")]
        public IActionResult Edit(int id)
        {
            return View(BorrowingRepo.GetBorrowingById(id));
        }

        // Edit borrowing
        [HttpPost]
        [Route("borrowings/edit/{id}")]
        public IActionResult Edit(Borrowing borrowing)
        {
            if (ModelState.IsValid)
            {
                BorrowingRepo.UpdateBorrowing(borrowing);
                return RedirectToAction("Index");
            }
            return View(borrowing);
        }


        // Delete borrowing
        [Route("borrowings/delete/{id}")]
        public IActionResult Delete(Borrowing borrowing)
        {
            BorrowingRepo.DeleteBorrowing(borrowing.Id);
            return RedirectToAction("Index");
        }
    }
}
