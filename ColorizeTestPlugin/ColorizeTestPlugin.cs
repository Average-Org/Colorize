using Colorize;
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using TerrariaApi.Server;
using TShockAPI;
using static Colorize.Tools;

namespace ColorizeTestPlugin
{
    [ApiVersion(2, 1)]
    public class ColorizeTestPlugin : TerrariaPlugin
    {
        public override string Name => "ColorizeTestPlugin";
        public ColorizeTestPlugin(Main game) : base(game)
        {
        }

        public override void Initialize()
        {
            Commands.ChatCommands.Add(new Command("test", (x) => {
                x.Player.Msg($"" +
                    $"{TextColor("<Prefix> ", Color.LightBlue)}" +    
                    $"{TextColor("This is an ", Color.LightGreen)}" +  
                    $"{TextColor("oddly colored ", Color.Magenta)}" +  
                    $"{TextColor("chat message!", Color.Cyan)}");    
            }, "test"));


            Commands.ChatCommands.Add(new Command("testgradient", (x) =>
            {
                x.Player.MsgGradient("Woaaah this text is gradient-ed!", Color.LightGreen, Color.OrangeRed);
            }, "testgradient")); // you can also use TextGradient for changing individual string gradients

            Commands.ChatCommands.Add(new Command("testitem", (x) =>
            {
                x.Player.Msg(ItemIcon(ItemID.AaronsBreastplate) + ItemIcon(ItemID.CopperShortsword) + ItemIcon(ItemID.SlimeCandle));
            }, "testitem"));
        }


    }
}