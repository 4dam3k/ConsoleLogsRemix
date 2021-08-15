
namespace ConsoleLogsRemix.EventHandlers
{
    using Exiled.API.Features;
    using Exiled.Events.EventArgs;
    using Respawning;

    /// <summary>
    /// Handles all events subscribed from <see cref="Exiled.Events.Handlers.Server"/>.
    /// </summary>
    public class ServerEvents
    {
        /// <inheritdoc cref="Exiled.Events.Handlers.Server.OnRoundStarted"/>
        public void OnRoundStarted()
        {
            Log.Info("Round Started");
        }

        /// <inheritdoc cref="Exiled.Events.Handlers.Server.OnRespawningTeam(RespawningTeamEventArgs)"/>
        public void OnRespawningTeam(RespawningTeamEventArgs ev)
        {
            if (ev.NextKnownTeam == SpawnableTeamType.NineTailedFox)
            {
                Log.Info($"Nine Tailed Fox spawned {ev.Players}");
            }

            if (ev.NextKnownTeam == SpawnableTeamType.ChaosInsurgency)
            {
                Log.Info($"Chaos Insurgency spawned {ev.Players}");
            }
        }

        /// <inheritdoc cref="Exiled.Events.Handlers.Server.OnSendingRACommand(SendingRemoteAdminCommandEventArgs)"/>
        public void OnSendingRACommand(SendingRemoteAdminCommandEventArgs ev)
        {
            if (Plugin.Instance.Config.CommandLogs)
            {
                Log.Info($"{ev.Arguments} was typed in the console by {ev.Name}");
            }
        }

        /// <inheritdoc cref="Exiled.Events.Handlers.Server.OnReportingCheater(ReportingCheaterEventArgs)"/>
        public void OnReportingCheater(ReportingCheaterEventArgs ev)
        {
            Log.Info($"{ev.Reporter.Nickname} just reported {ev.Reported.Nickname} for {ev.Reason}");
        }

        /// <inheritdoc cref="Exiled.Events.Handlers.Server.OnLocalReporting(LocalReportingEventArgs)"/>
        public void OnLocalReporting(LocalReportingEventArgs ev)
        {
            Log.Info($"{ev.Issuer.Nickname} just locally reported {ev.Target.Nickname} for {ev.Reason}");
        }
    }
}
