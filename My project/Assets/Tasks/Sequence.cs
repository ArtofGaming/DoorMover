using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sequence : Task
{
    public Task[] children;
    public override State Run()
    {
        bool runningChildren = false;

        foreach(Task child in children)
        {
            if (child.Run() == State.FAILURE)
            {
                state = State.FAILURE;
                Debug.Log(state);
                return state;
            }
            else if(child.Run() == State.RUNNING)
            {
                runningChildren = true;
                state = State.RUNNING;
                continue;
            }
            else
            {
                state = State.SUCCESS;
                continue;
            }
        }
        if (runningChildren)
        {
            state = State.RUNNING;
            Debug.Log(state);
        }
        else
        {
            state = State.SUCCESS;
            Debug.Log(state);
        }
        return state;
    }
}
