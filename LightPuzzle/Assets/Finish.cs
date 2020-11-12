using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Finish : MonoBehaviour
{
    public Line output;
    public Line outputFinish;
    public bool done1 = false;
    public bool done2 = false;
    public bool done3 = false;

    // Start is called before the first frame update
    void Start()
    {
        output.maxstep = 0;
        outputFinish.maxstep = 0;
    }

    // Update is called once per frame
    void Update()
    {
        if (done1)
            output.maxstep = 100;
        if (done1 && done2 && done3)
            outputFinish.maxstep = 100;
    }
}
