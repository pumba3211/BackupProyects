using System.Collections.Generic;
namespace SuperZapatosApi.Models
{
    public class Store
    {
        public Store()
        {
            this.Articles = new HashSet<Article>();
        }
        public int StoreID { get; set; }
        public string name { get; set; }
        public string addres { get; set; }

        public virtual ICollection<Article> Articles { get; set; }
    }
}
