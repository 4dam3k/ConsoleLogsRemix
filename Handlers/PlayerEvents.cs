
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
            string killerid = $"Zabójca posiada ID: {ev.Killer.UserId}";
            string targetid = $"Ofiara posiada ID: {ev.Target.UserId}";

            foreach (string steamID in Plugin.Instance.Config.steamids)
            {
                var admin = Player.Get(steamID);
                admin?.RemoteAdminMessage(message, true);
                admin?.RemoteAdminMessage(killerid, true);
                admin?.RemoteAdminMessage(targetid, true);

            }


        }
        /// <inheritdoc cref="Exiled.Events.Handlers.Player.OnDied(DiedEventArgs)"/>
        public void OnDied(DiedEventArgs ev)
        {

        }


    }
}