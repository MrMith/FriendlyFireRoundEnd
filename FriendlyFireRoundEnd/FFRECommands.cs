using Smod2.Commands;
using Smod2;

namespace FriendlyFireRoundEnd
{
	class FFREVersion : ICommandHandler
	{
		private Plugin plugin;

		public FFREVersion(Plugin plugin)
		{
			this.plugin = plugin;
		}

		public string GetCommandDescription()
		{
			return "Gets version for debugging";
		}

		public string GetUsage()
		{
			return $"{plugin.Details.configPrefix}_version";
		}

		public string[] OnCall(ICommandSender sender, string[] args)
		{
			return new string[] { plugin.Details.id + " is version " + plugin.Details.version };
		}
	}

	class FFREDisable : ICommandHandler
	{
		private Plugin plugin;

		public ARDisable(Plugin plugin)
		{
			this.plugin = plugin;
		}

		public string GetCommandDescription()
		{
			return $"Enables or disables {plugin.Details.id}.";
		}

		public string GetUsage()
		{
			return $"{plugin.Details.configPrefix}_disable";
		}

		public string[] OnCall(ICommandSender sender, string[] args)
		{
			Smod2.PluginManager.Manager.DisablePlugin(plugin.Details.id);
			return new string[] { "Disabled " + plugin.Details.id };
		}
	}
}
