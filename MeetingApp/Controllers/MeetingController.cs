using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MeetingApp.Models;
using Microsoft.AspNetCore.Mvc;

namespace MeetingApp.Controllers
{
    public class MeetingController:Controller
    {
        
        [HttpGet]
        public IActionResult Apply()
        {
                return View();
        } 
        [HttpPost]
        public IActionResult Apply(UserInfo model)
        {
                if(ModelState.IsValid){

                Repository.CreateUser(model);
                ViewBag.UserCount = Repository.Users.Where(i => i.WillAttend == true).Count();
                return View("Thanks",model);
                };
                return View(model);
        } 
        public IActionResult List()
        {
                return View(Repository.Users);
        } 
        public IActionResult Details(int id)
        {
                return View(Repository.GetById(id));
        } 
    }
}