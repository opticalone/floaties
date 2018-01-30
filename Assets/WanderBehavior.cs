using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WanderBehavior : MonoBehaviour {

    public float speed;
    public float rad;
    public float jitter;
    public float dist; //projected unit circle center
    public Vector3 target;



    Rigidbody rb;

	// Use this for initialization
	void Start ()
    {
        rb = GetComponent<Rigidbody>();
	}
	
	// Update is called once per frame
	void Update ()
    {
        target = Vector3.zero;
        target = Random.insideUnitCircle.normalized * rad;
        target = (Vector2)target + Random.insideUnitCircle * jitter; //vec 2 because no fly

        target.z = target.y;
        target += transform.position;
        target += transform.forward * dist;

        
        target.y = 0;

        Vector3 dir = (target - transform.position).normalized;
        Vector3 DesVel = dir * speed;
        rb.AddForce(DesVel - rb.velocity);
        transform.forward = new Vector3(rb.velocity.x, 0, rb.velocity.z);

      //  Debug.DrawLine(transform.position, transform.position + (transform.forward * dist),Color.red);
      //  Debug.DrawLine(transform.position + (transform.forward * dist),target, Color.blue);
        //transform.LookAt(rb.velocity);
        // transform.forward = new Vector3(rb.velocity.x, 0, rb.velocity.z);


    }
}
