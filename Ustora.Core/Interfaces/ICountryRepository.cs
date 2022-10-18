

namespace Ustora.Core.Interfaces
{
    public interface ICountryRepository : IBaseRepository<Country>
    {
        IEnumerable<Country> SpecialMethod();
    }
}