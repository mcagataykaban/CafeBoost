using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace CafeBoost.Data
{
    public class CafeBoostContext : DbContext
    {
        public CafeBoostContext() : base("name = CafeBoostContext")
        {

        }
        public DbSet<Urun> Urunler { get; set; }
        public DbSet<Siparis> Siparisler { get; set; }
        public DbSet<SiparisDetay> SiparisDetaylar { get; set; }

        public int MasaAdet { get; set; } = 20;
    }
}
