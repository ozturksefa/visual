using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ActionResultTurleri.Models
{
    public partial class Urun
    {
        [Key]
        public int Id { get; set; }
        public string Adi { get; set; }
        public decimal Fiyati { get; set; }
    }
    public partial class Urun
    {
        public int Birimi { get; set; }
    }
}