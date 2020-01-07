using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMovement : MonoBehaviour
{
    public GameObject parent;

    private int targetLayer = 1 << 8; // Layer 8 (targets)
    
    // Start is called before the first frame update
    void Start()
    {
        
    }
    // Update is called once per frame
    void Update()
    {
        // When we have a horizontal value
        if (Input.GetAxis("Horizontal") != 0) {
            // Move the attached parent based on the right vector of this object multiplied by the horizontal axis value
            parent.transform.position += (transform.right) * Input.GetAxis("Horizontal");
        }
        // When we have a vertical value
        if (Input.GetAxis("Vertical") != 0) {
            // Move the attached parent based on the right vector of this object multiplied by the horizontal axis value
            parent.transform.position += (transform.forward) * Input.GetAxis("Vertical");
        }
        if (Input.GetButtonDown("Fire1")) {
            // The Unity raycast hit object, which will store the output of our raycast
            RaycastHit hit;
            // Does the ray intersect any objects excluding the player layer
            // Parameters: position to start the ray, direction to project the ray, output for raycast, limit of ray length, and layer mask
            if (Physics.Raycast(transform.position, transform.forward, out hit, Mathf.Infinity, targetLayer)) {
                // The object we hit will be in the collider property of our hit object.
                // We can get the name of that object by accessing it's Game Object then the name property
                parent.transform.position = new Vector3(hit.point.x, 0, hit.point.z);
            }
        }
    }
}
