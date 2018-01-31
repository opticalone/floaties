using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public enum archerState
{
    walkTo,
    walkAway,
    isInrange
}
public class ArcherState : MonoBehaviour {


    NavMeshAgent Agent;

    public float shoottimer = 1;
    public GameObject arrow;
    public ArcherState state;
    public Transform target;

    void updateState()
    {
        float dist = Vector3.Distance(transform.position, target.position);
        if(dist > Agent.stoppingDistance && dist < Agent.stoppingDistance +5)
        {
            state = archerState.isInrange;

        }
        else if (dist < Agent.stoppingDistance +5)
        {
            state = archerState.walkAway;

        }
    }


    // Use this for initialization
    void Start () {
        Agent = GetComponent<NavMeshAgent>();
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
