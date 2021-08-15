
namespace ConsoleLogsRemix.EventHandlers
{
    using Exiled.API.Features;
    using Exiled.Events.EventArgs;

    /// <summary>
    /// Handles all events subscribed from <see cref="Exiled.Events.Handlers.Player"/>.
    /// </summary>
    public class PlayerEvents
    {
        /// <inheritdoc cref="Exiled.Events.Handlers.Player.OnDied(DiedEventArgs)"/>
        public void OnDestroying(DestroyingEventArgs ev)
        {
            Log.Info($"{ev.Player.Nickname} wyszed³ z serwera");
        }

        /// <inheritdoc cref="Exiled.Events.Handlers.Player.OnDying(DyingEventArgs)"/>
        public void OnDying(DyingEventArgs ev)
        {
            float damageNotRounded = ev.HitInformation.Amount;
            int damageRound = (int)damageNotRounded;
            Log.Info($"{ev.Killer.Nickname} ({ev.Killer.Role}) zabi³ {ev.Target.Nickname} ({ev.Target.Role}) zadaj¹c {damageRound} obra¿eñ.");

            string message = $"{ev.Killer.Nickname} ({ev.Killer.Role}) zabi³ {ev.Target.Nickname} ({ev.Target.Role}) zadaj¹c {damageRound} obra¿eñ.";
            foreach (string steamID in Plugin.Instance.Config.steamids)
            {
                Player.Get(steamID)?.RemoteAdminMessage(message, true);
            }


        }
        /// <inheritdoc cref="Exiled.Events.Handlers.Player.OnDied(DiedEventArgs)"/>
        public void OnDied(DiedEventArgs ev)
        {

        }


    }
}