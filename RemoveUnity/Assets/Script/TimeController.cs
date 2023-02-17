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

    int a = 0;

    float photoDelete;
    bool bloodTissue, fingerInCakeBox, floorHammer, stalkingPicture;
    bool bloodHandprint, smellOfBlood, cigaretteInBathroom, bloodOnCloth, bloodOnRug;

    int hour = 1;
    int min = 45;
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

        variableStorage.TryGetValue("$PhotoDelete", out photoDelete);
        variableStorage.TryGetValue("$BloodTissue", out bloodTissue);
        variableStorage.TryGetValue("$FingerInCakeBox", out fingerInCakeBox);
        variableStorage.TryGetValue("$FloorHammer", out floorHammer);
        variableStorage.TryGetValue("$StalkingPicture", out stalkingPicture);
        variableStorage.TryGetValue("$BloodHandprint", out bloodHandprint);
        variableStorage.TryGetValue("$SmellOfBlood", out smellOfBlood);
        variableStorage.TryGetValue("$CigaretteInBathroom", out cigaretteInBathroom);
        variableStorage.TryGetValue("$BloodOnCloth", out bloodOnCloth);
        variableStorage.TryGetValue("$BloodOnRug", out bloodOnRug);

        if (photoDelete == 4 && bloodTissue == true && bloodOnRug == true && 
            bloodOnCloth == true && bloodHandprint == true && fingerInCakeBox == true &&
            floorHammer == true && stalkingPicture == true && smellOfBlood == true &&
            cigaretteInBathroom == true && a == 0)
        {
            Remove();
            a++;
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
    public void Remove()
    {
        dialogueRunner.Stop();
        dialogueRunner.StartDialogue("ToInfering");
    }
}

