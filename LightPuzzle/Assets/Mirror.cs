using lightPuzzleGame;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assets
{
    class Mirror : GameElement
    {
        public void OnLightCollided(Light light)
        {
            light.Lines.Add(new Line());
            
        }
    }
}
