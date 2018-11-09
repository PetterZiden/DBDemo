using Acme.Models;
using Acme.Models.Entities;
using Microsoft.AspNetCore.Mvc;

namespace Acme.Controllers
{
    public class CustomersController : Controller
    {
        CustomersService _service;

        public CustomersController(CustomersService service)
        {
            _service = service;
        }

        [Route("")]
        [HttpGet]
        public IActionResult Index()
        {
            return View(_service.GetAll());
        }

        [Route("create")]
        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [Route("create")]
        [HttpPost]
        public IActionResult Create(Customer customer)
        {
            if (!ModelState.IsValid)
            {
                return View(customer);
            }
            _service.Add(customer);

            return RedirectToAction(nameof(Index));
        }
    }
}