using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PluginAPI;
using PluginAPI.Core.Attributes;
using PluginAPI.Events;

namespace BallSurvival
{
    public class Plugin
    {
        [PluginEntryPoint("BallGame", "0.5.0", "Survive the balls", "BorkoAXT")]

        public void Setup()
        {
            EventManager.RegisterEvents(this);
        }
    }
}