using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Vibration : MonoBehaviour
{
    public void ToggleVibration()
    {
        if (PlayerPrefs.GetInt("VibrationEnabled", 1) == 1)
        {
            PlayerPrefs.SetInt("VibrationEnabled", 0);
            Handheld.Vibrate();
        }
        else
        {
            PlayerPrefs.SetInt("VibrationEnabled", 1);
        }
    }
}
