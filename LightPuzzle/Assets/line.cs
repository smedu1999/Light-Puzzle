using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Line : MonoBehaviour
{
    public int maxstep = 200;
    private int maxref = 20;

    //private LineRenderer lr;

    // Start is called before the first frame update
    void Start()
    {
    //    lr = GetComponent<LineRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
      /*  RaycastHit hit;
        if (Physics.Raycast(transform.position, transform.forward, out hit))
        {
            if (hit.collider)
            {
                lr.SetPosition(1, new Vector3(0, 0, hit.distance));
            }
        }
        else lr.SetPosition(1, new Vector3(0, 0, 5000));*/
    }

    void OnDrawGizmos()
    {
        DrawLine(this.transform.position, this.transform.forward, maxref);
    }

    private void DrawLine(Vector3 pos, Vector3 dir, int remainingref)
    {
        if (remainingref == 0) return;
        Vector3 oldpos = pos;
        Ray ray = new Ray(pos, dir);
        RaycastHit hit;
        if (Physics.Raycast(ray, out hit))
        {
            dir = Vector3.Reflect(dir, hit.normal);
            pos = hit.point;
        }
        else
        {
            pos += dir * maxstep;
        }

        Gizmos.color = Color.yellow;
        Gizmos.DrawLine(oldpos, pos);
        if (hit.collider.gameObject.layer != 8) return;
        DrawLine(pos, dir, remainingref - 1);
    }
}

