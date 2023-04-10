using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PushBlock : Task
{
    public Rigidbody player;
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
            player.AddForce(1, 0, 0);
            state = State.SUCCESS; 
            return state;

        }
        state = State.RUNNING;
        Debug.Log(state);
        return state;

    }
}
