using System;
namespace SuperZapatosApi.Models
{
    public class Article
    {

        public int ArticleID { get; set; }
        public string name { get; set; }
        public string description { get; set; }
        public Nullable<double> price { get; set; }
        public Nullable<int> total_in_shelf { get; set; }
        public Nullable<int> total_in_vault { get; set; }
        public int StoreID { get; set; }

        public virtual Store Store { get; set; }

    }
}
