using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{

    public float speed = 5f;
    public float border;


    public void Update()
    {
        transform.position = Vector3.right  *speed * Time.deltaTime; //
        if (transform.position.x < border)
            Destroy(gameObject);
    }

    public void Start()
    {
        border = Camera.main.ScreenToWorldPoint(Vector3.zero).x-1f;
    }
}
