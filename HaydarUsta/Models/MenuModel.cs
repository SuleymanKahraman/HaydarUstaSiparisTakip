using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HaydarUsta.Models
{
    public class MenuModel
    {
        public int Musteri_Id { get; set; }
        public string  siparis { get; set; }
        public decimal odemeTurari { get; set; }
        public string odemeYontemi { get; set; }
        public DateTime siparisTarih { get; set; }
        public string adres { get; set; }
        public string telefon { get; set; }



    }
}
