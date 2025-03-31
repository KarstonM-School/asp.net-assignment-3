using asp.net_assignment_3.Models;
using Microsoft.AspNetCore.Mvc;

namespace asp.net_assignment_3.Controllers
{
    public class ReaderController : Controller
    {
        // Get all readers
        [HttpGet]
        [Route("readers")]
        public IActionResult Index()
        {
            return View(ReaderRepo.GetReaderList());
        }

        // Get certain reader
        [HttpGet]
        [Route("readers/{id}")]
        public IActionResult Details(int id)
        {
            return View(ReaderRepo.GetReaderById(id));
        }

        // Get reader add page
        [HttpGet]
        [Route("readers/add")]
        public IActionResult Add()
        {
            return View();    
        }

        [HttpPost]
        [Route("readers/add")]
        public IActionResult Add(Reader reader)
        {
            if (ModelState.IsValid)
            {
                ReaderRepo.AddReader(reader);
                return RedirectToAction("Index");
            }
            return View(reader);
        }

        // Get reader edit page
        [HttpGet]
        [Route("readers/edit/{id}")]
        public IActionResult Edit(int id)
        {
            return View(ReaderRepo.GetReaderById(id));
        }

        // edit reader
        [HttpPost]
        [Route("readers/edit/{id}")]
        public IActionResult Edit(Reader reader)
        {
            if (ModelState.IsValid)
            {
                ReaderRepo.UpdateReader(reader);
                return RedirectToAction("Index");
            }
            return View(reader);
        }

        // Delete reader
        [HttpGet]
        [Route("readers/delete/{id}")]
        public IActionResult Delete(Reader reader)
        {
            ReaderRepo.DeleteReader(reader.Id);
            return RedirectToAction("index");
        }
    }
}
