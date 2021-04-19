using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Identity;
using CustomIdentityApp.Models;
using FormIdentity.ViewModels;
using System.Collections.Generic;
using System;

namespace CustomIdentityApp.Controllers
{
    public class UsersController : Controller
    {
        UserManager<User> _userManager;

        public UsersController(UserManager<User> userManager)
        {
            _userManager = userManager;
        }

        public IActionResult Index() => View(_userManager.Users.ToList());

        public IActionResult Create() => View();

        [HttpPost]
        public async Task<IActionResult> Create(CreateUserViewModel model)
        {
            if (ModelState.IsValid)
            {
                User user = new User { Email = model.Email, UserName = model.Email};
                var result = await _userManager.CreateAsync(user, model.Password);
                if (result.Succeeded)
                {
                    return RedirectToAction("Index");
                }
                else
                {
                    foreach (var error in result.Errors)
                    {
                        ModelState.AddModelError(string.Empty, error.Description);
                    }
                }
            }
            return View(model);
        }

        public async Task<IActionResult> Edit(string id)
        {
            User user = await _userManager.FindByIdAsync(id);
            if (user == null)
            {
                return NotFound();
            }
            EditUserViewModel model = new EditUserViewModel { Id = user.Id, lastLoginDate = user.lastLoginDate};
            return View(model);
        }


        [HttpPost]
        public async Task<ActionResult> Delete(string[] selectedUsers)
        {
            foreach (string item in selectedUsers)
            {
                User user = await _userManager.FindByIdAsync(item);
                if (user != null)
                {
                    IdentityResult result = await _userManager.DeleteAsync(user);
                }
            }
            return RedirectToAction("Index");
        }

        [HttpPost]
        public async Task<IActionResult> Block(string[] selectedUsers)
        {
            foreach (string id in selectedUsers)
            {
                User iuser = await _userManager.FindByNameAsync(User.Identity.Name);
                User user = await _userManager.FindByIdAsync(id);
                if (user != null)
                {
                    IdentityResult result = await _userManager.SetLockoutEndDateAsync(user, new DateTime(9999,12,30));
                }
                if (iuser == user)
                {
                    return RedirectToAction("Login", "Account");
                }
            }
            return RedirectToAction("Index");
        }

        [HttpPost]
        public async Task<IActionResult> UnBlock(string[] selectedUsers)
        {
            foreach (string id in selectedUsers)
            {
                User user = await _userManager.FindByIdAsync(id);
                if (user != null)
                {
                    IdentityResult result = await _userManager.SetLockoutEndDateAsync(user, null);
                }
            }
            return RedirectToAction("Index");
        }
    }
}
