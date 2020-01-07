using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallShooter : MonoBehaviour
{
    public BallPrefab ball;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetMouseButtonDown(0)) {
  BallPrefab newBall = Instantiate(ball);
  newBall.transform.position = transform.position;
  newBall.GetComponent<Rigidbody>().AddForce(
    Camera.main.transform.forward * Random.Range(500, 750)
  );
}
        
    }
}
