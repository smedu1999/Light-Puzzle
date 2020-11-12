using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;
using UnityEngine.UIElements;

namespace Assets
{
    class PlayerManager : MonoBehaviour
    {
        [SerializeField]
        private object emptyPlace;
        private Vector3 initPos;
        float deltaX, deltaY, deltaZ;


        void Start()
        {
            initPos = transform.position;
        }
        

        private void Update()
        {
            if (Input.GetMouseButtonDown(0))
            {
                Vector3 mousePos = Input.mousePosition;

                //if(GetComponent<BoxCollider>()==Physics.OverlapBox(mousePos,new Vector3(deltaX,deltaY,deltaZ))
            }
        }
    }
}
