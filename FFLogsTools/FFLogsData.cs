using FFLogsTools;
using FFLogsTools.FFLogsModels;
using FFLogsTools.OptionalParams;
using Newtonsoft.Json.Linq;
using Refit;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;

namespace FFLogsTools
{
    public class FFLogsData
    {
        private IFFLogsApi FFLogsClient;

        private static Uri FFLogsEndpoint = new Uri("https://www.fflogs.com:443/v1");
        private String FFLogsKey;

        public FFLogsData(String fflogsKey)
        {
            FFLogsClient = RestService.For<IFFLogsApi>("https://www.fflogs.com:443");
            FFLogsKey = fflogsKey;
        }

        public async Task<List<Zone>> GetZones()
        {
            var zones = await FFLogsClient.GetZones(FFLogsKey);
            return zones;
        }

        public async Task<List<Class>> GetClasses()
        {
            var classes = await FFLogsClient.GetClasses(FFLogsKey);
            return classes;
        }

        public async Task<RankingPage> GetEncounterRankings(long encounterId, GetEncounterRankingsParams optionalParameters)
        {
            var rankings = await FFLogsClient.GetEncounterRankings(encounterId, FFLogsKey, optionalParameters);
            return rankings;
        }

        public async Task<List<Parse>> GetParses(String characterName, String serverName, Enum serverRegion, GetParsesParams optionalParameters)
        {
            var parses = await FFLogsClient.GetParses(characterName, serverName, serverRegion, FFLogsKey, optionalParameters);
            return parses;
        }

        public async Task<List<Report>> GetReports(String userName)
        {
            var reports = await FFLogsClient.GetReports(userName, FFLogsKey);          
            return reports;
        }
    }

    public enum ServerRegionEnum
    {
        NA,
        EU,
        JP
    }
}
