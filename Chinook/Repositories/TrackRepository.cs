using Chinook.Repositories.GenericRepository;

namespace Chinook.Repositories
{
    public class TrackRepository : RepositoryBase<Models.Track>, ITrackRepository
    {
        public TrackRepository(ChinookContext context) : base(context)
        {
        }
    }

}
