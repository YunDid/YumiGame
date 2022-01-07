using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Extend : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Transform trans = GetComponent<Transform>();
        trans.Logout();

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

public static class Container {
    public static void Logout(this Transform trans) {
        Debug.Log("Tranform 类中被\"添加\"了这个方法啦！");
    } 
}
