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
    public void IncreaseScore()
    {
        result++;
        txtScore.text = result.ToString();
    }

    public void EndGame()
    {
        Debug.Log("THE END");
        txtGameOver.enabled = false;
        
        SceneManager.LoadScene("MainScene");
        
    }
   /* void PauseGame()
    {
        Time.timeScale = 0f; // zatrzymuje czas w grze
        isGamePaused = true;
        Debug.Log("Game is Paused");
    }*/
}
