using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class RecalculatePath : Task
{
    public Door myDoor;

    public void Generate()
    {
        
    }
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
            if (!myDoor.open)
            {
                waiting = true;
                state = State.SUCCESS;
                Debug.Log(state);
                return state;
            }
            else
            {
                waiting = true;
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
