using Newtonsoft.Json;

namespace SmashggNet.Models
{
    public class Set
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("entrant1Id")]
        public int Entrant1Id { get; set; }

        [JsonProperty("entraint2Id")]
        public int Entrant2Id { get; set; }

        [JsonProperty("winnerId")]
        public int WinnerId { get; set; }

        [JsonProperty("loserId")]
        public int LoserId { get; set; }

        [JsonProperty("eventId")]
        public int EventId { get; set; }

        [JsonProperty("streamId")]
        public int? StreamId { get; set; }

        [JsonProperty("bracketId")]
        public string BracketId { get; set; }

        [JsonProperty("round")]
        public int? Round { get; set; }

        [JsonProperty("originalName")]
        public string OriginalName { get; set; }

        [JsonProperty("fullRoundText")]
        public string FullSizedRoundText { get; set; }

        [JsonProperty("midRoundText")]
        public string MidSizedRoundText { get; set; }

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

        [JsonProperty("bestOf")]
        public int? BestOfAmount { get; set; }

        [JsonProperty("totalGames")]
        public int? TotalGames { get; set; }

        [JsonProperty("entrant1Score")]
        public int? Entrant1Score { get; set; }

        [JsonProperty("entrant2Score")]
        public int? Entrant2Score { get; set; }
    }
}