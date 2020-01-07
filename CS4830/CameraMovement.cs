using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMovement : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    bool isTouchDown = false;
    Vector3 speed = new Vector3(0.3f, 0.3f, 0.3f);

    void Update() {
        // Set our touch down variable
        if (Input.GetMouseButtonDown(0)) isTouchDown = true;
        if (Input.GetMouseButtonUp(0)) isTouchDown = false;

        if (Input.GetMouseButtonDown(0)) {
            // Calculate the movement using our speed and the forward of our camera
            // The forward is a Unit Vector (magnitude of 1)
            // which points in the direction our camera is looking
            Vector3 moveVec = Vector3.Scale(transform.forward, speed);
            transform.position = transform.position + moveVec;
        }
    }
}
