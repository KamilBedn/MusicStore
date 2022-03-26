using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MusicStore.Controllers
{
    public class StoreController : Controller
    {
        // GET: Store
        public string Index()
        {
            return "hello from Store.Index()";
        }
        //
        // GET: Store/Browse?gender={genre}
        public string Browse(string genre)
        {
            string message = HttpUtility.HtmlEncode("Store.Browse, Genre = " + genre);

            return message;
        }
        //
        // GET: Store/Details/{id}
        public string Details(int id)
        {
            string message = "Store.Details, ID =" + id;

            return message;
        }
    }
}