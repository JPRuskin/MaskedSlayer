using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public Rigidbody rb;
    public int movementSpeed = 5;

    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Player1 is being initialised at "+ transform.position.x + "," + transform.position.y + "," + transform.position.z);
    }

    // Fixed update is apparently far better for physics operations
    void FixedUpdate()
    {
        if (Input.GetKey("1")) {
            rb.useGravity = !rb.useGravity;
        }
        // * Time.deltaTime muliplies by the time since last frame, so averages depending on framerate
        
        if (Input.GetKey("w")) {
            rb.AddForce(movementSpeed * Time.deltaTime, 0, 0);
        }

        if (Input.GetKey("a")) {
            rb.AddForce(0, 0, movementSpeed * Time.deltaTime);
        }

        if (Input.GetKey("d")) {
            rb.AddForce(0, 0, - movementSpeed * Time.deltaTime);
        }

        if (Input.GetKey("s")) {
            rb.AddForce(- movementSpeed * Time.deltaTime, 0, 0);
        }

        if (Input.GetKey(KeyCode.Space)) {
            rb.AddForce(0, 2500 * Time.deltaTime, 0);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
