using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using System;

public class Timer : MonoBehaviour
{
    [SerializeField] private int hour;
    [SerializeField] private int minute;
    [SerializeField] TextMeshProUGUI countdownText;

    float currentTime = 0f;
    float startingTime = (float)(new DateTime(2022, 8, 2) - DateTime.UtcNow).TotalSeconds - 25200f;

    void Awake()
    {
        startingTime += hour*3600 + minute*60;

        currentTime = startingTime;
    }

    void Update()
    {

        currentTime -= 1 * Time.deltaTime;

        if (currentTime <= 0){
            currentTime = 0;
        }
         
        TimeSpan timeSpan = TimeSpan.FromSeconds(currentTime);
        string timeText = string.Format("{0:D2}:{1:D2}:{2:D2}", timeSpan.Hours, timeSpan.Minutes, timeSpan.Seconds);
        countdownText.text = timeText; 
        
    }
}
