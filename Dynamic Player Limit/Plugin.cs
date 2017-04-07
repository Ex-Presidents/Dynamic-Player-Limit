using Rocket.Core.Plugins;
using SDG.Unturned;
using System;

namespace Kr4ken.DPL
{
    public class Plugin : RocketPlugin
    {
        private DateTime lastCalled;

        public void FixedUpdate()
        {
            if ((DateTime.Now - lastCalled).TotalSeconds > 1)
            {
                lastCalled = DateTime.Now;
                if (Provider.clients.Count == Provider.maxPlayers + 2 && Provider.maxPlayers + 12 < 255)
                    Provider.maxPlayers = (byte)(Provider.maxPlayers + 12);
                /*if (Provider.clients.Count > 22 && Provider.maxPlayers == 24)
                    Provider.maxPlayers = 36;
                else if (Provider.clients.Count > 34 && Provider.maxPlayers == 36)
                    Provider.maxPlayers = 48;*/
            }
        }
    }
}