using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerLook : MonoBehaviour
{
    // Player Transform
    public Transform player;
    // Mouse Sensitivity
    public float sensitivity = 100f;
    // X Rotation
    float rotateX = 0f;

    // Start is called before the first frame update
    void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
    }

    // Update is called once per frame
    void Update()
    {
        // Get mouse axis
        float lookX = Input.GetAxis("Mouse X") * sensitivity * Time.deltaTime;
        float lookY = Input.GetAxis("Mouse Y") * sensitivity * Time.deltaTime;

        // Rotate Camera verically in 180 degrees
        rotateX -= lookY;
        rotateX = Mathf.Clamp(rotateX, -90, 90);

        // Rotate Player horizontally
        transform.localRotation = Quaternion.Euler(rotateX, 0f, 0f);
        player.Rotate(Vector3.up * lookX);
    }
}
