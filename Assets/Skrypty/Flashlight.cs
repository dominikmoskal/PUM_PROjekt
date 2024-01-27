using UnityEngine;
using UnityEngine.UI;

public class Flashlight : MonoBehaviour
{
    private AndroidJavaObject cameraManager;
    private bool isFlashlightOn = false;
    public Button Flashlight1;

    public void Start()
    {
        if (Application.platform == RuntimePlatform.Android)
        {
            using (var unityPlayer = new AndroidJavaClass("com.unity3d.player.UnityPlayer"))
            {
                using (var activity = unityPlayer.GetStatic<AndroidJavaObject>("currentActivity"))
                {
                    cameraManager = activity.Call<AndroidJavaObject>("getSystemService", "camera");
                }
            }
        }
        isFlashlightOn = PlayerPrefs.GetInt("IsFlashlightOn", 0) == 1;

        Flashlight1 = GameObject.FindGameObjectWithTag("Flashlight1").GetComponent<Button>();
        if (isFlashlightOn)
        {
            Flashlight1.GetComponent<Image>().color = Color.grey;
        }
        else
        {
            Flashlight1.GetComponent<Image>().color = Color.white;
        }
    }

    public void ToggleFlashlight()
    {
        if (isFlashlightOn)
        {
            Flashlight1.GetComponent<Image>().color = Color.grey;
        }
        else
        {
            Flashlight1.GetComponent<Image>().color = Color.white;
        }
        if (Application.platform == RuntimePlatform.Android)
        {
            if (isFlashlightOn)
            {
                cameraManager.Call("setTorchMode", "0", false);
                PlayerPrefs.SetInt("IsFlashlightOn",1);
            }
            else
            {
                cameraManager.Call("setTorchMode", "0", true);
                PlayerPrefs.SetInt("IsFlashlightOn",0);
            }

            isFlashlightOn = !isFlashlightOn;
        }
    }
}
