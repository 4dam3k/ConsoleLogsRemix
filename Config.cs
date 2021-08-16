
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

        public Dictionary<string, string> Roletypes { get; set; } = new Dictionary<string, string>
        {
            {
                 "ClassD", "Class D"
            },
            {
                 "Scientist", "Scientist "
            },
            {
                 "FacilityGuard", "Guard"
            },
            {
                 "NtfCommander", "Commander"
            },
            {
                 "NtfCadet", "Cadet"
            },
            {
                 "NtfLieutenant", "Lieutenant"
            },
            {
                 "NtfScientist", "Scientist NTF"
            },
            {
                 "ChaosInsurgency", "Chaos Agent"
            },
            {
                 "Scp049", "SCP-049"
            },
            {
                 "Scp0492", "SCP-049-2"
            },
            {
                 "Scp079", "SCP-079"
            },
            {
                 "Scp096", "SCP-096"
            },
            {
                 "Scp106", "SCP-106"
            },
            {
                 "Scp173", "SCP-173"
            },
            {
                 "Scp93953", "SCP-939-53"
            },
            {
                 "Scp93989", "SCP-939-89"
            },
        };
        public Dictionary<ItemType, string> Itemtypes { get; set; } = new Dictionary<ItemType, string>
        {
            {
                ItemType.GunCOM15, "Pistol"
            },
            {
                ItemType.MicroHID, "MicroHID"
            },
            {
                ItemType.GunE11SR, "Rifle"
            },
            {
                ItemType.GunProject90, "P90"
            },
            {
                ItemType.GunMP7, "SMG"
            },
            {
                ItemType.GunLogicer, "Negev"
            },
            {
                ItemType.GrenadeFrag, "Frag grenade"
            },
            {
                ItemType.GunUSP, "Pistol"
            },

        };
    }
}