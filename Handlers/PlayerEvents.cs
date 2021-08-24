
namespace ConsoleLogsRemix.EventHandlers
{
    using ConsoleLogsRemix.Handlers;
    using Exiled.API.Features;
    using Exiled.Events.EventArgs;
    using ConsoleLogsRemix;

    /// <summary>
    /// Handles all events subscribed from <see cref="Exiled.Events.Handlers.Player"/>.
    /// </summary>
    public class PlayerEvents
    {
        /// <inheritdoc cref="Exiled.Events.Handlers.Player.OnDying(DyingEventArgs)"/>
        public void OnDying(DyingEventArgs ev)
        {
            float damageNotRounded = ev.HitInformation.Amount;
            int damageRound = (int)damageNotRounded;

            string tRole;
            string kRole;
            //Dictionaries.Roletypes.TryGetValue(ev.Target.Role.ToString(), out tRole);
            //Dictionaries.Roletypes.TryGetValue(ev.Killer.Role.ToString(), out kRole);
            Plugin.Instance.Config.Roletypes.TryGetValue(ev.Target.Role.ToString(), out tRole);
            Plugin.Instance.Config.Roletypes.TryGetValue(ev.Killer.Role.ToString(), out kRole);



            string message = Plugin.Instance.Config.Killlogs
                .Replace("$knick", ev.Killer.Nickname)
                .Replace("$tnick", ev.Target.Nickname)
                .Replace("$krole", kRole)
                .Replace("$trole", tRole)
                .Replace("$damage", damageRound.ToString());
            string messageTK = Plugin.Instance.Config.Teamkilllogs
                .Replace("$knick", ev.Killer.Nickname)
                .Replace("$tnick", ev.Target.Nickname)
                .Replace("$trole", tRole)
                .Replace("$damage", damageRound.ToString());
            string id = Plugin.Instance.Config.Idlogs
                .Replace("$kid", ev.Killer.Id.ToString())
                .Replace("$tid", ev.Target.Id.ToString());


            Log.Info(message);
            Log.Info(id);

            foreach (string steamID in Plugin.Instance.Config.steamids)
            {
                Player admin = Player.Get(steamID);
                if (ev.Killer.Side != ev.Target.Side) 
                {
                    admin?.RemoteAdminMessage(message, true);
                }
                else
                {
                    if (ev.Killer.Side == ev.Target.Side)
                    {
                        admin?.RemoteAdminMessage(messageTK, true);
                    }
                }
                admin?.RemoteAdminMessage(id, true);

            }
        }
        /// <inheritdoc cref="Exiled.Events.Handlers.Player.OnDied(DiedEventArgs)"/>
        public void OnDied(DiedEventArgs ev)
        {

        }


    }
}