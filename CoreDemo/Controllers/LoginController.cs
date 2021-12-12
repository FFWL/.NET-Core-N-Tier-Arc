﻿using DataAccessLayer.Concrete;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;

namespace CoreDemo.Controllers
{
    public class LoginController : Controller
    {
        [AllowAnonymous]
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        [AllowAnonymous]
        public async Task<IActionResult> Index(Writer p)
        {
            Context c = new Context();
            var dataValue = c.Writers.FirstOrDefault(x => x.writerMail == p.writerMail && x.writerPassword == p.writerPassword);
            if(dataValue != null)
            {
                var claims = new List<Claim>
                    {
                    new Claim(ClaimTypes.Name,p.writerMail)
                };
                var userIdentity = new ClaimsIdentity(claims,"a");
                ClaimsPrincipal principal = new ClaimsPrincipal(userIdentity);
                await HttpContext.SignInAsync(principal);
                return RedirectToAction("Index", "Writer");
            }
            else
            {
                return View();
            }
        }
    }
}


//Context c = new Context();
//var dataValue = c.Writers.FirstOrDefault(x => x.writerMail == p.writerMail && x.writerPassword == p.writerPassword);

//if (dataValue != null)
//{
//    HttpContext.Session.SetString("username", p.writerMail);
//    return RedirectToAction("Index", "Writer");
//}
//else
//{
//    return View();
//}