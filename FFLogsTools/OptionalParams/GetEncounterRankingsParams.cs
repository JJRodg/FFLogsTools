using Refit;
using System;
using System.Collections.Generic;
using System.Text;

namespace FFLogsTools.OptionalParams
{
    /* GetEncounterRankingsParams
     * 
     *  Metric - The metric to query for. Valid fight metrics are 'speed', 'execution' and 'feats'. Valid character metrics are 'dps', 
     *          'hps', 'bossdps, 'tankhps', or 'playerspeed'. For WoW only, 'krsi' can be used for tank survivability ranks and 'progress' 
     *          can be used for guild progress info.
     *          
     *  Size - The raid size to query for. This is only valid for fixed size raids. Raids with flexible sizing must omit this parameter.
     *  
     *  JobId - The job to query for if a character metric is specified. Valid job IDs can be obtained from a /classes API request. Optional.
     *  
     *  Bracket - The bracket to query for. If omitted or if a value of 0 is specified, then all brackets are examined. Brackets can be obtained 
     *          from a /zones API request.
     *          
     *  ServerName - A server to filter on. If set, the region must also be specified. This is the slug field in Blizzard terminology.
     *  
     *  Region - The short name of a region to filter on (NA, EU, JP)
     *  
     *  Page - 	The page to examine, starting from 1. If the value is omitted, then 1 is assumed. For example, with a page of 2 and a limit of 300, you 
     *          will be fetching rankings 301-600.
     *          
     *  Filter - 	A search filter string, limiting the search to specific classes, specs, fight durations, raid sizes, etc. The format should match the string 
     *          used on the public rankings pages.         
     */

    public class GetEncounterRankingsParams
    {
        [AliasAs("metric")]
        public string Metric { get; set; }

        [AliasAs("size")]
        public string Size { get; set; }

        [AliasAs("job")]
        public string JobId { get; set; }

        [AliasAs("bracket")]
        public string Bracket { get; set; }

        [AliasAs("server")]
        public string ServerName { get; set; }

        [AliasAs("region")]
        public ServerRegionEnum Region { get; set; }

        [AliasAs("page")]
        public string Page { get; set; }

        [AliasAs("filter")]
        public string Filter { get; set; }
    }
}
