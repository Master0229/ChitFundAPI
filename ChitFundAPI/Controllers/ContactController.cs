using ChitFundAPI.Models;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.IdentityModel.Tokens.Jwt;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace ChitFundAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]

    public class ContactController : Controller
    {

        public IConfiguration Configuration { get; set; }

        private IdentityModel _dbContext;

        public ContactController(IdentityModel dbContext, IConfiguration configuration)
        {
            _dbContext = dbContext;
            Configuration = configuration;
        }

        [EnableCors("MyAllowSpecificOrigins")]
        [HttpGet("Getparentcontact")]
        public IActionResult Getparentcontact()
        {
            List<Parentcontact> group = _dbContext.Parentcontacts.ToList();
            return Ok(group);

        }

        [EnableCors("MyAllowSpecificOrigins")]
        [HttpPost("Addparentcontact")]
        public IActionResult Addparentcontact([FromBody]TotalContact group)
        {
            try
            {
                //Parentcontact group = Groupobj.ToObject<Parentcontact>();
                //Parentcontact group = JsonSerializer.Deserialize<Parentcontact>(Groupobj);
                //Parentcontact group = jsonObj.ToObject<Parentcontact>();
                Parentcontact pcontact = group.pcontact;
                _dbContext.Parentcontacts.Add(pcontact);
                _dbContext.SaveChanges();

                Contact contact = group.contact;
                contact.ParentcontactId = pcontact.Id;

                _dbContext.Contacts.Add(contact);
                _dbContext.SaveChanges();
                var response = new
                {
                    status = 200,
                    msg = "Group added successfully",
                    group = group
                };
                return Ok(response);
            }
            catch (Exception ex)
            {
                var response = new
                {
                    status = 0,
                    msg = "OOPS! Something went wrong",
                    error = new Exception(ex.Message, ex.InnerException)
                };
                return Ok(response);
            }

        }
        //[HttpPost]
        //public async Task<ActionResult<Parentcontact>> CreateEmployee(Parentcontact employee)
        //{
        //    try
        //    {
        //        var createdEmployee = await IConfiguration.AddEmployee(employee);

        //        return CreatedAtAction(nameof(Getparentcontact),
        //            new { id = createdEmployee.Id }, createdEmployee);
        //    }
        //    catch (Exception)
        //    {
        //        return StatusCode(StatusCodes.Status500InternalServerError,
        //            "Error creating new employee record");
        //    }
        //}

        //Queen 07-03-2023
        [EnableCors("MyAllowSpecificOrigins")]
        [HttpGet("Getcontact")]
        public IActionResult Getcontact(int CompanyId)
        {
            var contact = from c in _dbContext.Contacts
                          join g in _dbContext.Parentcontacts on c.ParentcontactId equals g.Id
                          where c.CompanyId == CompanyId
                          select new { c.Name, c.Address, c.City, c.PhoneNumber, groupName = g.Name };
            return Ok(contact);

        }

        [EnableCors("MyAllowSpecificOrigins")]
        [HttpGet("Getcontactplandata")]
        public IActionResult Getcontactplandata(int ContactId)
        {
            var conplans = from pa in _dbContext.PlanAssigns
                           join p in _dbContext.Plans on pa.PlanId equals p.Id
                           where pa.ContactId == ContactId
                           select new { p.Name, p.Amount, p.Invoice };
            return Ok(conplans);

        }

        // GET: ContactController
        public ActionResult Index()
        {
            return View();
        }

        // GET: ContactController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: ContactController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: ContactController/Create
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

        // GET: ContactController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: ContactController/Edit/5
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

        // GET: ContactController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: ContactController/Delete/5
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

    public class TotalContact
    {
        public Parentcontact pcontact { get; set; }
        public Contact contact { get; set; }
    }
}