using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    // CharacterController
    public CharacterController cC;
    // GroundCheck
    public Transform gC;
    // Speed
    public float speed;
    // Gravity
    public float gravity;
    // JumpForce
    public float jumpForce;
    // GroundLayer
    public LayerMask groundLayer;
    // GroundDistance
    public float groundDist;
    // Velocity
    Vector3 velocity;

    // Update is called once per frame
    void Update()
    {
        // Get input axis
        float xAxis = Input.GetAxis("Horizontal");
        float zAxis = Input.GetAxis("Vertical");

        // 
        Vector3 movement = transform.right * xAxis + transform.forward * zAxis;
        cC.Move(movement * speed * Time.deltaTime);
    }
}
