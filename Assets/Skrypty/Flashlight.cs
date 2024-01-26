using UnityEngine;

public class Flashlight : MonoBehaviour
{
    private AndroidJavaObject cameraManager;
    private bool isFlashlightOn = false;

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
    }

    public void ToggleFlashlight()
    {
        if (Application.platform == RuntimePlatform.Android)
        {
            if (isFlashlightOn)
            {
                cameraManager.Call("setTorchMode", "0", false); // Wyłącz latarkę
            }
            else
            {
                cameraManager.Call("setTorchMode", "0", true); // Włącz latarkę
            }

            isFlashlightOn = !isFlashlightOn; // Zmień stan latarki
        }
    }
}
