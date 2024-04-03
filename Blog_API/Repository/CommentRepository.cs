﻿using Blog_API.Data;
using Blog_API.Interfaces;
using ModelsLibrary;

namespace Blog_API.Repository
{
    public class CommentRepository : ICommentRepository
    {
        private readonly BlogContext blogContext;

        public CommentRepository(BlogContext context) {
            blogContext = context;
        }
        public bool Exists(int Id)
        {
          return (blogContext.Comments.FirstOrDefault(x=>x.Id==Id) is not null)? true : false;
        }

        public Comment GetCommentById(int Id)
        {
            return blogContext.Comments.FirstOrDefault(x => x.Id == Id);
        }

        public int GetCommentCount(int PostId)
        {
            return blogContext.Comments.Where(x=>x.Id== PostId).Count();
        }

        public ICollection<Comment> GetCommentsByPost(int PostId)
        {
            return blogContext.Comments.Where(x=> x.PostId == PostId).ToList();
        }
    }
}
