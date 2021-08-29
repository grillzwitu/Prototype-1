using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{

    private float speed = 15.0f; //adjust vehicle speed
    private float turnSpeed = 25.0f; //turn right or left
    private float horizontalInput;  //control turning left or right using player input
    private float forwardInput;//control vehicle speed uisng player input

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        horizontalInput = Input.GetAxis("Horizontal");
        forwardInput = Input.GetAxis("Vertical");

        //Move the vehicle forward

        //transform.Translate(0, 0, 1);
        //transform.Translate(Vector3.forward);

        //Adjust the speed
        transform.Translate(Vector3.forward * Time.deltaTime * speed * forwardInput);

        //Make the vehicle turn right or left
        //transform.Translate(Vector3.right * Time.deltaTime * turnSpeed * horizontalInput);
        transform.Rotate(Vector3.up, horizontalInput * turnSpeed * Time.deltaTime);
    }
}
