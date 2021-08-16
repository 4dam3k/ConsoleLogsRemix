
namespace ConsoleLogsRemix
{
    using ConsoleLogsRemix.EventHandlers;
    using Exiled.API.Features;
    using PlayerHandlers = Exiled.Events.Handlers.Player;
    using ServerHandlers = Exiled.Events.Handlers.Server;

    /// <summary>
    /// The main plugin class.
    /// </summary>
    public class Plugin : Plugin<Config>
    {
        private static readonly Plugin InstanceValue = new Plugin();

        private Plugin()
        {
        }

        /// <summary>
        /// Gets an instance of the <see cref="Plugin"/> class.
        /// </summary>
        public static Plugin Instance { get; } = InstanceValue;

        /// <inheritdoc />
        public override string Prefix { get; } = "ConsoleLogsRMX";

        /// <summary>
        /// Gets an instance of the <see cref="EventHandlers.PlayerEvents"/> class.
        /// </summary>
        public PlayerEvents PlayerEvents { get; private set; }

        /// <summary>
        /// Gets an instance of the <see cref="EventHandlers.ServerEvents"/> class.
        /// </summary>
        public ServerEvents ServerEvents { get; private set; }

        /// <inheritdoc />
        public override void OnEnabled()
        {
            ServerEvents = new ServerEvents();
            PlayerEvents = new PlayerEvents();

            PlayerHandlers.Died += PlayerEvents.OnDied;
            PlayerHandlers.Dying += PlayerEvents.OnDying;

            base.OnEnabled();
        }

        /// <inheritdoc />
        public override void OnDisabled()
        {
            PlayerHandlers.Died -= PlayerEvents.OnDied;
            PlayerHandlers.Dying -= PlayerEvents.OnDying;

            PlayerEvents = null;
            ServerEvents = null;
            base.OnDisabled();
        }
    }
}
