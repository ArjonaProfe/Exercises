using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rays : MonoBehaviour
{
    public float distance;


    public float radius;
    public float strength;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            RayHitFunction();
        }
        else if (Input.GetMouseButtonDown(1))
        {
            OverlapFunction();
        }
    }

    public void RayHitFunction()
    {
        RaycastHit impactInfo;

        if (Physics.Raycast(this.transform.position, Vector3.right, out impactInfo))
        {

            Debug.DrawRay(this.transform.position, Vector3.right * distance, Color.red, 2f);
            Debug.Log("Collider info: " + impactInfo.collider);

            Rigidbody rbHit = impactInfo.rigidbody;
            rbHit.GetComponent<EnemyLife>().Damage(10);
        }
    }
    public void OverlapFunction()
    {

        Collider[] collidersWithinRadius = Physics.OverlapSphere(this.transform.position, radius);


        foreach (Collider col in collidersWithinRadius)
        {
            Rigidbody rb = col.GetComponent<Rigidbody>();
            if (rb != null)
            {
                rb.AddExplosionForce(strength, transform.position, radius);
            }
        }
    }


    private void OnDrawGizmos()
    {
        Gizmos.color = Color.green;
        Gizmos.DrawSphere(transform.position, radius);
    }
}
