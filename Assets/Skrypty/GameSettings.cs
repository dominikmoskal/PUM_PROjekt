using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameSettings : MonoBehaviour
{
    public Button Vibrations1;
    private int result;
    public Text txtScore;
    public Text txtGameOver;
    public AudioSource audioSource;
    public int isVibrationEnabled = 1;
    public static float czas;
    
    void Awake()
    {
        isVibrationEnabled = PlayerPrefs.GetInt("IsVibrationEnabled", 1);

        Vibrations1 = GameObject.FindGameObjectWithTag("Vibrations1").GetComponent<Button>();
        if(isVibrationEnabled == 1)
        {
            Vibrations1.GetComponent<Image>().color = Color.white;
        }
        else
        {
            Vibrations1.GetComponent<Image>().color = Color.grey;
        }
    }

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
    }

    public void vibrationsEnabled()
    {
        Vibrations1 = GameObject.FindGameObjectWithTag("Vibrations1").GetComponent<Button>();
        if(isVibrationEnabled == 1)
        {
            PlayerPrefs.SetInt("IsVibrationEnabled", 1);
            Handheld.Vibrate();
            isVibrationEnabled = 0;
            Vibrations1.GetComponent<Image>().color = Color.white;
        } 
        else
        {
            PlayerPrefs.SetInt("IsVibrationEnabled", 0);
            isVibrationEnabled = 1;
            Vibrations1.GetComponent<Image>().color = Color.grey;
        }
    }
}
