using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace FFLogsTools.FFLogsModels
{
    /* Job (Spec) - documentation from https://www.fflogs.com/v1/docs/ 
     * {
        id (integer): A unique identifier representing this specific spec.
        name (string): The English name of the spec.
       }
     */

    public class Job
    {
        [JsonProperty("id", NullValueHandling = NullValueHandling.Ignore)]
        public long? Id { get; set; }

        [JsonProperty("name", NullValueHandling = NullValueHandling.Ignore)]
        public string Name { get; set; }
    }
}
