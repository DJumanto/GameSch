using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using System;

public class Timer : MonoBehaviour
{
    float currentTime = 0f;
    float startingTime = (float)(new DateTime(2022, 8, 3) - DateTime.UtcNow).TotalSeconds - 25200f;

    /*
    timer diset berakhir saat tgl 3Ags2022 jam 00.00
    25200 itu perbedaan waktu wib ke utc dalam detik
    */

    [SerializeField] TextMeshProUGUI countdownText;

    void Awake()
    {
        countdownText.text = startingTime.ToString();
        currentTime = startingTime;
    }

    void Update()
    {
        if (currentTime <= 0){
            currentTime = 0;
        }
        else{
            currentTime -= 1 * Time.deltaTime;
            float minute = Mathf.FloorToInt(currentTime / 60);
            float second = Mathf.FloorToInt(currentTime % 60);
            countdownText.text = string.Format("{0:00}:{1:00}", minute, second); 
        }
    }
}
