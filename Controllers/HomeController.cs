using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Microsoft.AspNetCore.Mvc;
using PartyInvites.Models;
using MimeKit;

namespace PartyInvites.Controllers {
  public class HomeController : Controller {
    public ViewResult Index() {
      int hour = DateTime.Now.Hour;
      ViewBag.Greeting = hour < 12 ? "Good Morning" : "Good Afternoon";
      return View();
    }
    
    [HttpGet]
    public ViewResult RsvpForm() {
      return View();
    }
    
    [HttpPost]
    public ViewResult RsvpForm(GuestResponse guestResponse) 
    {
      if (ModelState.IsValid) {
                // TODO: Email response to the party organizer
                
                return View("Thanks", guestResponse);
      } else {
    // there is a validation error
        return View();
    }
    }
  }
}