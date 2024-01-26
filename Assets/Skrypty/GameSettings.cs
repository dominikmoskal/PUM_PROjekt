using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameSettings : MonoBehaviour
{
    private int result;
    public Text txtScore;
    public Text txtGameOver;
    public AudioSource audioSource;

    public static float czas;
    public void IncreaseScore()
    {
        result++;
        txtScore.text = result.ToString();
    }

    public void EndGame()
    {
        czas = Time.timeScale;
        Time.timeScale = 0f;
        Debug.Log("THE END");
        txtGameOver.enabled = false;
    
    }

   /* void PauseGame()
    {
        Time.timeScale = 0f; // zatrzymuje czas w grze
        isGamePaused = true;
        Debug.Log("Game is Paused");
    }*/
}
