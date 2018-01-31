using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class wALLaVOID : MonoBehaviour {


    Rigidbody rb;
    public float aStr;
    public float aRng;

   
	// Use this for initialization
	void Start ()
    {
        
        rb = GetComponent<Rigidbody>();
	}
    Vector3 wallDir;

    public void doWallAvoid()
    {
        RaycastHit hit;
        
        if (Physics.Raycast(transform.position, transform.forward, out hit, rb.velocity.magnitude))
        {
            rb.AddForce(hit.normal * aStr);
        }
        else
        {
            wallDir = new Vector3(rb.velocity.x, 0, rb.velocity.z);
        }
    }

	// Update is called once per frame
	void Update ()
    {
        doWallAvoid();
	}
}
