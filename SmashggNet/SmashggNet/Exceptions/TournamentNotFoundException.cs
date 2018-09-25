using System;

namespace SmashggNet.Exceptions
{
    [Serializable]
    public class TournamentNotFoundException : Exception
    {
        public TournamentNotFoundException()
        {
        }

        public TournamentNotFoundException(string message) : base(message)
        {
        }
    }
}