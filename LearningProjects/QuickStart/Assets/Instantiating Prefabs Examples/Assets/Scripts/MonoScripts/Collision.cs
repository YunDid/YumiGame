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
        //���봥����ִ�еĴ���
        Debug.Log("Trigger��⵽��ײ!");
    }

    void OnCollisionEnter()
    {
        //������ײ��ִ�еĴ���
        Debug.Log("Collision��⵽��ײ!");
    }

}
