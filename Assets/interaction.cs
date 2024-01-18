using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class interaction : MonoBehaviour
{
    public Canvas compcanvas;
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            if (this.gameObject.name == "pc")
            {
                compcanvas.enabled = true;
            }
        }
    }
    private void OnTriggerExit(Collider other)
    {
        if (other.tag == "Player")
        {
            if (this.gameObject.name == "pc")
            {
                compcanvas.enabled = false;
            }
        }
    }
}
