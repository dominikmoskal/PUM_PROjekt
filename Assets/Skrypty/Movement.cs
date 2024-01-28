using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class Movement : MonoBehaviour
{
    public static float speed = 300f;
    public float border;
    public Rigidbody body;

    void Start()
    {
        body = GetComponent<Rigidbody>();
        border = Camera.main.ScreenToWorldPoint(Vector3.zero).x - 100f;
    }
    public void Easy()
    {
        Time.timeScale = 1.333f;
        SceneManager.LoadScene("MainScene");
    }
    public void Normal()
    {
        Time.timeScale = 1.666f;
        SceneManager.LoadScene("MainScene");
    }
    public void Hard()
    {
        Time.timeScale = 2.333f;
        SceneManager.LoadScene("MainScene");
    }
    void Update()
    {
        float speedPerFrame = speed * Time.deltaTime;
        body.MovePosition(body.position + Vector3.left * speedPerFrame);
        if (body.position.x < border)
            Destroy(gameObject);
    }
}



