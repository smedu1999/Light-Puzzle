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
        }

    }

    class PortalElement : GameElement
    {

            public void OnLightCollided(object sender, PortalElement otherGate)
        { 

        }
    }


}
