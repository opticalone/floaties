using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WalkTowardsBehavior : Task
{

    public GameObject target;
    
    public bool toNumber2 = false;

    public override void doBehavior(BehaviorManager manager)
    {
       
        manager.agent.destination = target.transform.position;
    }
    public override bool checkBehavior(BehaviorManager manager)
    {
        return pathComplete(manager);
    }
    public override void updateBehavior(BehaviorManager manager)
    {
        if (checkBehavior(manager))
        {
            toNumber2 = !toNumber2;
            if(toNumber2)
            {
                target = manager.walkTarget2;
            }
            else
            {
                target = manager.walkTarget;
            }
            
           // manager.behaviors.Pop();
        }
    }


}
