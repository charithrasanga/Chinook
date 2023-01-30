using Chinook.Repositories.GenericRepository;

namespace Chinook.Repositories
{
    public class ArtistRepository : RepositoryBase<Models.Artist>, IArtistRepository
    {
        public ArtistRepository(ChinookContext context) : base(context)
        {
        }
    }
}
