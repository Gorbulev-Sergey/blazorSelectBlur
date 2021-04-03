using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace blazorAuth1.Models
{
    public class editor
    {
        public color color { get; set; } = new color();  
        public double blur { get; set; } = 29;
        public double border_radius { get; set; } = .21;
        public shadow shadow { get; set; } = new shadow();
    }

    public class color
    {
        public color(int r=255, int g=255, int b=255, double opacity=.51)
        {
            this.r = r;
            this.g = g;
            this.b = b;
            this.opacity = opacity;
        }
        public int r { get; set; }
        public int g { get; set; }
        public int b { get; set; }
        public double opacity { get; set; }
    }

    public class shadow
    {
        public int x { get; set; } = 0;
        public int y { get; set; } = 0;
        public double blur { get; set; } = 1;
        public int radius { get; set; } = 1;
        public color color { get; set; } = new color(r: 0, g: 0, b: 0, opacity: .28);
    }
}
