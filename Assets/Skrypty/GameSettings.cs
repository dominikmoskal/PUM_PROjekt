using System;
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
    public int isVibrationEnabled = 1;
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

    public void vibrationsEnabled()
    {
        if(isVibrationEnabled == 1)
        {
            PlayerPrefs.SetInt("IsVibrationEnabled", 1);
            Handheld.Vibrate();
            isVibrationEnabled = 0;
        } 
        else
        {
            PlayerPrefs.SetInt("IsVibrationEnabled", 0);
            isVibrationEnabled = 1;
        }
    }
}
