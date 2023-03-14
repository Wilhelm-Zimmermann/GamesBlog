using GamesBlog.Domain.Commands;
using GamesBlog.Domain.Handlers;
using Microsoft.AspNetCore.Mvc;

namespace GamesBlog.Domain.Api.Controllers
{
    [ApiController]
    [Route("articles")]
    public class ArticleController : ControllerBase
    {
        [HttpPost]
        [Route("create")]
        public async Task<GenericCommandResult> CreateArticle([FromBody] CreateArticleCommand command, [FromServices] ArticleHandler handler)
        {
            var result =  (GenericCommandResult) await handler.Handle(command);
            
            return result;
        }
    }
}
