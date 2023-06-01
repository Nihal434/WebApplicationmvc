namespace WebApplicationmvc.Models.Domain
{
    public class BlogPost
    {
        //all are the variable or property of a website which is stored inside a domain
        public Guid Id { get; set; }  //Guid A Globally Unique Identifier or GUID represents a gigantic identification number — a number so large that it is mathematically guaranteed to be unique
        public string Heading { get; set; } //this is not a nullable property so here we must have to pass the value otherwise it will show an error
       // public string? Heading { get; set; } nullable property(defined by ? after variable type) means it can have null value in database
        public string PageTitle { get; set; }
        public string Content { get; set; }
        public string FeaturedImageUrl { get; set; }
        public string UrlHandle { get; set;}
        public DateTime PublishedDate { get; set; }
        public string Author { get; set; }
        public string Visible { get; set; }


        public ICollection<Tag> Tag { get; set; }    //one blog can have many tag
        //ICollection – interface provides medium functionality which is getting size, adding, removing, and clearing collection i.e. modification of collection.
        //As it inherited from IEnumerable so includes the functionality of IEnumerable.
        //Source for IEnumerable,ICollection , IList also known as generic interfaces
    }
}
