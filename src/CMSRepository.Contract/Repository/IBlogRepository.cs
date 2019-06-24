using System.Collections.Generic;
using CMSRepository.Contract.Models;

namespace CMSRepository.Contract.Repository
{
    public interface IBlogRepository
    {
        void AddBlog(Blog blog);

        Blog GetBlog(int blogID);

        List<Blog> GetBlogs(Category category);

        List<Blog> GetBlogs(SubCategory category);

        List<Blog> GetAllBlogs();

        List<Category> GetAvailableCategories();

        List<SubCategory> GetAvailableSubCategories();
    }
}
