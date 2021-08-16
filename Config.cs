
namespace ConsoleLogsRemix
{
    using System.Collections.Generic;
    using System.ComponentModel;
    using Exiled.API.Interfaces;

    /// <inheritdoc cref="IConfig"/>
    public sealed class Config : IConfig
    {
        /// <inheritdoc />
        public bool IsEnabled { get; set; } = true;

        /// <summary>
        /// Show list of allowed steamID64
        /// </summary>
        [Description("SteamIDs of players to show logs")]
        public List<string> steamids { get; set; } = new List<string>
        {
            
            "76561198194587707@steam",
        };

        /// <summary>
        /// Translations
        /// </summary>
        [Description("Translations of logs in console")]
        public string Killlogs { set; get; } = @"$knick ($krole) killed $tnick ($trole) dealing $damage using $weapon";
        public string Teamkilllogs { set; get; } = @"$knick teamkilled $tnick (both $trole) dealing $damage using $weapon";
        public string Idlogs { set; get; } = @"ID of killer: $kid || ID of target: $tid";

    }
}