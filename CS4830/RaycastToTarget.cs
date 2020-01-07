using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class RaycastToTarget : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }
    private int targetLayer = 1 << 8; // Layer 8 (targets)

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0)) {
            // The Unity raycast hit object, which will store the output of our raycast
            RaycastHit hit;
            // Does the ray intersect any objects excluding the player layer
            // Parameters: position to start the ray, direction to project the ray, output for raycast, limit of ray length, and layer mask
            if (Physics.Raycast(transform.position, transform.forward, out hit, Mathf.Infinity, targetLayer)) {
                // The object we hit will be in the collider property of our hit object.
                // We can get the name of that object by accessing it's Game Object then the name property
                //Debug.Log(hit.collider.gameObject.name);
                Destroy(hit.collider.gameObject);
            }
        }
    }
}
