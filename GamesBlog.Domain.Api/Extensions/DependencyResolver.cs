using GamesBlog.Domain.Handlers;
using GamesBlog.Domain.Infra.Context;
using GamesBlog.Domain.Infra.Repositories;
using GamesBlog.Domain.Repositories.Contracts;
using Microsoft.EntityFrameworkCore;

namespace GamesBlog.Domain.Api.Extensions
{
    public static class DependencyResolver
    {
        public static void Resolve(this WebApplicationBuilder builder)
        {
            var connectionString = builder.Configuration.GetConnectionString("WebApiDatabase");

            //builder.Services.AddDbContext<DatabaseContext>(options =>
            //{
            //    options.UseNpgsql(connectionString);
            //});


            builder.Services.AddDbContext<DatabaseContext>(x => x.UseInMemoryDatabase("DbMem"));

            // REPOSITORIES
            builder.Services.AddScoped<IArticlesRepository, ArticlesRepository>();

            // HANDLERS
            builder.Services.AddScoped<ArticleHandler, ArticleHandler>();
        }
    }
}
