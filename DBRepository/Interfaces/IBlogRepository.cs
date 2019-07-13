﻿using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Models;

namespace DBRepository.Interfaces
{
    public interface IBlogRepository
    {
        Task<Page<Post>> GetPosts(int pageIndex, int v, string tag);
    }
}
