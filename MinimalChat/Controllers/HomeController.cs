using Microsoft.AspNetCore.Mvc;
using MinimalChat.Data;
using MinimalChat.Models;
using MinimalChat.Models.Domain;
using System.Diagnostics;

namespace MinimalChat.Controllers
{
    public class HomeController : Controller
    {
        public HomeController(MinimalChatDbContext chatDbContext)
        {
            this.chatDbContext = chatDbContext;
        }
        private readonly ILogger<HomeController> _logger;
        private readonly MinimalChatDbContext chatDbContext;

        //public HomeController(ILogger<HomeController> logger)
        //{
        //    _logger = logger;
        //}
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }
        [HttpGet]
        public IActionResult CreateRoom()
        {
            return View();
        }
        [HttpPost]
        public IActionResult CreateRoom(Rooms room)
        {
            room.DateOfCreation = DateTime.Now;

            chatDbContext.Add(room);
            chatDbContext.SaveChanges();
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}