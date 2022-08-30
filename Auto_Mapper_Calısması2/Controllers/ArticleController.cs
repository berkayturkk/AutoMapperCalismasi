using Auto_Mapper_Calısması2.Models;
using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Auto_Mapper_Calısması2.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ArticleController : ControllerBase
    {
        private readonly IMapper _mapper;

        public ArticleController(IMapper mapper)
        {
            _mapper = mapper;
        }

        [HttpGet]
        public ArticleInfoDto Get()
        {
            var article = new Article
            {
                ArticleID = 1,
                ArticleTitle = "Antreman Süresi",
                CategoryID = 1
            };
            var articleInfo = _mapper.Map<ArticleInfoDto>(article);
            return articleInfo;
        }
    }
}
