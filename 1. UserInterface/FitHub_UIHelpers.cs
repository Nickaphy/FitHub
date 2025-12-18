using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FitHub_UserInterface
{
    // This is a try to make UI, we dont use it, as we found a better solution - Lasse and Erik
   public class VerticalTabSettings
    {
        //-90f roterer mod venstre
        //90f rotererer mod højre
        public float Angle { get; set; } = -90f;    //  Default angle for vertical text
        public Font Font { get; set; } = SystemFonts.DefaultFont;   // Default font
        public Brush Brush { get; set; } = Brushes.Black;       // Default brush color

        //justeringer der kan tunes til efter behov

        public int OfsetX { get; set; } = 0;                           // X offset from the left edge of the tab
        public int OfsetY { get; set; } = 0;                            // Y offset from the bottom edge of the tab
        public Size ItemSize { get; set; } = new Size(0, 0);         // Default size for each tab item

    }

    public static class VerticalTabHelper
    {
        private static readonly Dictionary<TabControl, VerticalTabSettings> settingsMap = 
            new Dictionary<TabControl, VerticalTabSettings>();

        public static void Apply(TabControl tc, VerticalTabSettings settings = null)
        {
            if (tc == null) return;

            if (settings == null) settings = new VerticalTabSettings();

            settingsMap[tc] = settings;

            tc.Alignment = TabAlignment.Left;   //  Juster fanerne til venstre
            tc.Multiline = true;                 //  Tillad flere rækker af faner, hvis nødvendigt
            tc.DrawMode = TabDrawMode.OwnerDrawFixed;
            tc.ItemSize = settings.ItemSize;
            tc.SizeMode = TabSizeMode.Fixed;

            //fjern eventuelle tidligere tilknyttede hændelser for at undgå duplikater
            tc.DrawItem -= Tc_DrawItem;
            tc.DrawItem += Tc_DrawItem;
        }

        private static void Tc_DrawItem(object sender, DrawItemEventArgs e)
        {
            var tc = sender as TabControl;
            if (tc == null || !settingsMap.ContainsKey(tc)) return;

            var s = settingsMap[tc];

            if (e.Index < 0 || e.Index >= tc.TabPages.Count) return;

            TabPage page = tc.TabPages[e.Index];

            Rectangle rect = e.Bounds;      //  for at venstre stille fanerne

            string text = page.Text;

            var font = s.Font ?? tc.Font;

            // Mål størrelsen på teksten, bemærl vi måler med udroteret orientation i tankerne
            SizeF textSize = e.Graphics.MeasureString(text, font);

            using (Brush brush = new SolidBrush(((SolidBrush)s.Brush).Color))
            {
                //beregn translation så teksten centrerer i tab-området
                //for at venstre aligne tabs:
                //- rect.left er fanes venstre kant
                //- rect.top/bottom angiver top og bund ad det individuelle tab

                //vi ønsker at placere origin et stykke inde fra venstre kant og centrerer langs tabsbredden
                float translateX = rect.Left + s.OfsetX + (textSize.Height / 2f);

                //Centrerer lodret i tabbåndet; brug midten af "rect"'s højde
                float translateY = rect.Top + rect.Height / 2f + (textSize.Width / 2f) - s.OfsetY;

                e.Graphics.TranslateTransform(translateX, translateY);
                e.Graphics.RotateTransform(s.Angle);

                //hvis tab er valgt kan du ændre font-stil eller farve her
                Font drawFont = font;
                if ((e.State & DrawItemState.Selected) == DrawItemState.Selected)
                {
                    drawFont = new Font(font, FontStyle.Bold);
                }

                //Tegn tekst med top-left (0,0) efter transform
                e.Graphics.DrawString(text, drawFont, brush, new PointF(0, 0));

                e.Graphics.ResetTransform();
            }
        }
    }
}
