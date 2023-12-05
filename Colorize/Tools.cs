using Microsoft.Xna.Framework;
using System.Text;
using Terraria;
using Terraria.ID;

namespace Colorize
{
    public static class Tools
    {
        public static string ColorizeText(string text, Color color)
        {
            return $"[c/{color.Hex3()}:{text}]";
        }

        public static string GradientText(string text, Color color, Color otherColor)
        {
            StringBuilder gradientedText = new();

            var index = 0;
            foreach (char c in text)
            {
                float ratio = (float)index / (text.Length - 1);
                Color thisColor = Color.Lerp(color, otherColor, ratio);
                gradientedText.Append($"[c/{thisColor.Hex3()}:{c}]");
            }
            return gradientedText.ToString();
        }

        public static string ItemIcon(Item item)
        {
            return ItemIcon(item.type);
        }

        public static string ItemIcon(ItemID itemID)
        {
            return ItemIcon(itemID);
        }

        public static string ItemIcon(int itemID)
        {
            return $"[i/{itemID}]";
        }
    }
}