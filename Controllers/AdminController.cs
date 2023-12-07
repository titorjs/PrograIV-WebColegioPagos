using WebColegioPagos.Models;
using Microsoft.AspNetCore.Mvc;
using WebColegioPagos.Services;
using WebColegioPagos.Models.Data;

namespace WebColegioPagos.Controllers
{
    public class AdminController : Controller
    {
        private readonly IApiService _apiService;

        public AdminController(IApiService apiService)
        {
            _apiService = apiService;
        }
        // GET: EstudianteController
        public async Task<IActionResult> Index()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Index(Admin admin)
        {
            Boolean login = await _apiService.loginAdmin(admin);
            if (login)
            {
                return RedirectToAction("Index", "Home");
            }
            return RedirectToAction("Index");
        }
    }
}
