using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using Microsoft.AspNetCore.Http; // Added for IFormFile
using System.Collections.Generic;

namespace ToletHome.Controllers
{
    public class HomeController : Controller
    {
        // 1. Home Page
        public IActionResult Index()
        {
            return View();
        }

        // 2. Navigation to the Form Page
        // This MUST exist for the button in Index.cshtml to work
        public IActionResult ListProperty()
        {
            return View();
        }

        // 3. Category Pages
        public IActionResult Apartments() => View();
        public IActionResult AmazingPools() => View();
        public IActionResult Cabins() => View();
        public IActionResult Beachfront() => View();
        public IActionResult Countryside() => View();

        // 4. Authentication Pages
        public IActionResult SignUp() => View();
        public IActionResult SignIn() => View();

        // 5. Property Information
        public IActionResult PropertyDetails() => View();

        // 6. Form Submission Logic
        [HttpPost]
        public IActionResult SubmitProperty(string Title, string Category, string Price, string Address, string Description, List<IFormFile> Files)
        {
            // Implementation: Save to DB or Storage here
            
            TempData["SuccessMessage"] = "Thank you! Your property has been submitted for verification.";
            
            // Redirecting back to Index after successful post
            return RedirectToAction("Index");
        }

        // 7. Error Handling
        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View();
        }
    }
}