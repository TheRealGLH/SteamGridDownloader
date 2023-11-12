    public class AuthorData
    {
    public AuthorData(List<Collection> collections, int limit, int total, int current_page)
    {
        this.collections = collections;
        this.limit = limit;
        this.total = total;
        this.current_page = current_page;
    }

    public List<Collection> collections { get; set; }
        public int limit { get; set; }
        public int total { get; set; }
        public int current_page { get; set; }
    }