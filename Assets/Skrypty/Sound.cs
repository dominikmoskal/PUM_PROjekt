using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sound : MonoBehaviour
{
 
        void Awake()
    {
        GameObject[] objs = GameObject.FindGameObjectsWithTag("Sound");
        if (objs.Length > 1)
        {
            Destroy(objs[0]);
        }
        DontDestroyOnLoad(this.gameObject);
    }

        public void ToggleSound()
    {
        AudioListener.pause = !AudioListener.pause;
    }
}
