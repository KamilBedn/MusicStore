using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MusicStore.ViewModel
{
    public class ShoppingCartRemoveViewModel
    {
        public string Message { get; set; }
        public decimal CartTotal { get; set; }
        public int CartCount { get; set; }
        public int ItemCount { get; set; }
        public int DelateId { get; set; }
    }
}