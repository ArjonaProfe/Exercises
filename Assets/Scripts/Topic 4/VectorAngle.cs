using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VectorAngle : MonoBehaviour
{
    public Transform target;
    public float angle;

    // Update is called once per frame
    void Update()
    {
    if (Vector3.Angle(this.transform.forward, target.position - this.transform.position) < angle / 2)
        {
            Debug.Log("Enemy detected"); // In the Z-Axis
        }
    }
}
