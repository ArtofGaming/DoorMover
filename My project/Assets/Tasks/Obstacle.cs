using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Obstacle : MonoBehaviour
{
    public GameObject controlled;
    public bool visible = true;

    public void ToggleDoorState()
    {
        controlled.SetActive(!visible);
        visible = !visible;
    }
}
