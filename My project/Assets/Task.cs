using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum State
{
    RUNNING,
    SUCCESS,
    FAILURE
}
public class Task : MonoBehaviour
{
    protected float waitLimit = 4f;
    protected float waitTime = 0f;
    protected bool waiting = false;
    public State state = State.FAILURE;
    public virtual State Run()
    {
        Debug.Log(state);
        return State.FAILURE;
    }
}
