using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using Yarn.Unity;

public class TimeController : MonoBehaviour
{
    [SerializeField]
    
    public TextMeshProUGUI timeText;
    private DialogueRunner dialogueRunner;
    private InMemoryVariableStorage variableStorage;

    int hour = 1;
    int min = 50;
    float sec = 0f;
    public void Start()
    {
        dialogueRunner = FindObjectOfType<DialogueRunner>();
        variableStorage = FindObjectOfType<InMemoryVariableStorage>();
    }



    void Update()
    {
        PhoneTime();
        if (hour == 2 && min == 0 && sec == 0f)
        {
            TimeOut();
        }
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

    public void TimeOut()
    {
        dialogueRunner.StartDialogue("Intersection");
    }

}

