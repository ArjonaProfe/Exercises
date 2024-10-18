using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LerpExercise : MonoBehaviour
{
    public Transform aPoint;
    public Transform bPoint;
    private bool checkPosition;

    public float speed;
    private float interpolationSpeed;
    public GameObject sphere;
    public bool lerpSwitch;


    private void Start()
    {
        sphere.transform.position = aPoint.position;
    }

    // Update is called once per frame
    void Update()
    {
        SpeedCalculation();
        Movement();
        LerpSwitch();
    }
    public void SpeedCalculation()
    {
        if (interpolationSpeed < 1 && checkPosition == true)
        {
            interpolationSpeed = interpolationSpeed + speed * Time.deltaTime;
        }
        else
        {
            interpolationSpeed = interpolationSpeed - speed * Time.deltaTime;
        }
    }

    public void Movement()
    {
        if (sphere.transform.position.x == aPoint.position.x)
        {
            checkPosition = true;
        }
        else if (sphere.transform.position.x == bPoint.position.x)
        {
            checkPosition = false;
        }
    }
    public void LerpSwitch()
    {
        Vector3 a = aPoint.position;
        Vector3 b = bPoint.position;

        if (lerpSwitch == false)
        {
            sphere.transform.position = Vector3.Lerp(a, b, interpolationSpeed);

        }
        else
        {
            sphere.transform.position = Vector3.Slerp(a, b, interpolationSpeed);
        }
    }
}
