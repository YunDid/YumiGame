
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DDestory : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //销毁本游戏对象
        if (Input.GetKeyDown(KeyCode.Space)) {
            Destroy(gameObject, 1f);
        }

        //销毁其他游戏对象
        if (Input.GetKeyDown(KeyCode.L))
        {
            Destroy(other, 1f);
        }

        //销毁组件
        if (Input.GetKeyDown(KeyCode.M))
        {
            Destroy(GetComponent<Renderer>(), 1f);
        }
    }

    public GameObject other;
}
