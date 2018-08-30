using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace FFLogsTools.FFLogsModels
{
    /* Encounter - documentation from https://www.fflogs.com/v1/docs/ 
     * 
     *  Id (integer): A unique identifier representing this specific encounter.
     *  Name (string): The English name of the encounter.
     *   
     */

    public class Encounter
    {
        [JsonProperty("id", NullValueHandling = NullValueHandling.Ignore)]
        public long? Id { get; set; }

        [JsonProperty("name", NullValueHandling = NullValueHandling.Ignore)]
        public string Name { get; set; }
    }
}
