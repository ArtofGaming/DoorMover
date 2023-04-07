using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Selector : Task
{
    public Task[] children;
    
    public override State Run()
    {
        foreach (Task child in children)
        {
            if (child.Run() == State.FAILURE)
            {
                state = State.FAILURE;
                continue;
            }
            else if(child.Run() == State.SUCCESS)
            {
                state = State.SUCCESS;
                Debug.Log(state);
                return state;
            }
            else
            {
                state = State.RUNNING;
                Debug.Log(state);
                return state;
            }

        }
        state = State.FAILURE;
        Debug.Log(state);
        return state;
    }
}
