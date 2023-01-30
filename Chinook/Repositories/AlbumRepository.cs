using Chinook.Repositories.GenericRepository;

namespace Chinook.Repositories
{
    public class AlbumRepository : RepositoryBase<Models.Album>, IAlbumRepository
    {
        public AlbumRepository(ChinookContext context) : base(context)
        {
        }  
    }

}
