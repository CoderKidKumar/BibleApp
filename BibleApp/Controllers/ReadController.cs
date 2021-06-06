using System.Collections.Generic;
using System.IO;
using BibleApp.Models;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace BibleApp.Controllers
{
    public class ReadController : Controller
    {
        public IActionResult Index(string book, int chapter)
        {
            StreamReader r = new StreamReader("wwwroot/Verse_Data/VersesJSON.json");
            var jsonDoc = r.ReadToEnd();
            var bibleVerse = JsonConvert.DeserializeObject<List<BibleVerseModel>>(jsonDoc);

            ViewBag.Book = book;
            ViewBag.Chapter = chapter;
            return View(bibleVerse);
        }

        public IActionResult Table()
        {
            StreamReader r = new StreamReader("wwwroot/Verse_Data/VersesJSON.json");
            var jsonDoc = r.ReadToEnd();
            var bibleVerse = JsonConvert.DeserializeObject<List<BibleVerseModel>>(jsonDoc);
            return View(bibleVerse);
        }
    }
}