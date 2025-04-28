using System.Collections.Generic;
using System.Reflection;

using HarmonyLib;

internal class Dayuppy_BuildIntervalPatches
{
    [HarmonyPatch]
    public class GameManagercreateWorldBuildInterval
    {
        private static IEnumerable<MethodInfo> TargetMethods()
        {
            yield return AccessTools.EnumeratorMoveNext(AccessTools.Method(typeof(GameManager), "createWorld"));
        }

        public static void Postfix(GameManager __instance)
        {
            Constants.cBuildIntervall = 0.35f;
        }
    }
}