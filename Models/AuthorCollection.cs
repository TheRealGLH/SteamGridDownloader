    public class AuthorCollection
    {
    public AuthorCollection(int id, string name, int date, string description, string description_parsed, Counts counts, Author author)
    {
        this.id = id;
        this.name = name;
        this.date = date;
        this.description = description;
        this.description_parsed = description_parsed;
        this.counts = counts;
        this.author = author;
    }

    public int id { get; set; }
        public string name { get; set; }
        public int date { get; set; }
        public string description { get; set; }
        public string description_parsed { get; set; }
        public Counts counts { get; set; }
        public Author author { get; set; }
    }