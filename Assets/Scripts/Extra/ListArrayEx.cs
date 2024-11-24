using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ListArrayEx : MonoBehaviour
{
    public List<object> mixedList; 
    // Start is called before the first frame update
    void Start()
    {
         mixedList = new List<object>();
           mixedList.Add(1);
           mixedList.Add("Hello");
           mixedList.Add(3.14f);
           mixedList.Add(new Vector3(1, 2, 3));
          
       

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
           Debug.Log(mixedList[Random.Range(0,mixedList.Count)]);
        }
    }
}
