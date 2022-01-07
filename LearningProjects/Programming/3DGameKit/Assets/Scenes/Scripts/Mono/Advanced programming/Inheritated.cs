using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fasther {

    public int para = 10;

    public virtual void SayHello() {
        Debug.Log("Hello! Father!");
    }
}

public class Childern : Fasther
{
    new public void SayHello()
    {
        Debug.Log("Hello! Children!");
    }
}

public class Inheritated : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Fasther father = new Childern();
        father.SayHello();

        Childern children = new Childern();
        children.SayHello();
    }

    // Update is called once per frame
    void Update()
    {

    }
}