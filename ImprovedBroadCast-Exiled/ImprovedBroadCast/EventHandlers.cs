
using Exiled.Events.EventArgs;

namespace ImprovedBroadCast
{
    public class EventHandlers
    {
        public Plugin plugin;
        public EventHandlers(Plugin plugin) => this.plugin = plugin;
        
      
        public void OnEscape(EscapingEventArgs ev)
        {
            ev.Player.Broadcast(15, plugin.Config.Escaped);
        }

      
        public void OnTesla(TriggeringTeslaEventArgs ev)
        {
            ev.Player.Broadcast(15, plugin.Config.Tesla);
        }
        public void OnStart(StartingEventArgs ev)
        {
            ev.Player.Broadcast(15, plugin.Config.Started);
        }
        public void OnChanging(ChangingRoleEventArgs ev)
        {
            ev.Player.Broadcast(15, plugin.Config.ChangedRole);
        }
        public void OnEnteredPocket(EnteringPocketDimensionEventArgs ev)
        {
            ev.Player.Broadcast(15, plugin.Config.EnteredPocket);
        }
        public void OnEscapedPocket(EscapingPocketDimensionEventArgs ev)
        {
            ev.Player.Broadcast(15, plugin.Config.EscapedPocket);
        }
        public void OnDied(DiedEventArgs ev)
        {
            ev.Target.Broadcast(15, plugin.Config.EscapedPocket);
        }
    }
}
