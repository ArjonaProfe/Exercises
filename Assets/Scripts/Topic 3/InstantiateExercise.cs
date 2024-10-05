using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEditor.Experimental.GraphView;
using UnityEngine;

public class InstantiateExercise : MonoBehaviour
{
    public GameObject playerPrefab;
    private GameObject clone;
    public Transform spawnPoint;
    // Update is called once per frame
    void Update()
    {
        PrefabExample();
        CopyExample();
        HierarchyExample();

    }
    void PrefabExample()
    {
        if (Input.GetMouseButtonDown(0))
        {
           // Instantiate(playerPrefab, spawnPoint.position, Quaternion.identity);
           clone = Instantiate(playerPrefab, spawnPoint.position,Quaternion.identity);
        }
        else if (Input.GetMouseButtonUp(0))
        {
           // Destroy(playerPrefab.gameObject);
           Destroy(clone);

        }
    }
    void CopyExample()
    {
        if (Input.GetMouseButtonDown(1))
        {
            var copy = Instantiate(playerPrefab, spawnPoint.position, Quaternion.identity);
            Destroy(copy, 2f);
        }
    }

    void HierarchyExample()
    {
        if (Input.GetMouseButtonDown(2))
        {
            Destroy(GameObject.FindGameObjectWithTag("Player"));
        }
    }
}
