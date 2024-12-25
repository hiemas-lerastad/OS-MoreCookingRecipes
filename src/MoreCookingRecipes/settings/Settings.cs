using BepInEx.Configuration;

namespace MoreCookingRecipes.Settings;

public class MoreCookingRecipesSettings(ConfigFile config)
{
    public ConfigEntry<bool> MySettingsBool = config.Bind<bool>("SectionName", "MySettingsBool", true, "This is an example boolean setting!");
}
