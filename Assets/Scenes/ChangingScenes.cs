using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ChangingScenes : MonoBehaviour
{
    public void loadSceneDifficulty()
    {
        SceneManager.LoadScene("DifficultyScene");
    }
    public void loadSceneStartGame()
    {
        SceneManager.LoadScene("");
    }
    public void loadSceneBirds()
    {
        SceneManager.LoadScene("BirdsScene");
    }
    public void loadSceneSettings()
    {
        SceneManager.LoadScene("SettingsScene");
    }
    public void loadSceneMainScene()
    {
        SceneManager.LoadScene("MainScene");
    }
    public void loadSceneGameScene()
    {
        SceneManager.LoadScene("GameScene");
    }
}