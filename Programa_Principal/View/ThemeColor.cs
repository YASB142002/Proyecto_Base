using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programa_Principal.View
{
    public static class ThemeColor
    {
        private static int tempIndex;
        public static List<string> ColorList = new List<string>() 
        { 
            "#3F51B5",
            "#009688",
            "#FF5722",
            "#607D8B",
            "#FF9800",
            "#9C27B0",
            "#40B2A7",
            "#EA676C",
            "#E41A4A",
            "#5978BB",
            "#018790",
            "#0E3441",
            "#FF5733",
            "#721D47",
            "#EA4833",
            "#EF937E",
            "#F37521",
            "#A12059",
            "#126881",
            "#8BC240",
            "#3600FF",
            "#C7DC5B",
            "#900C3F",
            "#E4126B",
            "#43B76E",
            "#FFC300",
            "#B71C46"
        };
        public static Color ChangeColorBrightness(Color color, double correctionFactor)
        {
            double red = color.R;
            double green = color.G;
            double blue = color.B;
            //If correction factor is less than 0, darken color.
            if (correctionFactor < 0)
            {
                correctionFactor = 1 + correctionFactor;
                red *= correctionFactor;
                green *= correctionFactor;
                blue *= correctionFactor;
            }
            //If correction factor is greater than zero, lighten color.
            else
            {
                red = (255 - red) * correctionFactor + red;
                green = (255 - green) * correctionFactor + green;
                blue = (255 - blue) * correctionFactor + blue;
            }
            return Color.FromArgb(color.A, (byte)red, (byte)green, (byte)blue);
        }
        public static Color SelectThemeColor()
        {
            Random random = new Random();
            
            int index = random.Next(ThemeColor.ColorList.Count);

            while (tempIndex == index)
                index = random.Next(ThemeColor.ColorList.Count);

            tempIndex = index;
            return ColorTranslator.FromHtml(ThemeColor.ColorList[index].ToString());
        }
    }
}
