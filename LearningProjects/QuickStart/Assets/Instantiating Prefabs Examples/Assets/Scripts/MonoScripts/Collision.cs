using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collision : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter()
    {
        //进入触发器执行的代码
        Debug.Log("Trigger检测到碰撞!");
    }

    void OnCollisionEnter()
    {
        //进入碰撞器执行的代码
        Debug.Log("Collision检测到碰撞!");
    }

}
