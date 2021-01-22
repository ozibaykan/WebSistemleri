using NHibernate.Mapping.ByCode;
using NHibernate.Mapping.ByCode.Conformist;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace finalodev.Models
{
    public class Muzik
    {
        public virtual int muzikid { get; set; }
        public virtual int sanatciid { get; set; }
        public virtual string sanatciadi { get; set; }
        public virtual string sanatcisoyadi { get; set; }
        public virtual string sarki { get; set; }
   
    }



    public class MuzikMap : ClassMapping<Muzik>
    {
        public MuzikMap()
        {
            Table("Muzik");
            Id(x => x.muzikid, m => m.Generator(Generators.Native));
            Property(x => x.sanatciid, c => c.Length(50));
            Property(x => x.sanatciadi, c => c.Length(50));
            Property(x => x.sanatcisoyadi, c => c.Length(50));
            Property(x => x.sarki, c => c.Length(50));

        
        }
    }
}