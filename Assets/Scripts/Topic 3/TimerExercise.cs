using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TimerExercise : MonoBehaviour
{
    private float time = 0f;                // TO SET THE START POINT

    void Update()
    {
        if (Input.GetMouseButton(0))
        {
            DeltaTimer();
        }

        else if (Input.GetMouseButtonUp(0))
        {
            time = 0f;
        }

        else if (Input.GetMouseButtonDown(1))
        {
            TimeTimer();
        }

    }

    void DeltaTimer()
    {
        time = time + Time.deltaTime;       // HERE IT STARTS TO ADD UP
        Debug.Log(time);
    }

    void TimeTimer()
    {
        Debug.Log(Time.time);
    }
}
