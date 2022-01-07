using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Loop : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        string[] strings = new string[3];

        strings[0] = "Hello! ";
        strings[1] = "Hell! ";
        strings[2] = "Hel! ";

        foreach (string elem in strings) {
            print(elem);
        }

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
