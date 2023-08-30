using BusinessLayer.Abstract;
using Microsoft.AspNetCore.Mvc;

namespace WebApp.Controllers
{
    public class ChildNameController : Controller
    {
        private readonly IChildNameManager _childNameManager;

        public ChildNameController(IChildNameManager childNameManager)
        {
            _childNameManager = childNameManager;
        }
        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public IActionResult RandomChildName()
        {
            var randomChildName = _childNameManager.RandomChildName().Data;
            
            return Json(new { randomChildName });
        }
    }
}
