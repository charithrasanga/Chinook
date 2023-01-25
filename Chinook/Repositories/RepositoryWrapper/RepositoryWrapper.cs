using Chinook.Repositories;

namespace Chinook.Repositories.RepositoryWrapper
{

    public class RepositoryWrapper : IRepositoryWrapper
    {
        private ChinookContext _context;

        private IPlaylistRepository playlists;
        public IPlaylistRepository Playlists
        {
            get
            {
                if (playlists == null)
                {
                    playlists = new PlaylistRepository(_context);
                }
                return playlists;
            }
        }


        private IArtistRepository artists;
        public IArtistRepository Artists
        {
            get
            {
                if (artists == null)
                {
                    artists = new ArtistRepository(_context);
                }
                return artists;
            }
        }

        private IAlbumRepository albums;
        public IAlbumRepository Albums
        {
            get
            {
                if (albums == null)
                {
                    albums = new AlbumRepository(_context);
                }
                return albums;
            }
        }

        private ITrackRepository tracks;
        public ITrackRepository Tracks
        {
            get
            {
                if (tracks == null)
                {
                    tracks = new TrackRepository(_context);
                }
                return tracks;
            }
        }
        public RepositoryWrapper(ChinookContext Context)
        {
            _context = Context;
        }

        public void Save()
        {
            _context.SaveChanges();
        }
    }
}
