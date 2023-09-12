using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ShowTime : MonoBehaviour
{
    [SerializeField] private Text bestTimeText;
    void Start()
    {
        var currentScene = SceneManager.GetActiveScene();
        var currentSceneName = currentScene.name;

        bestTimeText.text = "Best " + PlayerPrefs.GetString(currentSceneName);
    }
}
