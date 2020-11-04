using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace lightPuzzleGame
{

    public class NewBehaviourScript : MonoBehaviour
    {
        // Start is called before the first frame update
        public Rigidbody rb;
        void Start()
        {
            var n = new GameElement();            
            rb.AddForce(n.Position);

        }

        // Update is called once per frame
        void Update()
        {
           // rb.AddForce(new Vector3(10, 20, 30));
        }
    }
}