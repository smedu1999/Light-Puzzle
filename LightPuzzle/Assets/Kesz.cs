using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Kesz : MonoBehaviour
{
    public Finish f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Bement()
    {
        if (this.tag == "Kesz1")
            f.done1 = true;
        if (this.tag == "Kesz2")
            f.done2 = true;
        if (this.tag == "Kesz3")
            f.done3 = true;
    }
}
