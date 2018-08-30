using FFLogsTools.FFLogsModels;
using FFLogsTools.OptionalParams;
using Refit;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace FFLogsTools
{
    public interface IFFLogsApi
    {
        /* GetZones - Gets an array of Zone objects.Each zone corresponds to a raid/dungeon instance in the game and has its own set of encounters.
         * 
         *  key - Owner's account API Key from FFLogs
         */
        [Get("/v1/zones?api_key={key}")]
        Task<List<Zone>> GetZones(String key);

        /* GetClasses - Gets an array of Class objects. In FF, this should be one specific class that contains a list of FF's current jobs
         * 
         *  key - Owner's account API Key from FFlogs
         */
        [Get("/v1/classes?api_key={key}")]
        Task<List<Class>> GetClasses(String key);

        /* GetEncounterRankings - Gets an object that contains a total count and an array of EncounterRanking objects and a total number of 
         *  rankings for that encounter. Each EncounterRanking corresponds to a single character or guild/team.
         *  
         *  encounterId - The encounter to collect rankings for. Encounter IDs can be obtained using a /zones request.
         *  key - Owner's account API Key from FFLogs 
         */
        [Get("/v1/rankings/encounter/{encounterId}?api_key={key}")]
        Task<RankingPage> GetEncounterRankings(long encounterId, String key, GetEncounterRankingsParams optionalParameters);

        /* GetCharacterRankings -   Gets an array of CharacterRanking objects. Each CharacterRanking corresponds to a single rank on a fight for the specified character.
         *      On FFLogs, this call appears to get the highest percentile per job for the specified parameters.
         *      
         *  characterName - The name of the character to collect rankings for.
         *  serverName - The server that the character is found on.  For World of Warcraft this is the 'slug' field returned from their realm status API.
         *  serverRegion - serverRegion - The short region name for the server on which the character is located: NA, EU, JP
         *  key - Owner's account API Key from FFLogs 
         */
        [Get("/v1/rankings/character/{characterName}/{serverName}/{serverRegion}?api_key={key}")]
        Task<List<CharacterRanking>> GetCharacterRankings(String characterName, String serverName, String serverRegion, String key, GetCharacterRankingsParams optionalParameters);
        
        /* GetParses - Obtains all parses for a character in the zone across all specs. Every parse is included and not just rankings.
         * 
         *  characterName - The name of the character to collect rankings for.
         *  serverName - The server that the character is found on. For World of Warcraft this is the 'slug' field returned from their realm status API.
         *  serverRegion - The short region name for the server on which the character is located: NA, EU, JP
         *  key - Owner's account API Key from FFLogs 
         *  parsesParams - See class GetParsesParams for optional param descriptions
         */
        [Get("/v1/parses/character/{characterName}/{serverName}/{serverRegion}?api_key={key}")]
        Task<List<Parse>> GetParses(String characterName, String serverName, Enum serverRegion, String key, GetParsesParams optionalParameters);

        /* GetReports - Gets an array of Report objects. Each Report corresponds to a single calendar report for the specified user's personal logs.  
         * 
         *  userName - The name of the FFLogs.com user to collect reports for.
         *  key - Owner's account API Key from FFLogs 
         */
        [Get("/v1/reports/user/{userName}?api_key={key}")]
        Task<List<Report>> GetReports(String userName, String key);

        /* GetReports - Gets an array of Report objects. Each Report corresponds to a single calendar report for the specified guild.
         * 
         *  guildName - The name of the guild to collect reports for.
         *  serverName - The server that the guild is found on.
         *  serverRegion - The short region name for the server on which the guild is located: NA, EU, JP.
         *  key - Owner's account API Key from FFLogs 
         */
        [Get("/v1/reports/guild/{guildName}/{serverName}/{serverRegion}?api_key={key}")]
        Task<List<Report>> GetReports(String guildName, String serverName, Enum serverRegion, String key);

        /* GetReport - Gets arrays of fights and the participants in those fights. Each Fight corresponds to a single pull of a boss.
         * 
         *  reportId - The specific report to collect fights and participants for.
         *  key - Owner's account API Key from FFLogs 
         */
         [Get("/v1/report/fights/{reportId}?api_key{key}")]
        Task<Report> GetReport(String reportId, string key);
    }
}
