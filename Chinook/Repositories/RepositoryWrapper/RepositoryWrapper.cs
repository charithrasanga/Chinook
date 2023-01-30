using Chinook.Repositories;

namespace Chinook.Repositories.RepositoryWrapper
{

    public class RepositoryWrapper : IRepositoryWrapper
    {
        private ChinookContext _context;

        private IPlaylistRepository _playlists;
        public IPlaylistRepository Playlists
        {
            get
            {
                if (_playlists == null)
                {
                    _playlists = new PlaylistRepository(_context);
                }
                return _playlists;
            }
        }


        private IArtistRepository _artists;
        public IArtistRepository Artists
        {
            get
            {
                if (_artists == null)
                {
                    _artists = new ArtistRepository(_context);
                }
                return _artists;
            }
        }

        private IAlbumRepository _albums;
        public IAlbumRepository Albums
        {
            get
            {
                if (_albums == null)
                {
                    _albums = new AlbumRepository(_context);
                }
                return _albums;
            }
        }

        private ITrackRepository _tracks;
        public ITrackRepository Tracks
        {
            get
            {
                if (_tracks == null)
                {
                    _tracks = new TrackRepository(_context);
                }
                return _tracks;
            }
        }

      
        private IUserPlaylistRepository _userPlaylists;
        public IUserPlaylistRepository UserPlaylists
        {
            get
            {
                if (_userPlaylists == null)
                {
                    _userPlaylists = new UserPlaylistRepository(_context);
                }
                return _userPlaylists;
            }
        }

        public RepositoryWrapper(ChinookContext Context)
        {
            _context = Context;
        }

        public void Save()
        {
            _context.SaveChanges();
            _context.ChangeTracker.Clear();

        }
    }
}
