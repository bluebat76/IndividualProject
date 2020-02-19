using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    
    
    public float speed;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        
        float Vinput = Input.GetAxis("Vertical");
        float Hinput = Input.GetAxis("Horizontal");

        Vector3 Movement = new Vector3(Hinput, 0.0f, Vinput);

        Rigidbody rb = GetComponent<Rigidbody>();
        rb.AddForce(Movement * speed);
    }
}
