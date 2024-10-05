using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TransformExercise : MonoBehaviour
{

    private float xAxis;
    public float  speed;

    // Update is called once per frame
    void Update()
    {
        xAxis = Input.GetAxis("Horizontal");

     //   this.transform.position = this.transform.position + xAxis * Vector3.right * speed * Time.deltaTime;      // 1st way to do it
     this.transform.Translate(xAxis * Vector3.right * speed * Time.deltaTime, Space.World);                        // 2nd way to do it
    
    }
}
