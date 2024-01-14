using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StickResp : MonoBehaviour
{
    public float minPosition = -600f;
    public float maxPosition = 800;

    public GameObject modeles;
    public float spawnfreq = 2f;

    public void Generate()
    {
        Vector3 lastPosition = transform.position;
        Vector3 newPosition = lastPosition + Vector3.up * Random.Range(minPosition, maxPosition);

        GameObject sticks = Instantiate(modeles, lastPosition, Quaternion.identity);

        while (Mathf.Abs(lastPosition.y - newPosition.y) > 400f)
        {
            newPosition = lastPosition + Vector3.up * Random.Range(minPosition, maxPosition);
        }

        sticks.transform.position = newPosition;
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
