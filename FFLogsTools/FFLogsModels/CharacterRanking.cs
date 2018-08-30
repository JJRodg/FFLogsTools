using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace FFLogsTools.FFLogsModels
{
    /* CharacterRanking - documentation from https://www.fflogs.com/v1/docs/  
     *   
     *  EncounterId (long, optional): A unique identifier representing this specific encounter.
     *  EncounterName (string, optional): The English name of the encounter.
     *  ClassName (string, optional): For individual rankings, the class name of the character.
     *  JobName (string, optional): For individual rankings, the job name of the character.
     *  Rank (long, optional): The rank achieved by the character.
     *  OutOf (long, optional): The total number of parses. You can use the 'rank' and 'outOf' fields to determine a percentage.
     *  DurationMs (double, optional): The length of the fight/run in milliseconds.
     *  StartUnixTime (double, optional): A timestamp with millisecond precision that indicates when the fight/run happened.
     *  ReportId (string, optional): The report ID that contains this ranking.
     *  FightId (double, optional): The fight ID within the report for the fight that contains this ranking.
     *  Difficulty (long, optional): The difficulty setting that this rank was for.
     *  CharacterId (long, optional): The character ID within the report for the character parsed for this ranking
     *  CharacterName (string, optional): The character name within the report for the character parsed for this ranking
     *  ServerName (string, optional): Server name of the character parsed with this ranking
     *  Percentile (long, optional): Percentage representing rank out of total
     *  Patch (long, optional): Patch number for the parsed ranking
     *  Total (double, optional): For individual rankings, the DPS/HPS value.
     *  IsEstimated (boolean, optional): Whether or not this ranking was estimated (if it was outside the cutoff limit of 500).
     * 
     */

    public class CharacterRanking
    {
        [JsonProperty("encounterID", NullValueHandling = NullValueHandling.Ignore)]
        public long? EncounterId { get; set; }

        [JsonProperty("encounterName", NullValueHandling = NullValueHandling.Ignore)]
        public string EncounterName { get; set; }

        [JsonProperty("class", NullValueHandling = NullValueHandling.Ignore)]
        public string ClassName { get; set; }

        [JsonProperty("spec", NullValueHandling = NullValueHandling.Ignore)]
        public string JobName { get; set; }

        [JsonProperty("rank", NullValueHandling = NullValueHandling.Ignore)]
        public long? Rank { get; set; }

        [JsonProperty("outOf", NullValueHandling = NullValueHandling.Ignore)]
        public long? OutOf { get; set; }

        [JsonProperty("duration", NullValueHandling = NullValueHandling.Ignore)]
        public long? DurationMs { get; set; }

        [JsonProperty("startTime", NullValueHandling = NullValueHandling.Ignore)]
        public long? StartUnixTime { get; set; }

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
        public string ServerName { get; set; }

        [JsonProperty("percentile", NullValueHandling = NullValueHandling.Ignore)]
        public long? Percentile { get; set; }

        [JsonProperty("ilvlKeyOrPatch", NullValueHandling = NullValueHandling.Ignore)]
        public double? Patch { get; set; }

        [JsonProperty("total", NullValueHandling = NullValueHandling.Ignore)]
        public double? Total { get; set; }

        [JsonProperty("estimated", NullValueHandling = NullValueHandling.Ignore)]
        public bool? IsEstimated { get; set; }
    }
}
