using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArriveBehavior : MonoBehaviour {

    // Use this for initialization

    Rigidbody rb;
    public float speed;
    public Transform target;
    public Transform thing1;
    public Transform thing2;
	void Start () {

        rb = GetComponent<Rigidbody>();
	}
	
    void ArriveAtPoints(Vector3 targetPos)
    {
    Vector3 targetOffset = target.position - transform.position;
        
        float dist = Vector3.Distance(transform.position, target.position);
        float rampspeed = speed * (targetOffset.magnitude / dist);
        float clippedSpeed = Mathf.Min(rampspeed, speed);
        Vector3 desiredVelocity = (clippedSpeed / targetOffset.magnitude) * targetOffset;
        rb.velocity = desiredVelocity;
    }

	// Update is called once per frame
	void Update ()
    {
        Vector3 midpoint = thing1.position - thing2.position;
        float midpointTime = Vector3.Distance(midpoint, transform.position) / speed;

        Vector3 aPos = thing1.position + thing1.GetComponent<Rigidbody>().velocity * midpointTime;
        Vector3 bPos = thing2.position + thing2.GetComponent<Rigidbody>().velocity * midpointTime;

        Vector3 desiredMidpoint = (aPos + bPos) / 2;

        ArriveAtPoints(desiredMidpoint);


    }
}
