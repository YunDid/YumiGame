
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
        //���ٱ���Ϸ����
        if (Input.GetKeyDown(KeyCode.Space)) {
            Destroy(gameObject, 1f);
        }

        //����������Ϸ����
        if (Input.GetKeyDown(KeyCode.L))
        {
            Destroy(other, 1f);
        }

        //�������
        if (Input.GetKeyDown(KeyCode.M))
        {
            Destroy(GetComponent<Renderer>(), 1f);
        }
    }

    public GameObject other;
}
