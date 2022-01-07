using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EventsPublisher : MonoBehaviour
{

    //委托
    public delegate void EventDispose();

    //事件
    public static EventDispose eventDispose;

    //事件通知函数
    public void Notify() {
        if (eventDispose != null) {
            //调用已订阅的类的相应事件处理函数
            eventDispose();
        }
    }

    public void setValue(float value) {
        elem = value;
        Notify();
    }

    // Start is called before the first frame update 
    void Start()
    {
        EventSubscriber SubObj = new EventSubscriber();
        SubObj.Subscribe();

        EventsPublisher PubObj = new EventsPublisher();
        PubObj.setValue(100f);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public float elem;
}

public class EventSubscriber {

    //订阅事件
    public void Subscribe() {
        EventsPublisher.eventDispose += new EventsPublisher.EventDispose(Dispose);
    }

    //取消订阅事件
    public void CancelSubscribe()
    {
        EventsPublisher.eventDispose -= new EventsPublisher.EventDispose(Dispose);
    }
    //事件处理函数
    public void Dispose() {
        Debug.Log("事件被触发啦!");
    }
}
