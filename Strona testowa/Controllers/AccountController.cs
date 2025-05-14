using Microsoft.AspNetCore.Mvc;
using System.Text.RegularExpressions;

namespace Strona_testowa.Controllers {
    public class AccountController : Controller {
        [HttpGet]
        public IActionResult Login() {
            return View();
        }

        public IActionResult Formularz() {
            return View();
        }

        [HttpPost]
        public IActionResult Login(string login, string password) {
            if (login == "admin" && password == "admin") {
                ViewData["Message"] = "Witaj, admin";
                return View();
            }
            else {
                ViewData["ErrorMessage"] = "Błędne dane logowania. Spróbuj ponownie.";
                return View();
            }
        }

        [HttpPost]
        public IActionResult Formularz(string name, string secname, string mail, string phone) {
            if (!IsValidPhoneNumber(phone) || !IsValidEmail(mail)) {
                ViewData["ErrorMess"] = "Niepoprawny numer telefonu lub adres e-mail. Spróbuj ponownie.";
                return View();
            }
            ViewData["Mess"] = "Dziękuję za wysłanie danych.";
            return View();
        }

        private bool IsValidPhoneNumber(string phone) {
            return !string.IsNullOrEmpty(phone) && Regex.IsMatch(phone, @"^\d{9,}$");
        }

        private bool IsValidEmail(string email) {
            return !string.IsNullOrEmpty(email) && email.Contains("@");
        }
    }
}
