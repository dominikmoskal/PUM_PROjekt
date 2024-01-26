using System.Collections;
using System.Collections.Generic;
using JetBrains.Annotations;
using UnityEngine;
using UnityEngine.UI;

public class BirdSkin : MonoBehaviour
{
    public int skinIndex;

    public void Bird1()
    {
        PlayerPrefs.SetInt("skinIndex", 1);
    }
    public void Bird2()
    {
        PlayerPrefs.SetInt("skinIndex", 2);
    }
    public void Bird3()
    {
        PlayerPrefs.SetInt("skinIndex", 3);
    }
    public void Bird4()
    {
        PlayerPrefs.SetInt("skinIndex", 4);
    }
}
