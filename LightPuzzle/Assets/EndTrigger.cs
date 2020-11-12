using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EndTrigger : MonoBehaviour
{
    public UIManager uim;
    void OnTriggerEnter()
    {
        uim.LoadLevel("Congratulations");
    }
}
