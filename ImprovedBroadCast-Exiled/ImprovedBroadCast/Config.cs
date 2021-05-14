using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Exiled.API.Interfaces;
using System.ComponentModel;

namespace ImprovedBroadCast
{
    public class Config : IConfig
    {
        [Description("Whether or not this plugin is enabled ")]
        public bool IsEnabled { get; set; } = true;


        [Description("Setup Broadcast for Escaped Players")]
        public string Escaped { get; set; } = "Your Text";



        [Description("Setup Broadcast for Changed Role Players")]
        public string ChangedRole { get; set; } = "Your Text";

        [Description("Setup Broadcast for Started Round")]
        public string Started { get; set; } = "Your Text";

        [Description("Setup Broadcast for Killed Player")]
        public string Killed { get; set; } = "Your Text";

        [Description("Setup Broadcast when a player trapped in a pocket dimension")]
        public string EnteredPocket { get; set; } = "Your Text";

        [Description("Setup Broadcast when a player escaped from a pocket dimension")]
        public string EscapedPocket { get; set; } = "Your Text";

        [Description("Setup  broadcast when a player activated tesla gate ")]
        public string Tesla { get; set; } = "Your Text";
    }
}
