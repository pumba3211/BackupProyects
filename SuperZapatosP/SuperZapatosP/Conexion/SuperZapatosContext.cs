using SuperZapatosApi.Models;
using System.Data.Entity;

namespace SuperZapatosApi.Dal
{
    public class SuperZapatosContext : DbContext
    {
        public SuperZapatosContext()
            : base("name=SuperZapatos")
        {
        }
        public virtual DbSet<Article> Article { get; set; }
        public virtual DbSet<Store> Store { get; set; }
    }
}