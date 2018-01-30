using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PersuitBehavior : MonoBehaviour {

    Rigidbody rb;

    Vector3 dVelocity;
    Vector3 ProjectedPos;

    Rigidbody targetrb;

    public float projdis;
    public float speed;
    public Transform target;

    float dist;
    public float acceptableDistance;

    // Use this for initialization
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        targetrb = target.GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        dist = Vector3.Distance(transform.position, target.position);


        if(dist > acceptableDistance)
        {

        ProjectedPos = target.position +- (targetrb.velocity.normalized * projdis);
        dVelocity = speed * (transform.position - target.position ).normalized;
        rb.AddForce(dVelocity - rb.velocity);

        }

        else
        {

            dVelocity = speed * (target.position - transform.position).normalized;
            rb.AddForce(dVelocity - rb.velocity);

        }
        

        Debug.DrawLine(transform.position, ProjectedPos, Color.green);
        Debug.DrawLine(transform.position, targetrb.position, Color.red);
        Debug.DrawLine(target.position, ProjectedPos, Color.blue);

    }
}
