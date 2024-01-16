using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameSettings : MonoBehaviour
{
    private int result;
    public Text txtScore;

    public void IncreaseScore()
    {
        result++;
        txtScore.text = result.ToString();
    }

    public void EndGame()
    {
        Debug.Log("THE END");
        
    }



}
