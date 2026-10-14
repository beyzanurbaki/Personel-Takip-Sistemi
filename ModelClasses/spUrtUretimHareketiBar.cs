using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModelClasses
{
    public class spUrtUretimHareketiBar
    {
        [Key]
        public int nUserID { get; set; }

        public int lMiktar {  get; set; }

        public DateTime dteKayitTarihi { get; set; }

        public spUrtUser spurtuser { get; set; } //Yabancı anahtar

    }
}
