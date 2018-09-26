namespace SmashggNet.Models
{
    /// <summary>
    /// An enum used to expand request send.
    /// Expanding gets more objects that are related to your request.
    /// For example getting all events for the tournament you are gathering.
    /// </summary>
    public enum Expand
    {
        Event = 0,
        Phase = 1,
        Groups = 2,
        Stations = 3,
    }
}