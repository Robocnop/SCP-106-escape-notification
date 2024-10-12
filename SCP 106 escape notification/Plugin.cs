using Exiled.API.Features;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SCP_106_escape_notification
{
    public class Plugin : Plugin<Config,Translations>
    {
        public override string Name { get; } = "106 Escape notifier";
        public override string Author { get; } = "Hybrid";
        public override Version Version => new Version(1,0,0);
        public static Plugin instance { get; set; }
        public override void OnEnabled()
        {
            instance = this;
            Exiled.Events.Handlers.Player.EscapingPocketDimension += EventHandler.Escaped;
            Exiled.Events.Handlers.Player.FailingEscapePocketDimension += EventHandler.Failed;
            base.OnEnabled();
        }
        public override void OnDisabled()
        {
            Exiled.Events.Handlers.Player.EscapingPocketDimension -= EventHandler.Escaped;
            Exiled.Events.Handlers.Player.FailingEscapePocketDimension -= EventHandler.Failed;
            instance = null;
            base.OnDisabled();
        }

    }
}
