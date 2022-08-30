namespace Auto_Mapper_Calısması2.Models
{
    public class Article
    {
        public int ArticleID { get; set; }
        public string ArticleTitle { get; set; }
        public int CategoryID { get; set; }
        public Category ArticleCategory { get; set; }  
    }
}
