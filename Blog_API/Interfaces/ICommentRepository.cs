﻿using ModelsLibrary;
using ModelsLibrary.CommentDto;

namespace Blog_API.Interfaces
{
    public interface ICommentRepository
    {
        bool Exists(int Id);
        ICollection<Comment> GetCommentsByPost(int PostId);
        Comment GetCommentById(int Id);
        int GetCommentCount(int PostId);
        ICollection<Comment> GetCommentsAll();
        bool SaveChanges();
        bool CreateComment(Comment comment);
        Comment CommentCreateToComment(CommentDtoCreate commentCreate,int userId);
    }
}
