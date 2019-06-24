using System;

namespace CMSRepository.Contract.Models
{
    public class Blog
    {
        public Blog(
            string meta,
            int pageId,
            string pageHeader,
            string pageContent,
            Category category,
            DateTime date)
        {
            Meta = meta;
            PageID = pageId;
            PageHeader = pageHeader;
            PageContent = pageContent;
            Catagory = category;
            Date = date;
        }

        public string Meta { get; }

        public int PageID { get; }

        public string PageHeader { get; }

        public string PageContent { get; }

        public Category Catagory { get; }

        public DateTime Date { get; }
    }
}
