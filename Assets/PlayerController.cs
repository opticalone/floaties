using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {

    // Use this for initialization
    static Animator anim;
    public float speed = 5.0f;
    public float rotationSpeed = 75.0f;

    Rigidbody rb;
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        anim = GetComponent<Animator>();
    }
	// Update is called once per frame
	void Update () {
        float translation = Input.GetAxis("Horizontal") * speed;
        float rotato = Input.GetAxis("Vertical") * rotationSpeed;

        
        //transform.Rotate(0, x, 0);
       // transform.Translate(0, 0, z);

        anim.SetBool("isMove", true);
    }
}
