using System;

using R5T.F0000;


namespace R5T.R0006
{
    public class MetaTagsModel
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public IsSet<string> Robots { get; set; }
        public IsSet<string> FaviconHref { get; set; }

        
        public MetaTagsModel(
            string title,
            string description)
        {
            this.Title = title;
            this.Description = description;
        }
    }
}
