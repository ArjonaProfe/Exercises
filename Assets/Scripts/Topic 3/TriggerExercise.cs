using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerExercise : MonoBehaviour
{

    public void OnTriggerEnter(Collider other)
    {
        Debug.Log("Cube has entered in the trigger!");
    }
}
