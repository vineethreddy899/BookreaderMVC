﻿using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Web.Models;
using Web.Services;

namespace Web.Controllers
{
    public class AccountController : Controller
    {
        private readonly IAccountPageService _accountPageService;

        public AccountController(IAccountPageService accountPageService)
        {
            _accountPageService = accountPageService;
        }
        public IActionResult Index()
        {
            return View();
        }

        [Route("Sign-up")]
        public IActionResult SignUp()
        {
            return View();
        }

        [HttpPost]
        [Route("Sign-up")]
        public async Task<IActionResult> SignUp(SignUpModel user)
        {
            if (ModelState.IsValid)
            {
                var result = await _accountPageService.CreateUser(user);
                if (!result.Succeeded)
                {
                    foreach (var errorMessage in result.Errors)
                    {
                        ModelState.AddModelError("", errorMessage.Description);
                    }
                    return View(user);
                }
                ModelState.Clear();
                return RedirectToAction("Login", "Account");
            }
            return View();
        }

        [Route("login")]
        public IActionResult Login()
        {
            return View();
        }

        [HttpPost]
        [Route("login")]
        public async Task<IActionResult> Login(LoginModel loginViewModel)
        {

            if (ModelState.IsValid)
            {
                var result = await _accountPageService.LoginUser(loginViewModel);
                if (result.Succeeded)
                {
                    return RedirectToAction("Index", "Home");
                }
                else
                {
                    ModelState.AddModelError("", "Invalid Credentials");
                    return View(loginViewModel);
                }

            }
            return View();
        }

        [Authorize]
        [Route("log-Out")]
        public async Task<IActionResult> LogOut()
        {
            await _accountPageService.SignOut();
            return RedirectToAction("Index", "Home");
        }
    }
}
