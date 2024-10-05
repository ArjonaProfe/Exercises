using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnableObject : MonoBehaviour
{
    public GameObject gameObject;
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            gameObject.SetActive(false);
        }
        else if (Input.GetMouseButtonUp(0))
        {
            gameObject.SetActive(true);
        }
    }
}
