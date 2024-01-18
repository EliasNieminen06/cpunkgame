using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class interaction : MonoBehaviour
{
    public GameObject door1;
    public Canvas compcanvas;

    private void Update()
    {
        if (Input.GetKey(KeyCode.E))
        {
            Destroy(door1);
        }
    }

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
