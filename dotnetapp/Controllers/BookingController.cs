using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
// using gym.Data;
using dotnetapp.Exceptions; 

using dotnetapp.Models;
using System;
using System.Linq;
using System.Threading.Tasks;

namespace dotnetapp.Controllers
{
    public class BookingController : Controller
    {
        private readonly ApplicationDbContext _context;
    
        public BookingController(ApplicationDbContext context)
        {
            _context = context;
        }
    
        public IActionResult Index()
        {
            //write functionality here...
            return null;
        }
    
        public IActionResult Book(int id)
        {
            //write functionality here...
            return null;
        }
    
        [HttpPost]
        public IActionResult Book(int id, int userId)
        {
            //write functionality with SlotBookingException "Slot is full." & "You have already booked this slot."
            return null;
    
        }
    
    }
    
    

}