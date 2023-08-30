using BusinessLayer.Abstract;
using BusinessLayer.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace WebApp.Controllers
{
    public class AnimalNameController : Controller
    {
        private readonly IAnimalNameManager _animalNameManager;

        public AnimalNameController(IAnimalNameManager animalNameManager)
        {
            _animalNameManager = animalNameManager;
        }
        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public IActionResult RandomAnimalName()
        {
            var randomAnimalName = _animalNameManager.RandomAnimalName().Data;

            return Json(new { randomAnimalName });
        }
    }
}