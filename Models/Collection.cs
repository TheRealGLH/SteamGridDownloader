    namespace models;
    
    public class Collection
    {
    public Collection(List<object> grids, List<Hero> heroes, List<Logo> logos, List<object> icons)
    {
        this.grids = grids;
        this.heroes = heroes;
        this.logos = logos;
        this.icons = icons;
    }

    public List<object> grids { get; set; }
        public List<Hero> heroes { get; set; }
        public List<Logo> logos { get; set; }
        public List<object> icons { get; set; }
    }
