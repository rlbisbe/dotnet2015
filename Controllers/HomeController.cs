using Microsoft.AspNet.Mvc;

namespace MvcSample.Web
{
    public class HomeController : Controller
    {
        private ICervezaRepository _cervezaRepository;

        public HomeController (ICervezaRepository repository) 
        {
            _cervezaRepository = repository;
        }

        public IActionResult Index()
        {
            return View(_cervezaRepository.GetCervezas());
        }
    }
}
