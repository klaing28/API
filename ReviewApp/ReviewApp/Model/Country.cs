namespace ReviewApp.Model
{
    public class Country
    {
        public int ID { get; set; }
        public string Name { get; set; }

        public ICollection<PokemonCategory> PokemonCategories { get; set; }
    }
}
