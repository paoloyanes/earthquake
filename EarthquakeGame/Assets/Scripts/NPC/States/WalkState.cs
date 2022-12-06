using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WalkState : BaseState
{
    //track which waypoint we are currently targeting
    public int waypointIndex;
    public float waitTimer;

    public override void Enter()
    {
        
    }

    public override void Perform()
    {
        WalkCycle();
    }

    public override void Exit()
    {

    }

    public void WalkCycle()
    {
        //implement our walk logic
        if(npc.Agent.remainingDistance < 0.2f)
        {
            waitTimer += Time.deltaTime;
            if (StateNameController.isEarthquakeSimulationRunning == true)
            {
                
            }
            else
            {
                if (waitTimer > 5)
                {
                    if (waypointIndex < npc.npcPath.waypoints.Count - 1)
                    {
                        waypointIndex++;
                    }
                    else
                    {
                        waypointIndex = 0;
                    }
                    npc.Agent.SetDestination(npc.npcPath.waypoints[waypointIndex].position);
                    waitTimer = 0;
                }
            }
            

            
        }
    }
}
