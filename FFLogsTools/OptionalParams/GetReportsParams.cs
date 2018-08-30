using Refit;
using System;
using System.Collections.Generic;
using System.Text;

namespace FFLogsTools.OptionalParams
{
    public class GetReportsParams
    {
        /* GetReportsParams - optional parameters for GetReports.  Optional params should always be strings for purposes of Refit
         * 
         *  StartUnixTime - An optional start time. This is a UNIX timestamp but with millisecond precision. If omitted, 0 is assumed.
         *  EndUnixTime - An optional end time. This is a UNIX timestamp but with millisecond precision. If omitted, 0 is assumed.
         * 
         */

        [AliasAs("start")]
        public string StartUnixTime { get; set; }

        [AliasAs("end")]
        public string EndUnixTime { get; set; }
    }
}
