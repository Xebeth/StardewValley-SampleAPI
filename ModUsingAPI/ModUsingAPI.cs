using StardewModdingAPI;

namespace ModUsingAPI
{
    public interface IModAPI
    {
        IThing GetThing(string example);
    }

    public interface IThing
    {
        string DoStuff(int stuff);
    }

    public class ModUsingAPI : Mod
    {
        public override void Entry(IModHelper helper)
        {
            helper.Events.GameLoop.GameLaunched += (sender, args) =>
            {
                const string apiModID = "Blackclaw.ModWithAPI";
                var api = helper.ModRegistry.GetApi<IModAPI>(apiModID);
                var thing = api?.GetThing("answer to the ultimate question of life, the universe and everything");

                if (thing != null)
                {
                    Monitor.Log($"Thing do stuff for 3: {thing.DoStuff(3)}", LogLevel.Info);
                    Monitor.Log($"Thing do stuff for 42: {thing.DoStuff(42)}", LogLevel.Info);
                }
                else
                {
                    Monitor.Log($"Couldn't get the API for Mod {apiModID}", LogLevel.Error);
                }
            };
        }
    }
}
