using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectsMovement : MonoBehaviour
{
    public float speedMovement;

    public Transform aPoint;
    public Transform bPoint;
    public bool switchNormalized;

    private bool checkPosition = true;
    private float interpolationSpeed;
    // Start is called before the first frame update
    void Start()
    {
        this.transform.position = aPoint.position;
    }

    // Update is called once per frame
    void Update()
    {
        SpeedCalculation();
        Movement();

    }
    public void SpeedCalculation()
    {
        if (interpolationSpeed < 1 && checkPosition == true)
        {
            interpolationSpeed = interpolationSpeed + speedMovement * Time.deltaTime;
        }
        else
        {
            interpolationSpeed = interpolationSpeed - speedMovement * Time.deltaTime;
        }
    }
    public void Movement()
    {
        if (this.transform.position.x == aPoint.position.x)
        {
            checkPosition = true;
        }
        else if (this.transform.position.x == bPoint.position.x)
        {
            checkPosition = false;
        }
        Vector3 a = aPoint.position;
        Vector3 b = bPoint.position;
        this.transform.position = Vector3.Lerp(a, b, interpolationSpeed);
    }
}

