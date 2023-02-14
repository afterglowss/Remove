using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class TimeController : MonoBehaviour
{
    [SerializeField]
    
    public TextMeshProUGUI timeText;

    int hour = 1;
    int min = 43;
    float sec = 0f;

    void Update()
    {
        PhoneTime();
    }
    void PhoneTime()
    {
        sec += Time.deltaTime;
        timeText.text = String.Format("{0:D2}:{1:D2}", hour, min);
        if ((int)sec > 59)
        {
            sec = 0f;
            min++;
        }
        if (min > 59)
        {
            min = 0;
            hour++;
        }
    }

}

