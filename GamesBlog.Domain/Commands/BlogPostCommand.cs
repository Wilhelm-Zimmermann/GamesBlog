﻿using GamesBlog.Domain.Commands.Contracts;
using GamesBlog.Domain.Entitties;

namespace GamesBlog.Domain.Commands
{
    public class BlogPostCommand : ICommand
    {
        public IList<Article> Articles { get; private set; }
        public Title BlogPostTitle { get; private set; }
        public string BlogPostImage { get; private set; }

        public BlogPostCommand(Title blogPostTitle, string blogPostImage)
        {
            BlogPostTitle = blogPostTitle;
            BlogPostImage = blogPostImage;
        }
    }
}
