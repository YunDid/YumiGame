using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Axis : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float axis = Input.GetAxis("Horizontal");
        transform.position = new Vector3(axis, transform.position.y, transform.position.z);
    }
}
