using CrudBucketMVC.DataAccess;
using Microsoft.AspNetCore.Mvc;

namespace CrudBucketMVC.Controllers
{
    public class MuffinsController : Controller
    {
        private readonly CrudBucketContext _context;

        public MuffinsController(CrudBucketContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            var muffins = _context.Muffins.ToList();
            return View(muffins);
        }
    }
}
