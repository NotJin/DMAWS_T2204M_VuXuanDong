using Microsoft.AspNetCore.Mvc;

namespace DMAWS_T2204M_VuXuanDong.Controllers
{
    public class EmployeesController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
