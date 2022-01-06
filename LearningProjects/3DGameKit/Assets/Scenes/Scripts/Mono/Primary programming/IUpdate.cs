
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IUpdate : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    void FixedUpdate()
    {
        print("FixedUpdate deltaTime : " + Time.deltaTime);
    }

    // Update is called once per frame
    void Update()
    {
        print("Update deltaTime : " + Time.deltaTime);
    }
}
