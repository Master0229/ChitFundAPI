using ChitFundAPI.Models;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ChitFundAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AdminController : Controller
    {
        public IConfiguration Configuration { get; set; }

        private IdentityModel _dbContext;

        public AdminController(IdentityModel dbContext, IConfiguration configuration)
        {
            _dbContext = dbContext;
            Configuration = configuration;
        }

        [EnableCors("MyAllowSpecificOrigins")]
        [HttpGet("Getusers")]
        public IActionResult Getusers(int CompanyId)
        {
            List<User> users = _dbContext.Users.Where(x => x.CompanyId == CompanyId).ToList();
            return Ok(users);

        }

        [EnableCors("MyAllowSpecificOrigins")]
        [HttpGet("Getplans")]
        public IActionResult Getplans(int CompanyId)
        {
            List<Plan> plans = _dbContext.Plans.Where(x => x.CompanyId == CompanyId).ToList();
            return Ok(plans);

        }

        [EnableCors("MyAllowSpecificOrigins")]
        [HttpGet("GetpaymentTypes")]
        public IActionResult GetpaymentTypes(int CompanyId)
        {
            List<PaymentType> paymentTypes = _dbContext.PaymentTypes.Where(x => x.CompanyId == CompanyId).ToList();
            return Ok(paymentTypes);

        }

        // GET: AdminController
        public ActionResult Index()
        {
            return View();
        }

        // GET: AdminController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: AdminController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: AdminController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: AdminController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: AdminController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: AdminController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: AdminController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}