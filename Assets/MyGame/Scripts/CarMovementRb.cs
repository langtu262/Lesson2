using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarMovementRb : MonoBehaviour
{
    // Start is called before the first frame update
    private Rigidbody rb;
    public float speedPosition = 10;
    public float speedRotation = 50;
    
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void FixedUpdate()
    {
        //Debug.Log("velocityrb" + rb.velocity);
        //Debug.Log("postion" + rb.position);

        float v = Input.GetAxis("Vertical");
        float h = Input.GetAxis("Horizontal");
        /*
        Vector3 velocity = rb.velocity;
        velocity.z = v * speedPosition;
        rb.velocity = velocity;*/
        rb.MovePosition(rb.position + new Vector3(0, 0, v*Time.deltaTime*speedPosition));
        rb.MoveRotation(rb.rotation * Quaternion.Euler(new Vector3(0, h*Time.deltaTime*speedRotation, 0)));
    }
}
