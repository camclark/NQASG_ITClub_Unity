using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveBall : MonoBehaviour {
    public Rigidbody rb;

    public float force = 5f;

    // Update is called once per frame
    void FixedUpdate()
    {

        //rb.AddForce(0, 0, forwardforce * Time.deltaTime);
        /*
        if (Input.GetKey("d"))
        {
            rb.AddForce(force * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }
        if (Input.GetKey("a"))
        {
            rb.AddForce(-(force * Time.deltaTime), 0, 0, ForceMode.VelocityChange);
        }
        if (Input.GetKey("w"))
        {
            rb.AddForce(0, 0, force * Time.deltaTime, ForceMode.VelocityChange);
        }
        if (Input.GetKey("s"))
        {
            rb.AddForce(0, 0, -(force * Time.deltaTime), ForceMode.VelocityChange);
        }
        */
        if (SystemInfo.deviceType == DeviceType.Desktop)
        {
            // Player movement in desktop devices
            // Definition of force vector X and Y components
            float moveHorizontal = Input.GetAxis("Horizontal");
            float moveVertical = Input.GetAxis("Vertical");
            // Building of force vector
            Vector3 movement = new Vector3(moveHorizontal, 0.0f, moveVertical);
            // Adding force to rigidbody
            rb.AddForce(movement * force * Time.deltaTime, ForceMode.VelocityChange);
        }
        else
        {
            // Player movement in mobile devices
            // Building of force vector 
            Vector3 movement = new Vector3(Input.acceleration.x, 0.0f, Input.acceleration.y);
            // Adding force to rigidbody
            rb.AddForce(movement * force * Time.deltaTime, ForceMode.VelocityChange);
        }

    }
   


}
