using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace FFLogsTools.FFLogsModels
{
    /* Class - documentation from https://www.fflogs.com/v1/docs/ 
     * {
        id (integer): A unique identifier representing this specific class.
        name (string): The English name of the class.
        specs (Array[Spec): The possible specs for this class.          
       }
    */
    public class Class
    {
        [JsonProperty("id", NullValueHandling = NullValueHandling.Ignore)]
        public long? Id { get; set; }

        [JsonProperty("name", NullValueHandling = NullValueHandling.Ignore)]
        public string Name { get; set; }

        // Note: For the purposes of FFLogsTools, a spec is aliased to Job(and can be found in the Job model).  This is done to match FF nomenclature
        [JsonProperty("specs", NullValueHandling = NullValueHandling.Ignore)]
        public List<Job> Jobs { get; set; }
    }
}
