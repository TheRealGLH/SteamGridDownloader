    public class Badge
    {
    public Badge(int id, string name, string description, int date, bool isHidden)
    {
        this.id = id;
        this.name = name;
        this.description = description;
        this.date = date;
        this.isHidden = isHidden;
    }

    public int id { get; set; }
        public string name { get; set; }
        public string description { get; set; }
        public int date { get; set; }
        public bool isHidden { get; set; }
    }
