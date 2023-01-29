using Chinook.Repositories.GenericRepository;

namespace Chinook.Repositories
{
    public interface IUserPlaylistRepository : IRepositoryBase<Models.UserPlaylist>
    {
       
        Task<Task> EnsureUserHasfavoritePlayListAsync(string userId);
        bool RemoveTrackFromFavouriteList(long trackId, long playListId);
        bool AddTrackToFavouriteList(long trackId, long playListId);
    }

}
