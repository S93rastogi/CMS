using System;
using System.Collections.Generic;
using CMSRepository.Contract.Models;
using CMSRepository.Contract.Repository;

namespace XMLBasedCMSRepository
{
    public class BlogRepository : IBlogRepository
    {
        public void AddBlog(Blog blog)
        {
            throw new NotImplementedException();
        }

        public Blog GetBlog(int blogID)
        {
            throw new NotImplementedException();
        }

        public List<Blog> GetBlogs(Category category)
        {
            throw new NotImplementedException();
        }

        public List<Blog> GetBlogs(SubCategory category)
        {
            throw new NotImplementedException();
        }

        public List<Blog> GetAllBlogs()
        {
            throw new NotImplementedException();
        }

        public List<Category> GetAvailableCategories()
        {
            throw new NotImplementedException();
        }

        public List<SubCategory> GetAvailableSubCategories()
        {
            throw new NotImplementedException();
        }
    }
}
