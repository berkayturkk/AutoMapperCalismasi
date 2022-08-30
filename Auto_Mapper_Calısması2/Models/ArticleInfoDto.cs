namespace Auto_Mapper_Calısması2.Models
{
    public class ArticleInfoDto
    {
        public int ArticleID { get; set; }
        public string ArticleTitle { get; set; }
        public string CategoryName { get; set; }
    }

    public enum ArticleCategoryName
    {
        Beslenme = 0,
        Antreman = 1

    }
}
