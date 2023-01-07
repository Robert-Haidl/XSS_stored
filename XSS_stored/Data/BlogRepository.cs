using XSS_stored.Models;

namespace XSS_stored.Data
{
    public class BlogRepository : IBlogRepository
    {
        private readonly Context _ctx;

        public BlogRepository(Context ctx)
        {
            _ctx = ctx;
        }

        public BlogItem addBlog(BlogItem blogItem)
        {
            _ctx.Add(blogItem);
            _ctx.SaveChanges();
            return blogItem;

        }

        public IEnumerable<Models.BlogItem> getAllBlogItems()
        {
            return _ctx.BlogItems
                .OrderBy(p => p.createdDate)
                .ToList();
        }

        public IEnumerable<Models.BlogItem> getBlogItemByID(int id)
        {
            return _ctx.BlogItems
                .Where(i => i.id == id)
                .OrderBy(p => p.createdDate)
                .ToList();
        }

    }
}



