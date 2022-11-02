using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/* code sours from :"Education Public"
 * https://www.youtube.com/watch?v=VWeGC4hcJjk*/

public class CamraMovement : MonoBehaviour
{ 
    // refrence to the "player" ball
    public GameObject ball;
    /*vector to hold the offset whoes value is the difference between the
     * "player " ball and the camaras potistion */
   
    private Vector3 camOffset;
    

    // Start is called before the first frame update
    void Start()
        /* I take camara current transform position 
         * and subtract the ball's transform potistion to find diff  */
    {
        camOffset = transform.position - ball.transform.position;
    }

    /* LateUpdate is also called every frame 
     * but waits until all other items have been prossesed in update.*/ 
    void LateUpdate()
    {
        // I do this so every frame the camara is moved to the "correct" offset alined with my ball 
        transform.position = ball.transform.position + camOffset;
    }
}
