using System;

namespace SpotifyPrinter.Services.Exceptions
{
    public class ClientNotAuthenticatedException : ApplicationException
    {
        public ClientNotAuthenticatedException(string message) : base(message) { }
    }
}
