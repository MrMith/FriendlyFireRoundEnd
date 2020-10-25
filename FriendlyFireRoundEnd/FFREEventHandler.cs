using GameCore;
using Smod2;
using Smod2.EventHandlers;
using Smod2.Events;

namespace FriendlyFireRoundEnd
{
	class FFREEventHandler : IEventHandlerRoundEnd, IEventHandlerWaitingForPlayers
	{
		private readonly Plugin plugin;

		public FFREEventHandler(Plugin plugin)
		{
			this.plugin = plugin;
		}

		public void OnRoundEnd(RoundEndEvent ev)
		{
			SetFriendly(true);
		}

		public void OnWaitingForPlayers(WaitingForPlayersEvent ev)
		{
			if(plugin.GetConfigBool("ffre_disable"))
			{
				plugin.PluginManager.DisablePlugin(plugin);
			}

			SetFriendly(false);
		}

		public void SetFriendly(bool IsOn)
		{
			if (ConfigFile.ServerConfig.GetBool("friendly_fire")) return;

			ServerConsole.FriendlyFire = IsOn;
			ServerConfigSynchronizer.Singleton.NetworkMainBoolsSync = Misc.BoolsToByte(ServerConsole.FriendlyFire); //I'll be honest, I don't fucking know what this does but it works so uh :)
		}
	}
}