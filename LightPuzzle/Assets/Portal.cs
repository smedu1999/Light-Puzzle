using lightPuzzleGame;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assets
{
    class Portal
    {
        public PortalElement Gate1 { get; set; }
        public PortalElement Gate2 { get; set; }
        public Portal()
        {
            Gate1 = new PortalElement(Gate2);
        }

    }

    class PortalElement : GameElement
    {
        List<Light> Light;
        PortalElement MyPair;
        public PortalElement(PortalElement pair)
        {
            MyPair = pair;
            Light = new List<Light>();
        }
        public void OnLightCollided(Light light)
        {
            MyPair.Light.Add(light);
        }
    }


}
