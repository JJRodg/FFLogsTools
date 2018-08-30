using Refit;
using System;
using System.Collections.Generic;
using System.Text;

namespace FFLogsTools.OptionalParams
{
    /* GetParsesParams - optional paramaters for GetParses.  Optional params should always be strings for purposes of Refit
     * 
     *  ZoneId - The zone id to fetch rankings for. If omitted, the latest open raid zone is used.  Zone Id can be found in GetZones
     *      
     *  EncounterId - An encounter within the zone to fetch parses for. If omitted, all encounters in the zone will be checked. If a 
     *              valid encounter is specified, then historical graph data for the encounter will also be included in the results.  Use encounter 
     *              identifier (e.g., 51) , not encounter name.
     *       
     *  // TODO: Find out what these metrics actually mean and enumerate/document them
     *  Metric - The metric to query for. Valid character metrics are 'dps', 'hps', 'bossdps, 'tankhps', or 'playerspeed'. For 
     *              WoW only, 'krsi' can be used for tank survivability ranks.
     *          
     *  Bracket - The bracket to query for. If omitted or if a value of 0 is specified, then all brackets are examined. Brackets can 
     *              be obtained from a /zones API request. The special value -1 can be used to obtain scores by bracket %, i.e., to automatically 
     *              look only at the bracket each parse falls in.  // TODO: Verify - Not sure this actually does anything in practice on FFLogs
     *          
     *  Compare - Optional. Whether or not to compare against rankings (0) when computing performance percentiles or to compare against statistics (1). 
     *              A value of 0 is assumed if omitted.
     *          
     *  // TODO: Enumerate Timeframe, document this
     *  Timeframe - Whether to compare against today's rankings or to return historical information (where the rank was back when it was earned. 
     *              The accepted values are 'today' and 'historical', with the default being 'today'.          
     */

    public class GetParsesParams
    {
        [AliasAs("zone")]
        public string ZoneId{ get; set; }

        [AliasAs("encounter")]
        public string EncounterId { get; set; }

        [AliasAs("metric")]
        public string Metric { get; set; }

        [AliasAs("bracket")]
        public string Bracket { get; set; }

        [AliasAs("compare")]
        public string Compare { get; set; }

        [AliasAs("timeframe")]
        public string TimeFrame { get; set; }
    }
}
