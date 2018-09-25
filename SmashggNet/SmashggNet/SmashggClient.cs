using SmashggNet.Modules;
using SmashggNet.Modules.Interfaces;

namespace SmashggNet
{
    public class SmashggClient
    {
        public ITournamentEndpoint TournamentEndpoint { get; }

        public SmashggClient()
        {
            TournamentEndpoint = new TournamentEndpoint();
        }
    }
}