using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using workshop.webapi.DataModels;
using workshop.webapi.Models;
using workshop.webapi.Repository;

namespace workshop.webapi.Endpoints
{
    public static class BlogEndpoint
    {
        public static void ConfigureBlogEndpoint(this WebApplication app)
        {
            var blog = app.MapGroup("blog");

            blog.MapGet("/posts/", GetBlogPosts);
        }
        [Authorize("Admin")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public static async Task<IResult> GetBlogPosts(IRepository<Post> repository)
        {
            var results = await repository.Get();
         
            return TypedResults.Ok(results);
        }


    }
}
