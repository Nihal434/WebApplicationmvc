namespace WebApplicationmvc.Models.Domain
{
    public class Tag
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string DisplayName { get; set; }
        public ICollection<BlogPost> BlogPosts { get; set; } //one tag can contain many blog posts so we define a relation between tag and blogpost
    }
}
