using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GoToAcid : Task
{

    public GameObject acid;

    public override void doBehavior(BehaviorManager manager)
    {
        manager.agent.destination = acid.transform.position;
    }
    public override bool checkBehavior(BehaviorManager manager)
    {
        if (manager.health < 25)
        {
            return true;
        }
        return false;
    }
    public override void updateBehavior(BehaviorManager manager)
    {
        if (checkBehavior(manager))
        {
            if(checkBehavior(manager))
            {
                GetHealthPack attempt = manager.thingThatHoldsBehaviors.GetComponent<GetHealthPack>();
                attempt.healthpack = GameObject.Find("healthPack");
               
            }
        }
    }
}