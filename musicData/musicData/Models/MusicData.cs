using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace musicData.Models
{
    public class MusicData
    {
        public int Id { get; set; }
        public string Ad { get; set; }
        public string Sanatci { get; set; }
        public string Yapimci { get; set; }
        public long Dinlenme { get; set; }



        public static List<MusicData> VeriListe = new List<MusicData>
        {
            new MusicData
            {
                Id=1,
                Ad="Kalbim ziynet",
                Sanatci="Ozi BAYKAN",
                Yapimci="REAL SENEI",
                Dinlenme=100000,

            },
            new MusicData
            {
                Id=2,
                Ad="Kalbim Çukur",
                Sanatci="Ozi BAYKAN",
                Yapimci="REAL SENEI",
                Dinlenme=200000,

            },

        };
    }
}