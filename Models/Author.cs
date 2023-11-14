    namespace models;
    
    public class Author
    {
    public Author(string name, string steam64, string avatar, List<object> badges)
    {
        this.name = name;
        this.steam64 = steam64;
        this.avatar = avatar;
        this.badges = badges;
    }

    public string name { get; set; }
        public string steam64 { get; set; }
        public string avatar { get; set; }
        public List<object> badges { get; set; }
    }