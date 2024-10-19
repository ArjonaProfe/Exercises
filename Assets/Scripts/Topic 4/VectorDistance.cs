using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class VectorDistance : MonoBehaviour
{
    public Text text;
    public Transform target;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        text.text = Vector3.Distance(this.transform.position, target.position).ToString();
     //   text.text = (this.transform.position - target.position).magnitude.ToString();
    }
}
