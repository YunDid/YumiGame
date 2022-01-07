

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enabled : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        render = GetComponent<MeshRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyUp(KeyCode.Space)) {
            render.enabled = !render.enabled;
        }
    }

    public MeshRenderer render;
}
