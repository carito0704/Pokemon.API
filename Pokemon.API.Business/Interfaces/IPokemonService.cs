using PokemonAPI.Models;
using System.Threading.Tasks;

namespace PokemonAPI.Business.Interfaces
{
    public interface IPokemonService
    {
        Task<PokemonXY> GetPokemonAsync(string name);
    }
}
