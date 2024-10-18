using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using UnityEngine.Rendering;

public class MoveTowards : MonoBehaviour
{
    public Transform[] waypoints;

    public int index = 0;
    private Transform target;
    public float speed;
    // Start is called before the first frame update
    void Start()
    {
        target = waypoints[index];
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log(index);
        if (Vector3.Distance(transform.position, target.position) > 0.1f)
        {
            this.transform.position = Vector3.MoveTowards(this.transform.position, target.position, speed * Time.deltaTime);
        }
        else if (index < waypoints.Length - 1)
        {
            index = index + 1;
            target = waypoints[index];
        }
      else
        {
            index = 0;
            target = waypoints[index];
        }
        
    }
}

