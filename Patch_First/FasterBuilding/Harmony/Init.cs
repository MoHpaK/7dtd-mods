using System.Reflection;

using HarmonyLib;

public class FasterBuilding : IModApi
{
    public void InitMod(Mod _modInstance)
    {
        Harmony harmony = new Harmony(GetType().ToString());
        harmony.PatchAll(Assembly.GetExecutingAssembly());
    }
}