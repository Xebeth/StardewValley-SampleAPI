using StardewModdingAPI;

namespace ModWithAPI
{
    // ReSharper disable once UnusedMember.Global
    public class ModWithAPI: Mod
    {
        public override object GetApi()
        {
            return new ModAPI();
        }

        public override void Entry(IModHelper helper)
        {
            
        }
    }
}
