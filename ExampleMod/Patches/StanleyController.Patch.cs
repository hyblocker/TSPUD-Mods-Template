using HarmonyLib;
using MelonLoader;

namespace ExampleMod.Patches
{
    public static class StanleyControllerPatch
    {
        public static void PatchController()
        {
            Hooking.Hook(typeof(StanleyController).GetMethod("Update", AccessTools.all), typeof(StanleyControllerPatch).GetMethod("StanleyInitPatch", AccessTools.all));
        }

        private static void StanleyInitPatch(StanleyController __instance)
        {
            MelonLogger.Msg($"FOV: { __instance.cam.fieldOfView }");
        }
    }
}