    public class Icon
    {
    public Icon(int id, string style, int width, int height, bool nsfw,
     bool humor, string notes, string language, string url, string thumb,
      bool @lock, bool epilepsy, int upvotes, int downvotes, int downloads,
       int hearts, bool can_vote, int date, string mime, bool is_animated,
        bool is_deleted, object animation_type, bool processing, bool show_boop,
         Author author, Game game)
    {
        this.id = id;
        this.style = style;
        this.width = width;
        this.height = height;
        this.nsfw = nsfw;
        this.humor = humor;
        this.notes = notes;
        this.language = language;
        this.url = url;
        this.thumb = thumb;
        this.@lock = @lock;
        this.epilepsy = epilepsy;
        this.upvotes = upvotes;
        this.downvotes = downvotes;
        this.downloads = downloads;
        this.hearts = hearts;
        this.can_vote = can_vote;
        this.date = date;
        this.mime = mime;
        this.is_animated = is_animated;
        this.is_deleted = is_deleted;
        this.animation_type = animation_type;
        this.processing = processing;
        this.show_boop = show_boop;
        this.author = author;
        this.game = game;
    }

    public int id { get; set; }
        public string style { get; set; }
        public int width { get; set; }
        public int height { get; set; }
        public bool nsfw { get; set; }
        public bool humor { get; set; }
        public string notes { get; set; }
        public string language { get; set; }
        public string url { get; set; }
        public string thumb { get; set; }
        public bool @lock { get; set; }
        public bool epilepsy { get; set; }
        public int upvotes { get; set; }
        public int downvotes { get; set; }
        public int downloads { get; set; }
        public int hearts { get; set; }
        public bool can_vote { get; set; }
        public int date { get; set; }
        public string mime { get; set; }
        public bool is_animated { get; set; }
        public bool is_deleted { get; set; }
        public object animation_type { get; set; }
        public bool processing { get; set; }
        public bool show_boop { get; set; }
        public Author author { get; set; }
        public Game game { get; set; }
    }
