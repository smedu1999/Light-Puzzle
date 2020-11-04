using UnityEngine;

namespace lightPuzzleGame
{
    internal class GameElement
    {
        public bool t { get; set; }
        public Vector3 vec { get; set; }
        public GameElement()
        {
            t = true;
            vec = new Vector3(200, 200, 200);
        }
    }
}