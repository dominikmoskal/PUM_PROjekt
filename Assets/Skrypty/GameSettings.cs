using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameSettings : MonoBehaviour
{
    private int result;

    public void IncreaseScore()
    {
        result++;
    }

    public void EndGame()
    {
        Debug.Log("THE END");
    }



}
