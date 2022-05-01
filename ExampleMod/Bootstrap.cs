using MelonLoader;
using ExampleMod;
using ExampleMod.Patches;

[assembly: MelonGame("Crows Crows Crows", "The Stanley Parable: Ultra Deluxe")]
[assembly: MelonInfo(typeof(Bootstrap), "Example Mod", "0.0.1", "Your name here", "https://github.com/myaccount/my-repo")]
namespace ExampleMod
{
    public class Bootstrap : MelonMod
    {
        private const string SettingsCategory = "Example Mod";
        private const string EnabledSetting = "Enabled";

        /// <summary>
        /// Singleton
        /// </summary>
        public static Bootstrap Instance { get; private set; }

        public override void OnApplicationStart()
        {
            Instance = this;
            var category = MelonPreferences.CreateCategory(SettingsCategory, SettingsCategory);

            // TODO: Settings example

            MelonLogger.Msg("Patching methods...");
            HarmonyInstance.PatchAll();

            // Example patch!
            StanleyControllerPatch.PatchController();
            MelonLogger.Msg("Applied patches successfully!");
        }
    }
}
