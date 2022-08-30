using Auto_Mapper_Calısması2.Models;
using AutoMapper;

namespace Auto_Mapper_Calısması2.MapperProfiles
{
    public class ArticleProfile : Profile
    {
        public ArticleProfile()
        {
            CreateMap<Article, ArticleInfoDto>()
                .ForMember(dest => dest.ArticleID, opt => opt.MapFrom(src => src.ArticleID))
                .ForMember(dest => dest.CategoryName, opt => opt.MapFrom(src => ((ArticleCategoryName)src.CategoryID).ToString()))
                .ForMember(dest => dest.ArticleTitle, opt => opt.MapFrom(src => src.ArticleTitle));
            
                
        }
    }
}
