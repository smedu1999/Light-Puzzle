using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MyCamera : MonoBehaviour
{
    Animator anim;
    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.A))
        {
            anim.SetTrigger("Palya1");
            anim.ResetTrigger("Palya2");
            anim.ResetTrigger("Palya3");
            anim.ResetTrigger("Idle");
        }
        if (Input.GetKeyDown(KeyCode.S))
        {
            anim.SetTrigger("Palya2");
            anim.ResetTrigger("Palya1");
            anim.ResetTrigger("Palya3");
            anim.ResetTrigger("Idle");
        }
        if (Input.GetKeyDown(KeyCode.D))
        {
            anim.SetTrigger("Palya3");
            anim.ResetTrigger("Palya2");
            anim.ResetTrigger("Palya1");
            anim.ResetTrigger("Idle");
        }
    }
}
