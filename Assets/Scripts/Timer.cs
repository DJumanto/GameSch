using UnityEngine;
using TMPro;
using System;

public class Timer : MonoBehaviour
{
    [SerializeField] private int year;
    [SerializeField] private int month;
    [SerializeField] private int day;
    [SerializeField] private int hour;
    [SerializeField] private int minute;
    [SerializeField] TextMeshProUGUI countdownText;

    float currentTime = 0f;
    float startingTime;

    void Awake()
    {
        startingTime = (float)((new DateTime(year, month, day) - DateTime.UtcNow).TotalSeconds - 25200f);
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
