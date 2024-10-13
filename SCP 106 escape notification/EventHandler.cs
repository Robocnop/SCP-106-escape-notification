using Exiled.API.Features;
using Exiled.Events.EventArgs.Player;
using PlayerRoles;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SCP_106_escape_notification
{
    public class EventHandler
    {
        public static void Escaped(EscapingPocketDimensionEventArgs ev)
        {
            StringBuilder sb = new StringBuilder();
            sb.Append(Plugin.instance.Translation.Escapehint);
            sb.Replace("[PLAYERNAME]", ev.Player.Nickname);
            foreach (Player role in Player.List)
            {
                if (role.Role == RoleTypeId.Scp106)
                {
                    role.ShowHint(sb.ToString());
                }

            };
            
            
        }
        public static void Failed(FailingEscapePocketDimensionEventArgs ev)
        {
            StringBuilder sb = new StringBuilder();
            sb.Append(Plugin.instance.Translation.Failedhint);
            sb.Replace("[PLAYERNAME]",ev.Player.Nickname);
           foreach (Player role in Player.List)
            {
                if (role.Role == RoleTypeId.Scp106)
                {
                    role.ShowHint(sb.ToString());
                }
            }
        }
    }
}
