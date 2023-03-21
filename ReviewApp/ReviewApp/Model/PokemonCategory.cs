namespace ReviewApp.Model
{
    public class PokemonCategory
    {
        public int PokemonID { get; set; }  
        public int CategoryId { get; set;}

        public Pokemon Pokemon { get; set;}
        public Category Category { get; set;}
    }
}
