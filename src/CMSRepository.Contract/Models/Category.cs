using System.Collections.Generic;

namespace CMSRepository.Contract.Models
{
    public class Category
    {
        public string Name { get; set; }
        public SubCategory SubCategory { get; set; }
    }
}