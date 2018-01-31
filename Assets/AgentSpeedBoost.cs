using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
public class AgentSpeedBoost : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	private void OnCollision(Collision colide)
    {
        NavMeshAgent agent = colide.collider.GetComponent<NavMeshAgent>();
        if (agent != null)
        {
            agent.speed += 10;
        }
    }
}
