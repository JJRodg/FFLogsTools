using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace FFLogsTools.FFLogsModels
{
    public class Parse
    {
        /* Parse - documentation missing from https://www.fflogs.com/v1/docs/ - below is developer documentation
         * 
         *       // TODO: document this model schema
         * 
         */

        [JsonProperty("encounterID", NullValueHandling = NullValueHandling.Ignore)]
        public long? EncounterId { get; set; }

        [JsonProperty("encounterName", NullValueHandling = NullValueHandling.Ignore)]
        public string EncounterName { get; set; }

        [JsonProperty("class", NullValueHandling = NullValueHandling.Ignore)]
        public string Class { get; set; }

        [JsonProperty("spec", NullValueHandling = NullValueHandling.Ignore)]
        public string Job { get; set; }

        [JsonProperty("rank", NullValueHandling = NullValueHandling.Ignore)]
        public long? Rank { get; set; }

        [JsonProperty("outOf", NullValueHandling = NullValueHandling.Ignore)]
        public long? OutOf { get; set; }

        [JsonProperty("duration", NullValueHandling = NullValueHandling.Ignore)]
        public long? Duration { get; set; }

        [JsonProperty("startTime", NullValueHandling = NullValueHandling.Ignore)]
        public long? StartTime { get; set; }

        [JsonProperty("reportID", NullValueHandling = NullValueHandling.Ignore)]
        public string ReportId { get; set; }

        [JsonProperty("fightID", NullValueHandling = NullValueHandling.Ignore)]
        public long? FightId { get; set; }

        [JsonProperty("difficulty", NullValueHandling = NullValueHandling.Ignore)]
        public long? Difficulty { get; set; }

        [JsonProperty("characterID", NullValueHandling = NullValueHandling.Ignore)]
        public long? CharacterId { get; set; }

        [JsonProperty("characterName", NullValueHandling = NullValueHandling.Ignore)]
        public string CharacterName { get; set; }

        [JsonProperty("server", NullValueHandling = NullValueHandling.Ignore)]
        public string Server { get; set; }

        [JsonProperty("percentile", NullValueHandling = NullValueHandling.Ignore)]
        public long? Percentile { get; set; }

        [JsonProperty("ilvlKeyOrPatch", NullValueHandling = NullValueHandling.Ignore)]
        public double? IlvlKeyOrPatch { get; set; }

        [JsonProperty("total", NullValueHandling = NullValueHandling.Ignore)]
        public double? Total { get; set; }

        [JsonProperty("estimated", NullValueHandling = NullValueHandling.Ignore)]
        public bool? Estimated { get; set; }
    }
}
