using System.Collections.Generic;
using System.IO;
using BibleApp.Models;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace BibleApp.Controllers
{
    public class SearchController : Controller
    {
        public IActionResult Index(string searchfor)
        {
            StreamReader r = new StreamReader("wwwroot/Verse_Data/VersesJSON.json");
            var jsonDoc = r.ReadToEnd();
            var bibleVerse = JsonConvert.DeserializeObject<List<BibleVerseModel>>(jsonDoc);
            ViewBag.searchfor = searchfor;
            return View(bibleVerse);
        }
    }
}