using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CamFollow : MonoBehaviour {

    public Transform player;
    public Transform cam;
    public Vector3 offset;
    // Update is called once per frame
    void Update()
    {
        cam.transform.position = player.position + offset;
    }
}
