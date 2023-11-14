    namespace models;
    
    public class Counts
    {
    public Counts(int grid, int hero, int logo, int icon)
    {
        this.grid = grid;
        this.hero = hero;
        this.logo = logo;
        this.icon = icon;
    }

    public int grid { get; set; }
        public int hero { get; set; }
        public int logo { get; set; }
        public int icon { get; set; }



    }