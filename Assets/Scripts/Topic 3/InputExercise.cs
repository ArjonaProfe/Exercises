using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InputExercise : MonoBehaviour
{
    private float xAxis;
    public Text text;
    

    // Update is called once per frame
    void Update()
    {
        xAxis = Input.GetAxis("Horizontal");
        //  Debug.Log(xAxis);                     // Show the debug console and let them implement the improved version with text
        text.text = xAxis.ToString();
        
    }
}
