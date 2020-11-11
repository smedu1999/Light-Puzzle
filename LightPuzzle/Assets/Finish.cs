using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Finish : MonoBehaviour
{
    public Line kimenőkesz;
    public Line kimenőfinish;
    public bool kesz1 = false;
    public bool kesz2 = false;
    public bool kesz3 = false;

    // Start is called before the first frame update
    void Start()
    {
        kimenőkesz.maxstep = 0;
        kimenőfinish.maxstep = 0;
    }

    // Update is called once per frame
    void Update()
    {
        if (kesz1)
            kimenőkesz.maxstep = 100;
        if (kesz1 && kesz2 && kesz3)
            kimenőfinish.maxstep = 100;
    }
}
