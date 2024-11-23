using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerCollision : MonoBehaviour
{
    private void OnCollisionEnter(Collision collision)
    {
        Debug.Log("Collision");
    }
    private void OnCollisionExit(Collision collision)
    {
        Debug.Log("Stop collision");
    }



    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("Trigger");
    }
    private void OnTriggerExit(Collider other)
    {
        Debug.Log("Stop Trigger");
    }
}
