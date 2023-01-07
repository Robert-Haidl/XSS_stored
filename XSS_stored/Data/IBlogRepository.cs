using Microsoft.OpenApi.Any;
using XSS_stored.Models;

namespace XSS_stored.Data
{
    public interface IBlogRepository
    {
        IEnumerable<Models.BlogItem> getAllBlogItems();
        BlogItem addBlog(Models.BlogItem blogItem);
        IEnumerable<Models.BlogItem> getBlogItemByID(int id);
    }
}


