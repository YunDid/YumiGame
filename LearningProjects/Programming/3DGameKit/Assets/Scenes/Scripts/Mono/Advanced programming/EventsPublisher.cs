using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EventsPublisher : MonoBehaviour
{

    //ί��
    public delegate void EventDispose();

    //�¼�
    public static EventDispose eventDispose;

    //�¼�֪ͨ����
    public void Notify() {
        if (eventDispose != null) {
            //�����Ѷ��ĵ������Ӧ�¼�������
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

    //�����¼�
    public void Subscribe() {
        EventsPublisher.eventDispose += new EventsPublisher.EventDispose(Dispose);
    }

    //ȡ�������¼�
    public void CancelSubscribe()
    {
        EventsPublisher.eventDispose -= new EventsPublisher.EventDispose(Dispose);
    }
    //�¼�������
    public void Dispose() {
        Debug.Log("�¼���������!");
    }
}
