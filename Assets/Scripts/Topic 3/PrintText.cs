using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;           //ADD NEW LIBRARY
public class PrintText : MonoBehaviour
{
    public Text text;
    
    // Update is called once per frame
    void Update()
    {
        text.text = Time.time.ToString("#.##");    
    }
}
