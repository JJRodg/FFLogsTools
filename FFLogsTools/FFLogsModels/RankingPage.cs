using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace FFLogsTools.FFLogsModels
{
    /* RankingPage - partial documentation from https://www.fflogs.com/v1/docs/
     * 
     *  Gets an object that contains a total count and an array of EncounterRanking objects and a total number of rankings for 
     *  that encounter. Each EncounterRanking corresponds to a single character or guild/team. 
     * 
     *  Page (integer): page number for the current set
     *  HasMorePages (boolean): if there are more results in the current set, increment page to access next page in next query
     *  Count (integer): The total number of rankings given the specified filters and current page
     *  Rankings (Array[EncounterRanking): An array of EncounterRanking objects.
     * 
     */
    public class RankingPage
    {
        [JsonProperty("page", NullValueHandling = NullValueHandling.Ignore)]
        public long? Page { get; set; }

        [JsonProperty("hasMorePages", NullValueHandling = NullValueHandling.Ignore)]
        public bool? HasMorePages { get; set; }

        [JsonProperty("count", NullValueHandling = NullValueHandling.Ignore)]
        public long? Count { get; set; }

        [JsonProperty("rankings", NullValueHandling = NullValueHandling.Ignore)]
        public List<EncounterRanking> Rankings { get; set; }
    }
}
