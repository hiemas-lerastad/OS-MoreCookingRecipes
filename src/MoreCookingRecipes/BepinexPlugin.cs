using BepInEx;
using BepInEx.Logging;
using MoreCookingRecipes.Settings;
using System.IO;
using System.Reflection;

namespace MoreCookingRecipes;

[BepInPlugin(LCMPluginInfo.PLUGIN_GUID, LCMPluginInfo.PLUGIN_NAME, LCMPluginInfo.PLUGIN_VERSION)]
public class Plugin : BaseUnityPlugin
{
  internal static ManualLogSource Log = null!;
  internal static MoreCookingRecipesSettings Settings = null!;

  private void Awake()
  {
    Log = Logger;
    Log.LogInfo($"Plugin {LCMPluginInfo.PLUGIN_NAME} version {LCMPluginInfo.PLUGIN_VERSION} is loaded!");

    string itemsPath = Path.Combine(Assembly.GetExecutingAssembly().Location.Substring(0, Assembly.GetExecutingAssembly().Location.Length - 22), "Items.json");
    string recipesPath = Path.Combine(Assembly.GetExecutingAssembly().Location.Substring(0, Assembly.GetExecutingAssembly().Location.Length - 22), "Recipes.json");

    Lavender.Lavender.AddCustomItemsFromJson(itemsPath, LCMPluginInfo.PLUGIN_NAME);
    Lavender.Lavender.AddCustomRecipesFromJson(recipesPath, LCMPluginInfo.PLUGIN_NAME);
  }

}
