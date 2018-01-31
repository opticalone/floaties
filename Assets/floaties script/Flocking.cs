using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Flocking : MonoBehaviour
{
    Vector3 Cforce;
    Vector3 Aforce;
    Vector3 Sforce;
    Rigidbody rb;
    public float speed;
    public float radius;


    // Use this for initialization
    void Start ()
    {
        rb = GetComponent<Rigidbody>();
        rb.AddForce(Random.insideUnitSphere * 6);
	}
	
	// Update is called once per frame
	void Update ()
    {
        Vector3 ctarget = Vector3.zero;
        Vector3 aDesire = Vector3.zero;
        Vector3 sSum = Vector3.zero;
        int hoodSize = 0;
        Collider[] hood = Physics.OverlapSphere(transform.position, radius);

        foreach (Collider guyInhood in hood) 
        {
            var Flocker = guyInhood.GetComponent<Flocking>();
            if (/*Flocker != null*/ guyInhood.tag == "AI")
            {

                hoodSize++;
                Rigidbody guyRb = guyInhood.GetComponent<Rigidbody>();

                ctarget += Flocker.transform.position;
                aDesire += guyRb.velocity;
                sSum += (transform.position - guyInhood.transform.position) / radius;


            }
        }

        ctarget /= hoodSize;
        aDesire /= hoodSize;
        sSum /= hoodSize;

        Cforce = (ctarget - transform.position).normalized * speed - rb.velocity;
        Aforce = aDesire.normalized * speed - rb.velocity;
        Sforce = sSum.normalized * speed - rb.velocity;

        rb.AddForce((Cforce + Aforce + Sforce).normalized * speed);

    }
}
