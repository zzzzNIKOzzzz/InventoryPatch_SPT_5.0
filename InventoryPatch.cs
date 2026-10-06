using BepInEx;
using BepInEx.Logging;
using BepInEx.Unity.IL2CPP;
using HarmonyLib;
using EFT.InventoryLogic;

namespace InventoryPatch
{
    [BepInPlugin("com.zzznikozzz.inventorypatch", "InventoryPatch", "1.0.0")]
    public class InventoryPatchPlugin : BasePlugin
    {
        internal static ManualLogSource Logger;

        public override void Load()
        {
            Logger = Log;

            Logger.LogInfo("zzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz");
            Logger.LogInfo("InventoryPatch by zzzNIKOzzz is loading... ... ... ... ... ... ... ... ... ...");
            Logger.LogInfo("zzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz");

            var harmony = new Harmony("com.zzznikozzz.inventorypatch");
            int patched = 0;

            PatchMethod(harmony, typeof(InventoryController), "IsAtReachablePlace", ref patched);
            PatchMethod(harmony, typeof(InventoryController), "IsAtBindablePlace", ref patched);

            Logger.LogInfo("InventoryPatch: " + patched + " патчи УСПЕШНО применены. И это прекрасно!  Да?");
            Logger.LogInfo("zzzNIKOzzz: Я эту медицину хоть из дикого использую! Рюкзаки, подсумки, похуй!");
        }

        private static void PatchMethod(Harmony harmony, System.Type type, string name, ref int count)
        {
            var m = AccessTools.Method(type, name);
            if (m != null)
            {
                harmony.Patch(m, prefix: new HarmonyMethod(
                    typeof(InventoryPatchPlugin), nameof(AlwaysTrue)));
                count++;
                Logger.LogInfo("Patched: " + name);
            }
        }

        private static bool AlwaysTrue(ref bool __result)
        {
            __result = true;
            return false;
        }
    }
}
