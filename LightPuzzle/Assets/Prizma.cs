using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Prizma : MonoBehaviour
{
    public Line kimenő;
    public bool bemenet1 = false;
    public bool bemenet2 = false;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (bemenet1 && bemenet2)
            kimenő.maxstep = 200;
        else
            kimenő.maxstep = 0;
    }
}
