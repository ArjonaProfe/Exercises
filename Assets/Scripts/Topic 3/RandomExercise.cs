using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomExercise : MonoBehaviour
{
    public  string[]    names;               // WE'RE GOING TO USE AN ARRAY OF INTEGERS FOR THIS EXERCISE 
    
    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            // Debug.Log(UnityEngine.Random.Range(0, number.Length));  //RANDOM OPERATION

            Debug.Log(names[UnityEngine.Random.Range(0, names.Length)]);
        }
    }
}
