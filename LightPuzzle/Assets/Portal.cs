using lightPuzzleGame;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace Assets
{
    class Portal
    {
        public PortalElement Gate1 { get; set; }
        public PortalElement Gate2 { get; set; }
        public Portal()
        {
            Gate1 = new PortalElement();
            Gate2 = new PortalElement();

            Gate1.MyPair = Gate2;
            Gate2.MyPair = Gate1;
        }

    }

    class PortalElement : GameElement
    {
        public List<Light> Lights { get; set; }
        public PortalElement MyPair { get; set; }
        public PortalElement()
        {
            Lights = new List<Light>();
        }
        public void OnLightCollided(Light light)
        {
            light.Lines.Add(new Line());
            MyPair.Lights.Add(light);
        }

        public void OnMove(Vector3 pos)
        {
            Lights.Clear();
            Position = pos;
        }
    }


}
