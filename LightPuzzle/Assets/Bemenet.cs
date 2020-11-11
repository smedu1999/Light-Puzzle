using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bemenet : MonoBehaviour
{
    public Prizma prism;
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
        if (this.tag == "Bemenet1")
            prism.bemenet1 = true;
        if (this.tag == "Bemenet2")
            prism.bemenet2 = true;
    }

    public void Kiment()
    {
        if (this.tag == "Bemenet1")
            prism.bemenet1 = false;
        if (this.tag == "Bemenet2")
            prism.bemenet2 = false;
    }
}
