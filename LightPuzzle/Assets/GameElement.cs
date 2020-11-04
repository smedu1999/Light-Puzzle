using UnityEngine;

namespace lightPuzzleGame
{
    internal class GameElement
    {
        public Vector3 Position { get; set; }
        public GameElement()
        {
            Position = new Vector3(100, 200, 300);
        }       
    }
}