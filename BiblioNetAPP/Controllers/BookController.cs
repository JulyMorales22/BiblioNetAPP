using BiblioNetAPP.Models;
using BiblioNetAPP.Services;
using Microsoft.AspNetCore.Mvc;

namespace BiblioNetAPP.Controllers
{
    public class BookController : Controller
    {
        private readonly IRepositorieBook repositorieBook;

        //constructor?
        public BookController(IRepositorieBook repositorieBook)
        {
            this.repositorieBook = repositorieBook;
        }
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(Book book) //la variable se debe llamar igual que el modelo pero empezando en minuscula 
        {
            if (!ModelState.IsValid)
            {
                return View(book);
            }
            book.AuthorId = 1;
            //book.Price = 25000;
            repositorieBook.Create(book);
            return View();
        }
    }
}
