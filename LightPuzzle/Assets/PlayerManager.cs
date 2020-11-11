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
        bool moveObject;
        public float speed = 10f;
        private Vector3 delta;


        void Start()
        {
            initPos = transform.position;
            delta = new Vector3(0.5f, 0.5f, 0.5f);
        }
        

        private void Update()
        {
            Vector3 mousePos = Input.mousePosition;
            if (Input.GetMouseButtonDown(0))
            {
                //if((transform.position.x-500f>mousePos.x&& transform.position.z - 500f > mousePos.z)||( transform.position.x + 500f < mousePos.x && transform.position.z + 500f < mousePos.z))
                {
                    moveObject = true;
                }
                
            }

            if (moveObject)
            {
                transform.position = Vector3.MoveTowards(transform.position, mousePos, speed * Time.deltaTime);
            }
            if (transform.position == mousePos)
                moveObject = false;
        }
    }
}
