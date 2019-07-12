﻿using System;
using System.Collections.Generic;
using System.Text;
using Models;

namespace DBRepository.Interfaces
{
    public interface ICommentRepository
    {
        List<Comment> GetList();
        void Delete(int commentId);
        void Add(Comment comment);
    }
}
