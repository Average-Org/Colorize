using Microsoft.Xna.Framework;
using TShockAPI;

namespace Colorize
{
    public static class TSPlayerExtensions
    {
        public static void Error(this TSPlayer player, string text)
        {
            player.SendErrorMessage(text);
        }

        public static void Info(this TSPlayer player, string text)
        {
            player.SendInfoMessage(text);
        }

        public static void Msg(this TSPlayer player, string text)
        {
            player.SendMessage(text, Color.White);
        }

        public static void Msg(this TSPlayer player, string text, Color color)
        {
            player.SendMessage(text, color);
        }

        public static void MsgGradient(this TSPlayer player, string text, Color color, Color otherColor)
        {
            player.SendMessage(Tools.TextGradient(text, color, otherColor), Color.White);
        }
    }
}
