using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Timer : MonoBehaviour
{
    public static Timer instance;
    private static string endTime;

    [SerializeField] private Text timeText;

    private TimeSpan timePlaying;
    private bool timerGoing;
    private string timePlayingStr;

    private float elaspedTime;

    private void Awake()
    {
        instance = this;
    }

    private void Start()
    {
        timeText.text = "Time: 00:00.00";
        timerGoing = false;
        BeginTimer();
    }
    public void BeginTimer()
    {
        timerGoing = true;
        elaspedTime = 0f;

        StartCoroutine(UpdateTimer());
    }

    public void EndTimer()
    {
        var currentScene = SceneManager.GetActiveScene();
        var currentSceneName = currentScene.name;
        endTime = timePlayingStr;

        double mili = timePlaying.TotalMilliseconds;

        if(!PlayerPrefs.HasKey(currentSceneName+"i"))
        {
            PlayerPrefs.SetInt(currentSceneName+"i", (int)mili);
            PlayerPrefs.SetString(currentSceneName, timePlayingStr);
        }
        else
        {
            if(PlayerPrefs.GetInt(currentSceneName+"i") > (int)mili)
            {
                PlayerPrefs.SetString(currentSceneName, timePlayingStr);
                PlayerPrefs.SetInt(currentSceneName + "i", (int)mili);
            }
        }

        timerGoing = false;
    }

    private IEnumerator UpdateTimer()
    {
        while (timerGoing)
        {
            elaspedTime += Time.deltaTime;
            timePlaying = TimeSpan.FromSeconds(elaspedTime);
            timePlayingStr = "Time: " + timePlaying.ToString("mm':'ss'.'ff");
            timeText.text = timePlayingStr;

            yield return null;
        }
    }

}
