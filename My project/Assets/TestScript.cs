using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestScript : MonoBehaviour
{
    public Task taskToRun;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Return))
        {
            TestRun(taskToRun);
        }
    }
    
    void TestRun(Task task)
    {
        task.Run();
    }
}
