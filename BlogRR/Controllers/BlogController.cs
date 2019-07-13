﻿using Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
//using PersonalPortal.Services.Interfaces;
//using PersonalPortal.ViewModels;
using System.Collections.Generic;
using System.Threading.Tasks;
using DBRepository.Interfaces;

namespace BlogRR.Controllers
{
    [Route("api/[controller]")]
    public class BlogController : Controller
    {
        IBlogRepository _blogRepository;

        public BlogController(IBlogRepository blogRepository)
        {
            _blogRepository = blogRepository;
        }

        [Route("page")]
        [HttpGet]
        public async Task<Page<Post>> GetPosts(int pageIndex, string tag)
        {
            return await _blogRepository.GetPosts(pageIndex, 10, tag);
        }
    }
}