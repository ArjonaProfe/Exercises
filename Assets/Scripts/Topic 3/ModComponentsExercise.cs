using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class ModComponentsExercise : MonoBehaviour
{
    public  Color32     color;           // TO ASSIGN THE COLOR WE WANT TO CHANGE
    private Color32     colorBackup;     // HERE WE'RE GOING TO SAVE THE ORIGINAL COLOR

    public GameObject   cube;            // WE'RE GOING TO MODIFY ITS COMPONENTS


    private void Start()
    {
        colorBackup = cube.GetComponent<MeshRenderer>().material.color;     // WE'RE SAVING THE ORIGINAL COLOR IN THE BACKUP
    }
    private void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            cube.GetComponent<MeshRenderer>().material.color = color;       // CHANGE THE COMPONENT MATERIAL TO THE COLOR VALUE
        }
        else if (Input.GetMouseButtonUp(0))
        {
            cube.GetComponent<MeshRenderer>().material.color = colorBackup; // WE RESTORE THE BACKUP
        }
    }
}
