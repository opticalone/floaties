using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;



public class BehaviorManager : MonoBehaviour, IDamagable {

    [HideInInspector]
    public Stack<Task> tasks;
    [HideInInspector]
    public NavMeshAgent agent;

    public GameObject thingThatHoldsBehaviors;

    public GameObject walkTarget;
    public GameObject walkTarget2;

    public float health;
    public GameObject acid;
    public void takeDamage(float damage)
    {
        health -= damage;
    }

	// Use this for initialization
	void Start ()
    {
       // WalkToBehavior = GetComponent<WalkTowardsBehavior>();
        agent = GetComponent<NavMeshAgent>();
        tasks = new Stack<Task>();
        WalkTowardsBehavior newwalkto = new WalkTowardsBehavior();
        WalkTowardsBehavior attemptpudh = thingThatHoldsBehaviors.GetComponent<WalkTowardsBehavior>();
        newwalkto.target = walkTarget;

        tasks.Push(newwalkto);
	}
	
	// Update is called once per frame
	void Update ()
    {
	if (tasks.Count > 0)
        {
           
            tasks.Peek().doBehavior(this);
            tasks.Peek().updateBehavior(this);
        }	
	}
}
