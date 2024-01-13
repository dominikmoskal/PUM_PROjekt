using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StickResp : MonoBehaviour
{
    public float minPosition = -00f;
    public float maxPosition = 800f;

    public GameObject modeles;
    public float spawnfreq = 50f;

    public void Generate()
    {
        GameObject sticks = Instantiate(modeles, transform.position, Quaternion.identity);

        sticks.transform.position += Vector3.up * Random.Range(minPosition, maxPosition);
    }
    public void OnEnable() 
    {   
    
        InvokeRepeating(nameof(Generate), spawnfreq, spawnfreq);
    }

    public void OnDisable ()
    {
        CancelInvoke(nameof(Generate)); 
    }

}
