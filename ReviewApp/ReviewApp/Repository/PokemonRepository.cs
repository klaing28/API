using ReviewApp.Data;
using ReviewApp.Interface;
using ReviewApp.Model;
using ReviewApp.DTO;

namespace ReviewApp.Repository
{
    public class PokemonRepository: IPokemonRepository
    {

        private readonly DataCX _context;
        public PokemonRepository(DataCX context) 
        {
        _context= context;
        }

        public Pokemon GetPokemon(int id)
        {
            return _context.Pokemon.Where(p=>p.ID == id).FirstOrDefault();
        }

        public Pokemon GetPokemon(string name)
        {
            return _context.Pokemon.Where(p => p.Name == name).FirstOrDefault();
        }

        public decimal GetPokemonRating(int pokeID)
        {
            var review = _context.Rewievs.Where(p => p.Pokemon.ID == pokeID);

            if(review.Count() <= 0) 
                return 0; 
            
            return ((decimal)review.Sum(r=>r.Rating)/review.Count());
        }

        public ICollection<Pokemon> GetPokemons() 
        {
            return _context.Pokemon.OrderBy(p=>p.ID).ToList();
        }

        public bool PokemonExists(int pokeID)
        {
            return _context.Pokemon.Any(p => p.ID == pokeID);
        }
    }
}
