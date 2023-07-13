using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using ShoppingListApp.Models;
using ShoppingListApp.ViewModels;

namespace ShoppingListApp.Controllers
{
    public class LoginController : Controller
    {
        private readonly IHttpContextAccessor contxt;

        private AppDbContext _context;

        private readonly IMapper _mapper;



        public LoginController(AppDbContext context, IMapper mapper, IHttpContextAccessor httpContextAccessor)
        {
            _context = context;

            _mapper = mapper;

            contxt = httpContextAccessor;
        }

        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]//Default
        public IActionResult Login()
        {
            return View();
        }


        [HttpPost]
        public IActionResult Login(UserViewModel newUser)
        {
            // Check if email and password are provided
            if (newUser.Password != null && newUser.Email != null)
            {
                // Check if a student exists with the provided email and password
                var anyStudent = _context.Users.Any(x => x.Email == newUser.Email && x.Password == newUser.Password);

                

                if (anyStudent)
                {
                    // Fetch student ID
                    var userId = _context.Users.Where(x => x.Email == newUser.Email).Single().Id;

                    TempData["status"] = "successfully logged in";

                    //contxt.HttpContext.Session.SetInt32("userId", userId);

                    return RedirectToAction("Index", "Home");
                }
                else
                {
                    TempData["status"] = "There is no student with these email and password.";

                }
            }
            return RedirectToAction("Index", "Login");
            
        }
    }
}
