using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace ModelClasses
{
    public class spUrtUser
    {
        [Key]
        public int nUserID { get; set; }

        [Required]
        public string sUserName { get; set; }

        // İlişkili Üretim Hareketleri
        public ICollection<spUrtUretimHareketiBar> UretimHareketiBars { get; set; }
    }
}
