using System.Collections;
using System.Collections.Generic;
using JetBrains.Annotations;
using UnityEngine;
using UnityEngine.UI;

public class BirdSkin : MonoBehaviour
{
    public Sprite[,] tablica_obrazow = new Sprite[0, 3];

    // Start is called before the first frame update
    void Start()
    {
        // Inicjowanie tablicy obrazów

        tablica_obrazow[0, 0] = Resources.Load<Sprite>("Assets/Zdjecia/bird_1.png");
        tablica_obrazow[0, 1] = Resources.Load<Sprite>("Assets/Zdjecia/bird_2.png");
        tablica_obrazow[0, 2] = Resources.Load<Sprite>("Assets/Zdjecia/bird_3.png");
        tablica_obrazow[0, 3] = Resources.Load<Sprite>("Assets/Zdjecia/bird_2.png");
        // tablica_obrazow[1, 0] = Resources.Load<Sprite>("Assets/Zdjecia/Bird_1_A.png");
        // tablica_obrazow[1, 1] = Resources.Load<Sprite>("Assets/Zdjecia/Bird_1_B.png");
        // tablica_obrazow[1, 2] = Resources.Load<Sprite>("Assets/Zdjecia/Bird_1_C.png");
        // tablica_obrazow[1, 3] = Resources.Load<Sprite>("Assets/Zdjecia/Bird_1_B.png");
        // tablica_obrazow[2, 0] = Resources.Load<Sprite>("Assets/Zdjecia/Bird_2_A.png");
        // tablica_obrazow[2, 1] = Resources.Load<Sprite>("Assets/Zdjecia/Bird_2_B.png");
        // tablica_obrazow[2, 2] = Resources.Load<Sprite>("Assets/Zdjecia/Bird_2_C.png");
        // tablica_obrazow[2, 3] = Resources.Load<Sprite>("Assets/Zdjecia/Bird_2_B.png");
        // tablica_obrazow[3, 0] = Resources.Load<Sprite>("Assets/Zdjecia/Bird_3_A.png");
        // tablica_obrazow[3, 1] = Resources.Load<Sprite>("Assets/Zdjecia/Bird_3_B.png");
        // tablica_obrazow[3, 2] = Resources.Load<Sprite>("Assets/Zdjecia/Bird_3_C.png");
        // tablica_obrazow[3, 3] = Resources.Load<Sprite>("Assets/Zdjecia/Bird_3_B.png");
        // tablica_obrazow[4, 0] = Resources.Load<Sprite>("Assets/Zdjecia/Bird_4_A.png");
        // tablica_obrazow[4, 1] = Resources.Load<Sprite>("Assets/Zdjecia/Bird_4_B.png");
        // tablica_obrazow[4, 2] = Resources.Load<Sprite>("Assets/Zdjecia/Bird_4_C.png");
        // tablica_obrazow[4, 3] = Resources.Load<Sprite>("Assets/Zdjecia/Bird_4_B.png");

    }
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
