using System.Collections.Generic;

namespace Auto_Mapper_Calısması2.Models
{
    public class Category
    {
        public int CategoryID { get; set; }
        public string CategoryName { get; set; }
        public List<Article> CategoryArticles { get; set; }
    }
}
