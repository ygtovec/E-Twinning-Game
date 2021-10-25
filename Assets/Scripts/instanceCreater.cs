using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class instanceCreater : MonoBehaviour
{
    public float speed;

    void Start()
    {
        Destroy(gameObject, 4.5f);
    }
    void FixedUpdate()
    {
        transform.position += Vector3.left * speed * Time.deltaTime;
    }
}
