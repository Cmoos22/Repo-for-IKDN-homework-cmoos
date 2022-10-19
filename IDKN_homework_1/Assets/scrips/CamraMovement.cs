using System.Collections;
using System.Collections.Generic;
using UnityEngine;
// code sours from :"Education Public" https://www.youtube.com/watch?v=VWeGC4hcJjk

public class CamraMovement : MonoBehaviour
{ 
    // refrence to the "player" ball
    public GameObject ball;
    //vector to hold the offset
    private Vector3 camOffset;
    

    // Start is called before the first frame update
    void Start()
    {
        camOffset = transform.position - ball.transform.position;
    }

    /* LateUpdate is also called every frame 
     * but waits until all other items have been prossesed in update.*/ 
    void LateUpdate()
    {
        transform.position = ball.transform.position + camOffset;
    }
}
