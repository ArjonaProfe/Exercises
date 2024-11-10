using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RbDynamics : MonoBehaviour
{
    public bool switchRb;
    public float speedMovement;
    private Rigidbody rb;


    public float jump;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        Movement();
        Jump();
    }

    void Movement()
    {
        float xAxis = Input.GetAxisRaw("Horizontal");
        if (switchRb == false)
        {
            this.transform.Translate(xAxis * Vector3.right * speedMovement * Time.deltaTime, Space.World);
        }
        else
        {
            Vector3 nextPos = this.transform.position + this.transform.forward * speedMovement * Time.deltaTime;
            rb.MovePosition(nextPos);
            //   rb.velocity = Vector3.right * speedMovement * Time.deltaTime;
        }
    }
    void Jump()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            rb.AddForce(this.transform.up * jump);
        }
    }
}