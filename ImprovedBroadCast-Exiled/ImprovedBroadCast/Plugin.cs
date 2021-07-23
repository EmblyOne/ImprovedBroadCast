using Exiled.API.Features;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Player = Exiled.Events.Handlers.Player;

namespace ImprovedBroadCast
{
    public class Plugin : Plugin<Config>
    {
        public override string Author { get; } = "Space";
        public override string Name { get; } = "ImprovedBroadCast";
        public override string Prefix { get; } = "ImprovedBroadCast";
        public override Version Version { get; } = new Version(1, 0, 0);
        public override Version RequiredExiledVersion { get; } = new Version(2, 10, 0);

        public EventHandlers EventHandler;



        public override void OnEnabled()
        {
            if(!Config.IsEnabled) return;
            EventHandler = new EventHandlers(this);
            Player.Escaping += EventHandler.OnEscape;
            Player.ChangingRole += EventHandler.OnChanging;
            Player.Died += EventHandler.OnDied;
            Player.EnteringPocketDimension += EventHandler.OnEnteredPocket;
            Player.EscapingPocketDimension += EventHandler.OnEscapedPocket;

            base.OnEnabled();
        }
        public override void OnDisabled()
        {
            Player.Escaping -= EventHandler.OnEscape;
            Player.ChangingRole += EventHandler.OnChanging;
            Player.Died -= EventHandler.OnDied;
            Player.EnteringPocketDimension -= EventHandler.OnEnteredPocket;
            Player.EscapingPocketDimension -= EventHandler.OnEscapedPocket;
            EventHandler = null;
        }

    }



}
