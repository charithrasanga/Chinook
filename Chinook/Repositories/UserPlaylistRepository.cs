using Chinook.ClientModels;
using Chinook.Repositories.GenericRepository;
using Microsoft.EntityFrameworkCore;

namespace Chinook.Repositories
{
    public class UserPlaylistRepository : RepositoryBase<Models.UserPlaylist>, IUserPlaylistRepository
    {
        public UserPlaylistRepository(ChinookContext context) : base(context)
        {
        }

        public async Task<Task> EnsureUserHasfavoritePlayListAsync(string userId)
        {
            var isFavourtePresent = await _dbContext.UserPlaylists.AnyAsync(up => up.UserId == userId && up.Playlist.Name == "Favorites");
            if (!isFavourtePresent)
            {


                var pl = _dbContext.Playlists.Add(new Models.Playlist { Name = "Favorites" });
                _dbContext.UserPlaylists.Add(new Models.UserPlaylist
                {
                    Playlist = new Models.Playlist { Name = "Favorites" },
                    UserId = userId,
                });
                _dbContext.SaveChanges();
            }


            return Task.CompletedTask;

        }

        public bool RemoveTrackFromFavouriteList(long trackId, long playListId)
        {
            string sql = $"DELETE FROM PlaylistTrack  WHERE PlaylistId = {playListId} AND TrackId = {trackId} ";
          
            try
            {
                _dbContext.Database.ExecuteSqlRaw(sql);
                return true;
            }
            catch (Exception)
            {
                return false;
              
            }

        }

        public bool AddTrackToFavouriteList(long trackId, long playListId)
        {
            string sql = $"INSERT INTO PlaylistTrack (PlaylistId, TrackId)  VALUES ({playListId}, {trackId});";

            try
            {
                _dbContext.Database.ExecuteSqlRaw(sql);
                return true;
            }
            catch (Exception)
            {
                return false;

            }

        }
    }
}

