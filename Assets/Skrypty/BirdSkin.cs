using System.Collections;
using System.Collections.Generic;
using JetBrains.Annotations;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class BirdSkin : MonoBehaviour
{
    public void Bird1()
    {
        PlayerPrefs.SetInt("skinIndex", 1);
        SceneManager.LoadScene("MainScene");
    }
    public void Bird2()
    {
        PlayerPrefs.SetInt("skinIndex", 2);
        SceneManager.LoadScene("MainScene");
    }
    public void Bird3()
    {
        PlayerPrefs.SetInt("skinIndex", 3);
        SceneManager.LoadScene("MainScene");
    }
    public void Bird4()
    {
        PlayerPrefs.SetInt("skinIndex", 4);
        SceneManager.LoadScene("MainScene");
    }
}
