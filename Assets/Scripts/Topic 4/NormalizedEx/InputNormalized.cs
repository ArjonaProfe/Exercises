using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputNormalized : MonoBehaviour
{
  
    private Vector3 movement;
    public float speedMovement;
    public bool normalizedSwitch;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        PlayerInput();
        NormalizedSwitch();
    }
    public void PlayerInput()
    {
        movement = Vector3.zero;
        if (Input.GetKey(KeyCode.D))
        {
            movement.x = 1;
        }
        else if (Input.GetKey(KeyCode.A))
        {
            movement.x = -1;
        }
        if (Input.GetKey(KeyCode.W))
        {
            movement.y = 1;
        }
        else if (Input.GetKey(KeyCode.S))
        {
            movement.y = -1;
        }
    }

    public void NormalizedSwitch()
    {
        if (normalizedSwitch == true)
        {
            transform.position = transform.position + speedMovement * movement.normalized * Time.deltaTime;
        }
        else
        {
            transform.position = transform.position + speedMovement * movement * Time.deltaTime;
        }
    }
}
