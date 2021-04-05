public class Actors
{
    public Actors(int id, int credits, string name, string linkImdb)
    {
        Id = id;
        Credits = credits;
        Name = name;
        LinkImdb = linkImdb;
    }

    private int Id{get; init;}
    private int Credits{get; init;}
    private string Name{get; init;}    
    private string LinkImdb{get; init;}
}