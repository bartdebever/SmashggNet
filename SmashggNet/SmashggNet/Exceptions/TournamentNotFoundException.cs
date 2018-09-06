using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace SmashggHandler.Exceptions
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
