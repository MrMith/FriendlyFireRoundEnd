using Smod2;
using Smod2.Attributes;

namespace FriendlyFireRoundEnd
{
	[PluginDetails(
		author = "Mith",
		name = "FriendlyFireRoundEnd",
		description = "Turns on friendly fire for everyone on roundend.",
		id = "mith.FriendlyFireRoundEnd",
		version = "1.0.0",
		SmodMajor = 3,
		SmodMinor = 9,
		SmodRevision = 3
		)]
	class FFREMain : Plugin
	{
		public override void OnDisable()
		{
			this.Info($"{this.Details.name}(Version:{this.Details.version}) has been disabled.");
		}

		public override void OnEnable()
		{
			this.Info($"{this.Details.name}(Version:{this.Details.version}) has been enabled.");
		}

		public override void Register()
		{
			this.AddCommand("ffre_version", new FFREVersion(this));
			this.AddCommand("ffre_disable", new FFREDisable(this));
			this.AddEventHandlers(new FFREEventHandler(this));

			this.AddConfig(new Smod2.Config.ConfigSetting("ffre_disable", false, true, "Enable or disable FriendlyFireRoundEnd."));
		}
	}
}