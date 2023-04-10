using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.AI;

public class ObstacleInPath : Task
{
    public NavMeshAgent player;
    public Transform destination;
    public override State Run()
    {
        if (waiting)
        {
            waitTime += Time.deltaTime;
            if (waitTime >= waitLimit)
            {
                waiting = false;
            }
        }
        else
        {
            player.SetDestination(destination.transform.position);
            waiting = true;
            if (!player.hasPath)
            {

                state = State.SUCCESS;
                Debug.Log(state);
                return state;
            }
            if (player.pathPending)
            {
                state = State.RUNNING;
            }
            else
            {
                waiting = true;
                player.SetDestination(player.transform.position);
                state = State.FAILURE;
                Debug.Log(state);
                return state;
            }
        }

        state = State.RUNNING;
        Debug.Log(state);
        return state;


    }
}
