using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace FFLogsTools.FFLogsModels
{
    /* Bracket - partial documentation from https://www.fflogs.com/v1/docs/  
     * 
     *  Brackets are a grouping for ranking/statistics, on the FFLogs side this is represented by the Min and Max patch number
     *
     *  Min - the minimum patch number where the owner of this bracket existed
     *  Max - the maximum patch number where the owner of this bracket existed
     *  Bucket - step function of the patch nomenclature, e.g., a min of 4 and max of 4.3, with a bucket of .1 is interpretted as 4 patches: 4.0, 4.1, 4.2, 4.3
     *  Type - an identifier of this bracket type, on the FFLogs side this should be Patch
     *  
     */

    public partial class Bracket
    {
        [JsonProperty("min", NullValueHandling = NullValueHandling.Ignore)]
        public long? Min { get; set; }

        [JsonProperty("max", NullValueHandling = NullValueHandling.Ignore)]
        public double? Max { get; set; }

        [JsonProperty("bucket", NullValueHandling = NullValueHandling.Ignore)]
        public double? Bucket { get; set; }

        [JsonProperty("type", NullValueHandling = NullValueHandling.Ignore)]
        public TypeEnum? Type { get; set; }
    }

    public enum TypeEnum { Patch };
}
