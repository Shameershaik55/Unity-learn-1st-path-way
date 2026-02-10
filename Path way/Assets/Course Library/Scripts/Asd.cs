using System.Numerics;
using UnityEngine;
using Vector3 = UnityEngine.Vector3;


public class Asd : MonoBehaviour
{
     private float forwardInput;
    private float turnSpeed=45.0f; 
    private float horizontalInput;
    private float speed = 20.0f; 
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
         horizontalInput = Input.GetAxis("Horizontal");
         forwardInput = Input.GetAxis("Vertical");
        transform.Translate(Vector3.forward * Time.deltaTime* forwardInput * speed);
        transform.Rotate(Vector3.up ,Time.deltaTime * turnSpeed*horizontalInput);
       
    }
}
