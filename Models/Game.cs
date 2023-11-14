    namespace models;
    
    public class Game
    {
    public Game(int id, string name, int release_date, List<object> types, bool verified)
    {
        this.id = id;
        this.name = name;
        this.release_date = release_date;
        this.types = types;
        this.verified = verified;
    }

    public int id { get; set; }
        public string name { get; set; }
        public int release_date { get; set; }
        public List<object> types { get; set; }
        public bool verified { get; set; }
    }
