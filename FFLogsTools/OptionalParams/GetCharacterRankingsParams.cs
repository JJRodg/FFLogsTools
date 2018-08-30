using Refit;
using System;
using System.Collections.Generic;
using System.Text;

namespace FFLogsTools.OptionalParams
{
    /* GetCharacterRankingsParams
     *  
     *  ZoneId - The zone to fetch rankings for. If omitted, the latest open raid zone is used.
     * 
     *  EncounterId - An encounter within the zone to fetch rankings for. If omitted, all encounters in the zone will be checked.
     *  
     *  Metric - The metric to query for. Valid character metrics are 'dps', 'hps', 'bossdps, 'tankhps', or 'playerspeed'. For WoW only, 
     *          'krsi' can be used for tank survivability ranks.
     *          
     *  Bracket - The bracket to query for. If omitted or if a value of 0 is specified, then all brackets are examined. Brackets can 
     *          be obtained from a /zones API request.
     *       
     *  // TODO: Enumerate Timeframe, document this
     *  TimeFrame - Whether to compare against today's rankings or to return historical information (where the rank was back when it was earned. 
     *          The accepted values are 'today' and 'historical', with the default being 'today'.
     */

    public class GetCharacterRankingsParams
    {
        [AliasAs("zone")]
        public String ZoneId { get; set; }

        [AliasAs("encounter")]
        public String EncounterId { get; set; }

        [AliasAs("metric")]
        public String Metric { get; set; }

        [AliasAs("bracket")]
        public String Bracket { get; set; }

        [AliasAs("timeframe")]
        public String TimeFrame { get; set; }
    }
}
