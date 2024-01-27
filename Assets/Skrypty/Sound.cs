using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Sound : MonoBehaviour
{
    public Button Sound1;

    void Awake()
    {
        GameObject[] objs = GameObject.FindGameObjectsWithTag("Sound");
        if (objs.Length > 1)
        {
            Destroy(objs[0]);
        }
        DontDestroyOnLoad(this.gameObject);

        AudioListener.pause = PlayerPrefs.GetInt("IsSoundPaused", 0) == 1;

        Sound1 = GameObject.FindGameObjectWithTag("Sound1").GetComponent<Button>();
        if (AudioListener.pause)
        {
            Sound1.GetComponent<Image>().color = Color.grey;
        }
        else
        {
            Sound1.GetComponent<Image>().color = Color.white;
        }
    }

    public void ToggleSound()
    {
        AudioListener.pause = !AudioListener.pause;

        if (AudioListener.pause)
        {
            Sound1.GetComponent<Image>().color = Color.grey;
            PlayerPrefs.SetInt("IsSoundPaused", 1);
        }
        else
        {
            Sound1.GetComponent<Image>().color = Color.white;
            PlayerPrefs.SetInt("IsSoundPaused", 0);
        }
    }
}
