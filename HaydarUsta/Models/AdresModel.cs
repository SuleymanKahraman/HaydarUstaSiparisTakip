using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HaydarUsta.Models
{
    public class AdresModel
    {
        public int Id { get; set; }
        public int  musteri_Id { get; set; }
        public string baslik { get; set; }
        public string adres { get; set; }
        public string telefon { get; set; }
    }
}
