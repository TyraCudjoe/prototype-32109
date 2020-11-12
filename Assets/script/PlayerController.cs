using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float speed = 25.0f;
    public float turnSpeed;
    public float horizontalInput;
    public float forwardInput;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        horizontalInput = Input.GetAxis("Horizontal");
        forwardInput = Input.GetAxis("Vertical");
        
        //move the vehicle forward based on vertical input
       transform.Translate(Vector3.forward * Time.deltaTime * speed * forwardInput);
       //rotates the vehicle based on horizontal input
       transform.Rotate(Vector3.up, Time.deltaTime * turnSpeed * horizontalInput);
    }
}
