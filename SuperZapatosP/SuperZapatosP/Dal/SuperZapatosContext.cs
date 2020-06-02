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
        public virtual DbSet<ArticleModel> Article { get; set; }
        public virtual DbSet<StoreModel> Store { get; set; }
    }
}