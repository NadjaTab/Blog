using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Models;

namespace DBRepository.Interfaces
{
    public interface IBlogRepository
    {
        Task<Page<Post>> GetPosts(int index, int pageSize, string tag = null);
        Task<Post> GetPost(int postInd);
        Task<List<string>> GetAllTagnames();
        Task AddPost(Post post);
        Task DeletePost(int postId);
        Task DeleteComment(int commentId);
    }
}
