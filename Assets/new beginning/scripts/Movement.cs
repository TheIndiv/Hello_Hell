using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    public float movementSpeed;
    public float jumpHeight;
    public float gravity;
    public Vector3 actualVelocity;
    private float maxVelocityChange = 200f;
    private Rigidbody rb;
    
    // Start is called before the first frame update
    void Awake()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        Vector3 targetVelocity = new Vector3(Input.GetAxis("Horizontal"),0,Input.GetAxis("Vertical"));
        targetVelocity = transform.TransformDirection(targetVelocity);
        
        targetVelocity *= movementSpeed;
        
        actualVelocity = rb.velocity;
        
        Vector3 velocityChange = (targetVelocity - actualVelocity);
        velocityChange.x = Mathf.Clamp(velocityChange.x, -maxVelocityChange, maxVelocityChange);
        velocityChange.z = Mathf.Clamp(velocityChange.z, -maxVelocityChange, maxVelocityChange);
        velocityChange.y = 0;
        rb.AddForce(velocityChange,ForceMode.Impulse);
    }
}
