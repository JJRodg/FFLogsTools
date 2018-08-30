using System;
using System.Collections.Generic;
using System.Text;
using System.Globalization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace FFLogsTools.FFLogsModels
{
    /* Zone - documentation from https://www.fflogs.com/v1/docs/  
     *  
     *  id (integer): A unique identifier representing this specific zone.
     *  name (string): The English name of the raid zone.
     *  frozen (boolean): Whether or not the rankings and statistics for the zone are frozen. 
     *                  If set, then the results for this zone are never going to change, and you don't have to fetch them again.
     *  encounters (Array[Encounter): The encounters for this zone.
     *  brackets (Array[Bracket, optional): The brackets for this zone. Rankings and statistics are collected for each bracket.
     *  
     */

    public class Zone
    {
        [JsonProperty("id", NullValueHandling = NullValueHandling.Ignore)]
        public long? Id { get; set; }
        
        [JsonProperty("name", NullValueHandling = NullValueHandling.Ignore)]
        public string Name { get; set; }

        [JsonProperty("frozen", NullValueHandling = NullValueHandling.Ignore)]
        public bool? Frozen { get; set; }

        [JsonProperty("encounters", NullValueHandling = NullValueHandling.Ignore)]
        public List<Encounter> Encounters { get; set; }

        [JsonProperty("brackets", NullValueHandling = NullValueHandling.Ignore)]
        public Bracket Brackets { get; set; }
        
        [JsonProperty("partitions", NullValueHandling = NullValueHandling.Ignore)]
        public List<Partition> Partitions { get; set; }
    }
}
 