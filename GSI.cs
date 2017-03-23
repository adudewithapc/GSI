using Terraria.ModLoader;

namespace GSI
{
	class GSI : Mod
	{
        public GSI()
        {
            Properties = new ModProperties()
            {
                Autoload = true,
                AutoloadGores = true,
                AutoloadSounds = true
            };
        }
	}
}