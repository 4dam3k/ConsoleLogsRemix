using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleLogsRemix.Handlers
{
    using Exiled.API.Features;
    using Exiled.Events.EventArgs;
    using Exiled.API.Interfaces;

    /// <summary>
    /// Dictionary for Roles
    /// </summary>
    public class DictionariesUNUSED
    {
        public static Dictionary<string, string> Roletypes { get; set; } = new Dictionary<string, string>
        {
            {
                 "ClassD", "Klasa D"
            },
            {
                 "Scientist", "Naukowiec"
            },
            {
                 "FacilityGuard", "Ochroniarz"
            },
            {
                 "NtfCommander", "Dowódca"
            },
            {
                 "NtfCadet", "Kadet"
            },
            {
                 "NtfLieutenant", "Porucznik"
            },
            {
                 "NtfScientist", "Sanitariusz"
            },
            {
                 "ChaosInsurgency", "Agent Chaosu"
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
        public static Dictionary<ItemType, string> Itemtypes { get; set; } = new Dictionary<ItemType, string>
        {
            {
                ItemType.GunCOM15, "Pistoletem"
            },
            {
                ItemType.MicroHID, "MicroHIDem"
            },
            {
                ItemType.GunE11SR, "Karabinem"
            },
            {
                ItemType.GunProject90, "P90"
            },
            {
                ItemType.GunMP7, "SMGkiem"
            },
            {
                ItemType.GunLogicer, "Krową"
            },
            {
                ItemType.GrenadeFrag, "Granatem"
            },
            {
                ItemType.GunUSP, "Pistoletem"
            },

        };
    }
}
