using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.UpArrow)) {
            //给该对象一个向前的速度向量，参数结果仍然为一个Vector3向量
            transform.Translate(Vector3.forward * moveSpeed * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            //类似于给该对象绕up所在的轴一个转速
            transform.Rotate(-Vector3.up, turnSpeed * Time.deltaTime);

        }
        if (Input.GetKey(KeyCode.RightArrow))
        {
            transform.Rotate(Vector3.up, turnSpeed * Time.deltaTime);

        }
        if (Input.GetKey(KeyCode.DownArrow))
        {
            //给该对象一个向后的速度向量，参数结果仍然为一个Vector3向量
            transform.Translate(-Vector3.forward * moveSpeed * Time.deltaTime);
        }
    }

    public float moveSpeed = 10f;
    public float turnSpeed = 50f;

}
