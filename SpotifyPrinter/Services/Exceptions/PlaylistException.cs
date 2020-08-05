using System;

namespace SpotifyPrinter.Services.Exceptions
{
    public class PlaylistException : ApplicationException
    {
        public PlaylistException(string message) : base(message) { }
    }
}
