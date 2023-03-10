using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    // Start is called before the first frame update

    public Rigidbody rb;

    void Start()
    {
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if(Input.GetKey("w")){
            rb.AddForce(0, 0, 8000*Time.deltaTime);
        }
        if(Input.GetKey("s")){
            rb.AddForce(0, 0, -8000*Time.deltaTime);
        }
        if(Input.GetKey("d")){
            rb.AddForce(4000*Time.deltaTime, 0, 0);
        }
        if(Input.GetKey("a")){
            rb.AddForce(-4000*Time.deltaTime, 0, 0);
        }

        if(rb.position.y < -1f){
            FindObjectOfType<GameController>().GameOver();
        }
    }
}
