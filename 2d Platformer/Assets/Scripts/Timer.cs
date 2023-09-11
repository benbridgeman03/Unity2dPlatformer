using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

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
        endTime = timePlayingStr;
        timerGoing = false;
    }

    private IEnumerator UpdateTimer()
    {
        while (timerGoing)
        {
            Debug.Log(timePlaying);
            elaspedTime += Time.deltaTime;
            timePlaying = TimeSpan.FromSeconds(elaspedTime);
            timePlayingStr = "Time: " + timePlaying.ToString("mm':'ss'.'ff");
            timeText.text = timePlayingStr;

            yield return null;
        }
    }

}
