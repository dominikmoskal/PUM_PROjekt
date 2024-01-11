using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LoopedBcg : MonoBehaviour
{
    public MeshRenderer meshRenderer;

    public float bcgSpeed = 1;
   
    private void Awake()
    {
        meshRenderer = GetComponent<MeshRenderer>();
        
    }

    private void Update()
    {
        meshRenderer.material.mainTextureOffset += new Vector2(Time.deltaTime * bcgSpeed,0);
    }
}
