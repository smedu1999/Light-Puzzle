using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DragObject : MonoBehaviour
{
    /*private Vector3 mOffset;
    private float mZCoord;

    void OnMouseDown()
    {
        mZCoord = Camera.main.WorldToScreenPoint(gameObject.transform.position).z;
        mOffset = gameObject.transform.position - GetMouseAsWorldPoint();
    }

    private Vector3 GetMouseAsWorldPoint()
    {
        Vector3 mousePoint = Input.mousePosition;
        mousePoint.z = mZCoord;
        
        return Camera.main.ScreenToWorldPoint(mousePoint);
    }

    void OnMouseDrag()
    {
        transform.position = new Vector3(GetMouseAsWorldPoint().x + mOffset.x, transform.position.y, GetMouseAsWorldPoint().z + mOffset.z);
        //transform.position = GetMouseAsWorldPoint() + mOffset;
    }
   
    */
    private Vector3 screenPoint;
    private Vector3 offset;

    void OnMouseDown()
    {
        /*Vector3 mouse = new Vector3(Input.mousePosition.x, Input.mousePosition.y, Input.mousePosition.z);
        offset = gameObject.transform.position - Camera.main.ScreenToWorldPoint(mouse);*/
        
    }
    void OnMouseDrag()
    {
     
        Plane plane = new Plane(Vector3.up, new Vector3(0, transform.position.y, 0));
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        float distance;
        if (plane.Raycast(ray, out distance))
        {
            transform.position = ray.GetPoint(distance);
        }
    }
  
}
    

