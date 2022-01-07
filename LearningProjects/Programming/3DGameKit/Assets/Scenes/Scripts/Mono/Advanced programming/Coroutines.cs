using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coroutines : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine("MoveTo", target);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    IEnumerator MoveTo(Transform target) {

        while (Vector3.Distance(transform.position, target.position) > 1f) {
            print(transform.position - target.position);
            transform.position = Vector3.Lerp(transform.position, target.position, speed * Time.deltaTime);

            yield return null;
        }

        print("Reached the target.");

        yield return new WaitForSeconds(1f);
    }

    public Transform target;
    public float speed = 1f;
}
