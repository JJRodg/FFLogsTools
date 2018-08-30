using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace FFLogsTools.FFLogsModels
{
    /* Report - documentation from https://www.fflogs.com/v1/docs/  
     * 
     *  Id (string, optional): The report code. Can be viewed on the site with the URL string of /reports/<code>.
     *  Title (string, optional): The title for the report.
     *  Owner (string, optional): The name of the user that uploaded the report.
     *  ZoneId (long, optional): The zone that the report is for. A value of -1 indicates that the zone for the report is not known.
     *  StartTime (double, optional): A UNIX timestamp with millisecond precision, indicating the start time of the report as far as logged events.
     *  EndTime (double, optional): A UNIX timestamp with millisecond precision, indicating the end time of the report as far as logged events.
     *  
     */

    public partial class Report
    {
        [JsonProperty("id", NullValueHandling = NullValueHandling.Ignore)]
        public string Id { get; set; }

        [JsonProperty("title", NullValueHandling = NullValueHandling.Ignore)]
        public string TitleName { get; set; }

        [JsonProperty("owner", NullValueHandling = NullValueHandling.Ignore)]
        public string OwnerName { get; set; }

        [JsonProperty("start", NullValueHandling = NullValueHandling.Ignore)]
        public long? StartTime { get; set; }

        [JsonProperty("end", NullValueHandling = NullValueHandling.Ignore)]
        public long? EndTime { get; set; }

        [JsonProperty("zone", NullValueHandling = NullValueHandling.Ignore)]
        public long? ZoneId { get; set; }
    }
}
