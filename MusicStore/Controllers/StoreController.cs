using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MusicStore.Models;

namespace MusicStore.Controllers
{
    public class StoreController : Controller
    {
        MusicStoreEntities storeDb = new MusicStoreEntities();
        // GET: Store
        public ActionResult Index()
        {
            var genres = storeDb.Genres.ToList();
            return View(genres);
        }
        //
        // GET: Store/Browse?gender={genre}
        public ActionResult Browse(string genre)
        {
            var genreModel = storeDb.Genres.Include("Albums").Single(g => g.Name == genre);
            return View(genreModel);
        }
        //
        // GET: Store/Details/{id}
        public ActionResult Details(int id)
        {
            var album = storeDb.Albums.Find(id);
            return View(album);
        }
        //
        // GET: /Store/GenreMenu
        [ChildActionOnly]
        public ActionResult GenreMenu()
        {
            var genres = storeDb.Genres.ToList();
            return PartialView(genres);
        }
    }
}