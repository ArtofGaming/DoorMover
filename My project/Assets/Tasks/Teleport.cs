using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Teleport : Task
{
    public GameObject player;
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
            player.transform.position = destination.position;
            waiting = true;
            state = State.SUCCESS;
            return state;
        }

        state = State.RUNNING;
        Debug.Log(state);
        return state;


    }
}
