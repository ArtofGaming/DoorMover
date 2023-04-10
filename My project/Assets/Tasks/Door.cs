using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Door : MonoBehaviour
{
    public bool open;
    public bool locked;
    public Door controlled;

    public void ToggleDoorLock()
    {
        controlled.open = false;
        controlled.locked = true;
    }
    public void ToggleDoorState()
    {
        controlled.open = !controlled.open;
    }
}
