using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace memoryGame
{
    class Heroes
    {
        public static List<Image> getHeroes() => new List<Image>
            {
                Properties.Resources.blueHero,
                Properties.Resources.glassHero,
                Properties.Resources.purpleHero,
                Properties.Resources.redHero,
                Properties.Resources.sheHero,
                Properties.Resources.spyHero,
                Properties.Resources.ufoHero,
                Properties.Resources.yellowHero
            };
    }
}
