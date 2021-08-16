
namespace ConsoleLogsRemix.EventHandlers
{
    using ConsoleLogsRemix.Handlers;
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

            string tRole;
            string kRole;
            Dictionaries.Roletypes.TryGetValue(ev.Target.Role.ToString(), out tRole);
            Dictionaries.Roletypes.TryGetValue(ev.Killer.Role.ToString(), out kRole);

            string item;
            Dictionaries.Itemtypes.TryGetValue(ev.Killer.CurrentItem.id, out item);
            if (item != " ")
            {
                item = "Granatem";
            }

            string message = $"{ev.Killer.Nickname} ({kRole}) zabi³ {ev.Target.Nickname} ({tRole}) zadaj¹c mu {damageRound} obra¿eñ {item}";
            string messageTK = $"{ev.Killer.Nickname} zabi³ swojego teammate'a {ev.Target.Nickname} ({tRole}) zadaj¹c mu {damageRound} obra¿eñ {item}";
            string id = $"ID zabójcy: {ev.Killer.Id} || ID ofiary: {ev.Target.Id}";


            Log.Info(message);
            Log.Info(id);

            foreach (string steamID in Plugin.Instance.Config.steamids)
            {
                Player admin = Player.Get(steamID);
                if (tRole != kRole) 
                {
                    admin?.RemoteAdminMessage(message, true);
                }
                else
                {
                    if (tRole == kRole)
                    {
                        admin?.RemoteAdminMessage(messageTK, true);
                        ev.Killer.RankName = "TEAMKILLER";
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