using Microsoft.AspNetCore.Mvc;
using btk_akademi.Models;
using btk_akademi.Models;

namespace btk_akademi.Controllers
{
    public class CourseController : Controller
    {
        public IActionResult Index()
        {
            var model = Repository.Application; 
            return View(model);
        }
        public IActionResult Apply() /* get metodu için*/
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]/* formu dogrula sahtecılık olmasın*/
        public IActionResult Apply([FromForm]Candidate model)/* veimız formdan gelıyor diye koselı parantez ıle belirtik*/
        {
            if (Repository.Application.Any(c=>c.Email.Equals(model.Email)))
            {
                ModelState.AddModelError("","Hala hazırda bir başvurunuz var");
            }
            if (ModelState.IsValid)
            {
                Repository.Add(model);
                return View("Feedback", model);
            }
            return View();
        } 
    }
}
