using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LerpExercise : MonoBehaviour
{
    public Transform aPoint;
    public Transform bPoint;
    private bool checkPosition;

    public float modifier;
    private float interpolationSpeed;
    public GameObject sphere;


    private void Start()
    {
        sphere.transform.position = aPoint.position;
    }

    // Update is called once per frame
    void Update()
    {
        if (interpolationSpeed < 1 && checkPosition == true)
        {
            interpolationSpeed = interpolationSpeed + modifier * Time.deltaTime;
        }
        else
        {
            interpolationSpeed = interpolationSpeed - modifier * Time.deltaTime;
        }

        if (sphere.transform.position.x == aPoint.position.x)
        {
            checkPosition = true;
        }
        else if (sphere.transform.position.x == bPoint.position.x)
        {
            checkPosition = false;
        }

        Vector3 a = aPoint.position;
        Vector3 b = bPoint.position;
        sphere.transform.position = Vector3.Lerp(a, b, interpolationSpeed);
     //   sphere.transform.position = Vector3.Slerp(a, b, interpolationSpeed);


    }
}
