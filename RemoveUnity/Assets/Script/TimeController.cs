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
    float bloodTissue, fingerInCakeBox, floorHammer, stalkingPicture;
    float bloodHandprint, smellOfBlood, cigaretteInBathroom, bloodOnCloth, bloodOnRug;
    float ohHanaTalk, shimJaehwanTalk, clueToTheTruth, ring1, ring2;

    float bloodEvidence = 0;
    float trueEvidence = 0;

    public static int hour = 1;
    public static int min = 45;
    public static float sec = 0f;
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

        bloodEvidence = photoDelete + bloodTissue + bloodOnRug +
            bloodOnCloth + bloodHandprint + fingerInCakeBox +
            floorHammer + stalkingPicture + smellOfBlood +
            cigaretteInBathroom;

        variableStorage.TryGetValue("$OhHanaTalk", out ohHanaTalk);
        variableStorage.TryGetValue("$ShimJaehwanTalk", out shimJaehwanTalk);
        variableStorage.TryGetValue("$ClueToTheTruth", out clueToTheTruth);
        variableStorage.TryGetValue("$Ring1", out ring1);
        variableStorage.TryGetValue("$Ring2", out ring2);

        trueEvidence = ohHanaTalk + shimJaehwanTalk + clueToTheTruth + ring1 + ring2;

        if (bloodEvidence == 13 && trueEvidence == 5 && a == 0)
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
        if (bloodEvidence != 13)
        {
            dialogueRunner.StartDialogue("Ending3Enter");
        }
        else if (bloodEvidence == 13 && trueEvidence != 5)
        {
            dialogueRunner.StartDialogue("Ending4Enter");
        }
        
    }
    public void Remove()
    {
        dialogueRunner.Stop();
        dialogueRunner.StartDialogue("ToInfering");
    }

    [YarnCommand("timeSet")]
    public static void TimeSet()
    {
        hour = 1;
        min = 45;
        sec = 0f;
    }
    [YarnCommand("timeSkip")]
    public static void TimeSkip()
    {
        hour = 1;
        min = 59;
        sec = 59f;
    }
}

