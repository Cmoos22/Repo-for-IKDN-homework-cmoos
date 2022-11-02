using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/* code  sorce: 
 * https://www.youtube.com/watch?v=pwZpJzpE2lQ&t=2396s */

public class ball : MonoBehaviour
{

    //cleaner way to to stop infinity jumps
    [SerializeField] Transform groundCheck = null;
    [SerializeField] private LayerMask ballMask;

    private bool upArrowKeyWasPressed;
    // we are not gonna check for a key but an axis
    private float horrizontalInput;
    // regidbody component to clean up the code a bit
    private Rigidbody rigidbodycomponent;
   


    // Start is called before the first frame update
    void Start()
    {
        rigidbodycomponent = GetComponent<Rigidbody>();
    }

    // I want to make the ball move s
    void Update()
    {
        //chek if the  arrow key is down  
        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            upArrowKeyWasPressed = true;
        }
        horrizontalInput = Input.GetAxis("Horizontal");
    }
    // fixedupdate updates onece every pysics update about 100 pr sek.
    private void FixedUpdate()
    {
        // we put this line here to have air control side to side 
        rigidbodycomponent.velocity = new Vector3(horrizontalInput, rigidbodycomponent.velocity.y, 0);

        if (Physics.OverlapSphere(groundCheck.position,0.1f,ballMask).Length == 0)

        {
            return;
        }
    
        if (upArrowKeyWasPressed)
        {
            rigidbodycomponent.AddForce(Vector3.up * 6, ForceMode.VelocityChange);
            upArrowKeyWasPressed = false;
        }
    }

   
}

