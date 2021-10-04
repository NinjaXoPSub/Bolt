using DiscordRPC;

namespace BoltCUI
{
    internal class DiscordRPC1
    {
        public static DiscordRpcClient client;

        public static void Initialize()
        {
            client = new DiscordRpcClient("894461908659363840");
            client.Initialize();
            client.SetPresence(new RichPresence
            {
                Details = "https://discord.gg/dNk3mzZ3uE",
                State = "Paradise AIO",
                Timestamps = Timestamps.Now,
                Assets = new Assets
                {
                    LargeImageKey = "paradise_logo",
                    LargeImageText = "https://discord.gg/dNk3mzZ3uE"
                }
            });
        }
    }
}
