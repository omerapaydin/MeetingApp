using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MeetingApp.Models;
using Microsoft.AspNetCore.Components.Routing;
using Microsoft.AspNetCore.Mvc;

namespace MeetingApp.Controllers
{
    public class HomeController:Controller
    {
        public IActionResult Index()
        {
            int saat = DateTime.Now.Hour;
            ViewBag.Selamlama = saat > 12 ? "İyi Akşamlar":"Günaydın"; 
            int UserCount = Repository.Users.Where(i => i.WillAttend == true).Count();
            
            
            var meetinginfo = new Meetinginfo () 
            {
                Id = 1,
                Location="İstanbul",
                Date = new DateTime(2024,01,20,20,0,0),
                NumberOfPeople = UserCount
                
            };
            return View(meetinginfo);
        }
    }
}