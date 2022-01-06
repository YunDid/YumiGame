using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shoot : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Fire1")) {
            Bullet = Instantiate(Bullet, barried.position, barried.rotation);
            Bullet.AddForce(barried.up * 500);
        }
    }

    public Rigidbody Bullet;
    public Transform barried;
}
