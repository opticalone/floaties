using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GetHealthPack : Task {

    public GameObject healthpack;


    public override void doBehavior(BehaviorManager manager)
    {
        manager.agent.destination = healthpack.transform.position;
    }
    public override bool checkBehavior(BehaviorManager manager)
    {
       if(pathComplete(manager))
        {
            manager.health += 50;
            return true;
        }
        return false;
    }
    public override void updateBehavior(BehaviorManager manager)
    {
        if(checkBehavior(manager))
        {
            manager.tasks.Pop();
        }
    }
}
