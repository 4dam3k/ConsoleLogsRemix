
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
        /// Gets or sets a value indicating whether remote admin commands should be logged.
        /// </summary>
        [Description("Czy komendy RemoteAdmin powinny byæ pokazywane?")]
        public bool CommandLogs { get; set; } = false;

        /// <summary>
        /// Show list of allowed steamID64
        /// </summary>
        [Description("Lista steamID64 którym maj¹ siê wyœwietlaæ logi")]
        public List<string> steamids { get; set; } = new List<string>
        {
            
            "76561198194587707@steam",
        };
    }
}