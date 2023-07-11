using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using ShoppingListApp.Models;
using ShoppingListApp.ViewModels;

namespace ShoppingListApp.Controllers
{
    public class DashboardController : Controller
    {

        private AppDbContext _context;

        private readonly IMapper _mapper;

        

        public DashboardController(AppDbContext context, IMapper mapper)
        {
            _context = context;

            _mapper = mapper;
        }

        public IActionResult Index()
        {
            return View();
        }


        [HttpGet]//Default
        public IActionResult AddAddress()
        {
            return View();
        }

        [HttpPost]
        public IActionResult AddAddress(AddressViewModel newAddress)
        {
            IActionResult result = null;

            if (ModelState.IsValid)
            {
                try
                {
                    newAddress.UserId = 1;//will be updated

                    _context.Addresses.Add(_mapper.Map<Address>(newAddress));

                    _context.SaveChanges();

                    return RedirectToAction("Index");
                }
                catch (Exception)
                {

                    result = View();
                }

            }
            else
            {
                result = View();

            }

            

            return result;
        }


        public IActionResult MyAddresses()
        {
            int userId = 1;// will be updated

            var addresses = _context.Addresses.Where(x => x.UserId == userId);

            return View(_mapper.Map<List<AddressViewModel>>(addresses));
        }

        public IActionResult RemoveAddress(int id)
        {
            var address = _context.Addresses.Find(id);

            _context.Addresses.Remove(address);

            _context.SaveChanges();

            return RedirectToAction("MyAddresses","Dashboard");
        }


        [HttpGet]//Default
        public IActionResult UpdateAddress(int id)
        {
            var address = _context.Addresses.Find(id);

            
            return View(_mapper.Map<AddressViewModel>(address));
        }

        [HttpPost]
        public IActionResult UpdateAddress(AddressViewModel updateAddress)
        {
            IActionResult result = null;

            if (ModelState.IsValid)
            {
                try
                {
                    updateAddress.UserId = 1;//will be updated

                    _context.Addresses.Update(_mapper.Map<Address>(updateAddress));

                    _context.SaveChanges();

                    return RedirectToAction("MyAddresses", "Dashboard");
                }
                catch (Exception)
                {

                    result = View();
                }

            }
            else
            {
                result = View();

            }

            

            return result;
        }
    }
}
