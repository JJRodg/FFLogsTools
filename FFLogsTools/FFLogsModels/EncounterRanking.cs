using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace FFLogsTools.FFLogsModels
{
    /* EncounterRanking - documentation from https://www.fflogs.com/v1/docs/  
     * 
     *  Name (string, optional): The name of the character that obtained the ranking.
     *  ClassId (long, optional): For individual rankings, the class of the character.
     *  JobId (long, optional): For individual rankings, the job id of the character.  Get the string literal from GetClasses
     *  Total (double, optional): For individual rankings, the DPS/HPS value.
     *  Duration (double, optional): The length of the fight/run in milliseconds.
     *  StartUnixTime (double, optional): A timestamp with millisecond precision that indicates when the fight/run happened.
     *  FightId (double, optional): The fight ID within the report for the fight that contains this ranking. // TODO: Confirm this is a unix timestamp
     *  ReportId (string, optional): The report ID that contains this ranking.  
     *  GuildName (string, optional): The name of the guild that obtained the ranking.
     *  ServerName (string, optional): The server that the ranking was obtained on.
     *  RegionName (string, optional): The short name of the region that the server belongs to.
     *  IsHidden (boolean, optional): Whether the encounter ranking is hidden
     *  Patch (double, optional): For challenge mode rankings, what patch they were obtained in.
     *  Exploit (long, optional): // TODO: Reach out to FFLogs for documentation on exploit meaning (I suspect it's a state value since exploits can be classified one of three different ways.
     *  
     */
    public class EncounterRanking
    {
        [JsonProperty("name", NullValueHandling = NullValueHandling.Ignore)]
        public string Name { get; set; }

        [JsonProperty("class", NullValueHandling = NullValueHandling.Ignore)]
        public long? ClassId { get; set; }

        [JsonProperty("spec", NullValueHandling = NullValueHandling.Ignore)]
        public long? JobId { get; set; }

        [JsonProperty("total", NullValueHandling = NullValueHandling.Ignore)]
        public double? Total { get; set; }

        [JsonProperty("duration", NullValueHandling = NullValueHandling.Ignore)]
        public long? Duration { get; set; }

        [JsonProperty("startTime", NullValueHandling = NullValueHandling.Ignore)]
        public long? StartUnixTime { get; set; }

        [JsonProperty("fightID", NullValueHandling = NullValueHandling.Ignore)]
        public long? FightId { get; set; }

        [JsonProperty("reportID", NullValueHandling = NullValueHandling.Ignore)]
        public string ReportId { get; set; }

        [JsonProperty("guildName", NullValueHandling = NullValueHandling.Ignore)]
        public string GuildName { get; set; }

        [JsonProperty("serverName", NullValueHandling = NullValueHandling.Ignore)]
        public string ServerName { get; set; }

        [JsonProperty("regionName", NullValueHandling = NullValueHandling.Ignore)]
        public string RegionName { get; set; }

        [JsonProperty("hidden", NullValueHandling = NullValueHandling.Ignore)]
        public bool? IsHidden { get; set; }

        [JsonProperty("patch", NullValueHandling = NullValueHandling.Ignore)]
        public double? Patch { get; set; }

        [JsonProperty("exploit", NullValueHandling = NullValueHandling.Ignore)]
        public long? Exploit { get; set; }
    }
}
