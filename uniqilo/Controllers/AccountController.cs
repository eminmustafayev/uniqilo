using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using uniqilo.Models;
using uniqilo.ViewModel.Auths;

namespace uniqilo.Controllers
{
    public class AccountController(UserManager<User> userManager) : Controller
    {
        public IActionResult Register()
        {
            return View();
        }
        [HttpPost]

        public async Task<IActionResult> Register(UserCreateVM vm)
        {
            if (!ModelState.IsValid)
                return View();
            User user = new User
            {
                Email = vm.Email,
                FulllNamme = vm.Fullname,
                UserName = vm.Username,
                ProfilImage = "photo.jpg"
            };
            var result = await userManager.CreateAsync(user, vm.Password);
            if (!result.Succeeded)
            {
                foreach (var error in result.Errors)
                {
                    ModelState.AddModelError("", error.Description);
                }
                return View();
            }
            return View();
        }
    }
}
