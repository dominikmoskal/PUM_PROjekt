using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class Movement : MonoBehaviour
{
    public static float speed = 20f;
    public float border;
    public Rigidbody body;

    void Start()
    {
        body = GetComponent<Rigidbody>();
        border = Camera.main.ScreenToWorldPoint(Vector3.zero).x - 100f;
    }
    public void Easy()
    {
        Time.timeScale = 0.666f;
        SceneManager.LoadScene("MainScene");
    }
    public void Normal()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene("MainScene");
    }
    public void Hard()
    {
        Time.timeScale = 1.5f;
        SceneManager.LoadScene("MainScene");
    }
    void Update()
    {
        body.MovePosition(body.position + Vector3.left * speed);
        if (body.position.x < border)
            Destroy(gameObject);
    }
}



