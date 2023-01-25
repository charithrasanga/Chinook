namespace Chinook.Repositories.RepositoryWrapper
{
    public interface IRepositoryWrapper
    {
        IPlaylistRepository Playlists { get; }
        IArtistRepository Artists { get; }
        IAlbumRepository Albums { get; }
        ITrackRepository Tracks { get; }

        void Save();
    }
}
