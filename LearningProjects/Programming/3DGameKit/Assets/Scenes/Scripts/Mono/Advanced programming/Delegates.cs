using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Delegates : MonoBehaviour
{
    public delegate void Func(int param);

    // Start is called before the first frame update
    void Start()
    {
        Func func1 = new Func(printLog);
        func1(1);
        func1 += printLoggg;
        func1(1);
    }

    public void printLog(int param) {
        Debug.Log("printLog() 被调用!");
    }

    public void printLoggg(int param)
    {
        Debug.Log("printLoggg() 被调用!");
    }
}
