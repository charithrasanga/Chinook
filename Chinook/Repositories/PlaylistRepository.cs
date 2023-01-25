using Chinook.Repositories.GenericRepository;
using System.Linq.Expressions;

namespace Chinook.Repositories
{

    public class PlaylistRepository : RepositoryBase<Models.Playlist>, IPlaylistRepository
    {
        public PlaylistRepository(ChinookContext context) : base(context)
        {
        }
    }

}
