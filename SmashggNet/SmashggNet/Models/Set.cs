using Newtonsoft.Json;

namespace SmashggNet.Models
{
    public class Set
    {
        [JsonProperty("id")]
        public int Id { get; set; }
        /// <summary>
        /// The Id of the first entrant
        /// NOTE THAT THIS IS NOT THE USER ID
        /// </summary>
        [JsonProperty("entrant1Id")]
        public int Entrant1Id { get; set; }
        /// <summary>
        /// The Id of the second entrant
        /// NOTE THAT THIS IS NOT THE USER ID
        /// </summary>
        [JsonProperty("entraint2Id")]
        public int Entrant2Id { get; set; }
        /// <summary>
        /// The EntrantId of the winner
        /// </summary>
        [JsonProperty("winnerId")]
        public int WinnerId { get; set; }
        /// <summary>
        /// The EntrantId of the loser
        /// </summary>
        [JsonProperty("loserId")]
        public int LoserId { get; set; }
        /// <summary>
        /// The Id of the event that this set was played in
        /// </summary>
        [JsonProperty("eventId")]
        public int EventId { get; set; }
        /// <summary>
        /// The Id of the stream this set was played on.
        /// If this wasn't played on stream it will be NULL
        /// </summary>
        [JsonProperty("streamId")]
        public int? StreamId { get; set; }
        /// <summary>
        /// The Id of the bracket that this set is in
        /// </summary>
        [JsonProperty("bracketId")]
        public string BracketId { get; set; }
        /// <summary>
        /// The round that this set is in.
        /// Will return null when the set isn't in a round
        /// </summary>
        [JsonProperty("round")]
        public int? Round { get; set; }
        /// <summary>
        /// The name of the set being played
        /// </summary>
        [JsonProperty("originalName")]
        public string OriginalName { get; set; }
        /// <summary>
        /// Full-Sized version of <see cref="OriginalName"/>
        /// </summary>
        [JsonProperty("fullRoundText")]
        public string FullSizedRoundText { get; set; }
        /// <summary>
        /// Medium-Sized version of <see cref="OriginalName"/>
        /// </summary>
        [JsonProperty("midRoundText")]
        public string MidSizedRoundText { get; set; }
        /// <summary>
        /// Short-Sized version of <see cref="OriginalName"/>
        /// </summary>
        [JsonProperty("shortRoundText")]
        public string ShortSizedRoundText { get; set; }

        /// <summary>
        /// Represents the placement that the winner gets
        /// </summary>
        /// <value></value>
        [JsonProperty("wPlacement")]
        public int? WinnerPlacement { get; set; }

        /// <summary>
        /// Represents the placement that the loser gets
        /// </summary>
        /// <value></value>
        [JsonProperty("lPlacement")]
        public int? LoserPlacement { get; set; }

        /// <summary>
        /// The best of amount of the set
        /// </summary>
        [JsonProperty("bestOf")]
        public int? BestOfAmount { get; set; }
        /// <summary>
        /// The total games that could be played TODO unsure if this is true
        /// </summary>
        [JsonProperty("totalGames")]
        public int? TotalGames { get; set; }
        /// <summary>
        /// The amount of games <see cref="Entrant1Id"/> won
        /// </summary>
        [JsonProperty("entrant1Score")]
        public int? Entrant1Score { get; set; }
        /// <summary>
        /// The amount of games <see cref="Entrant2Id"/> won
        /// </summary>
        [JsonProperty("entrant2Score")]
        public int? Entrant2Score { get; set; }
    }
}