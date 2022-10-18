


namespace Ustora.Data.Repositories
{
    public class CountryRepository : BaseRepository<Country>, ICountryRepository
    {
        private readonly ApplicationDbContext _context;

        public CountryRepository(ApplicationDbContext context) : base(context)
        {
        }

        public IEnumerable<Country> SpecialMethod()
        {
            throw new NotImplementedException();
        }
    }
}