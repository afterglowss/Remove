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

    int a = 0, b = 0;

    float photoDelete;
    bool bloodTissue, fingerInCakeBox, floorHammer, stalkingPicture;
    bool bloodHandprint, smellOfBlood, cigaretteInBathroom, bloodOnCloth, bloodOnRug;
    bool ohHanaTalk, shimJaehwanTalk, clueToTheTruth, ring1, ring2;

    int hour = 1;
    int min = 45;
    float sec = 0f;
    public void Start()
    {
        a = 0;
        b = 0;
        dialogueRunner = FindObjectOfType<DialogueRunner>();
        variableStorage = FindObjectOfType<InMemoryVariableStorage>();
    }



    void Update()
    {
        PhoneTime();
        if (hour == 2 && min == 0 && sec == 0f && b == 0)
        {
            b++;
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

        variableStorage.TryGetValue("$OhHanaTalk", out ohHanaTalk);
        variableStorage.TryGetValue("$ShimJaehwanTalk", out shimJaehwanTalk);
        variableStorage.TryGetValue("$ClueToTheTruth", out clueToTheTruth);
        variableStorage.TryGetValue("$Ring1", out ring1);
        variableStorage.TryGetValue("$Ring2", out ring2);

        if (photoDelete == 4 && bloodTissue == true && bloodOnRug == true && 
            bloodOnCloth == true && bloodHandprint == true && fingerInCakeBox == true &&
            floorHammer == true && stalkingPicture == true && smellOfBlood == true &&
            cigaretteInBathroom == true && ohHanaTalk == true && shimJaehwanTalk == true &&
            clueToTheTruth == true && ring1 == true && ring2 == true && a == 0)
        {
            a++;
            Remove();
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
        dialogueRunner.Stop();
        dialogueRunner.StartDialogue("Intersection");
    }
    public void Remove()
    {
        dialogueRunner.Stop();
        dialogueRunner.StartDialogue("ToInfering");
    }
}

