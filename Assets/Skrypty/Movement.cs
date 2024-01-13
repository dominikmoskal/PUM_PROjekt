using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    public float speed = 0.01f;
    public float border;
    public Rigidbody body;

    void Start()
    {
        body = GetComponent<Rigidbody>();
        border = Camera.main.ScreenToWorldPoint(Vector3.zero).x - 1f;
    }

    void Update()
    {
        body.MovePosition(body.position + Vector3.left * speed);
        if (body.position.x < border)
            Destroy(gameObject);
    }
}



