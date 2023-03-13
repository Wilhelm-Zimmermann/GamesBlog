namespace GamesBlog.Domain.Entitties
{
    public class BlogPost : Base
    {
        public IList<Article> Articles { get; private set; }
        public Title BlogPostTitle { get; private set; }
        public string BlogPostImage { get; private set; }

        public BlogPost(Title blogPostTitle, string blogPostImage)
        {
            BlogPostTitle = blogPostTitle;
            BlogPostImage = blogPostImage;
        }

        public void AddArticle(Article article)
        {
            Articles.Add(article);
        }
        
        public void RemoveArticle(Article article)
        {
            Articles.Remove(article);
        }
    }
}
