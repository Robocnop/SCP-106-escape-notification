using Exiled.API.Interfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SCP_106_escape_notification
{
    public class Translations : ITranslation
    {
        [Description("What you want the escape hint to say!")]
        public string Escapehint = "[PLAYERNAME] has Escaped Your Dimention!";

        [Description("What you want the failed escape message to say!")]
        public string Failedhint = "[PLAYERNAME] Died in your dimention!";
    }
}
