using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;
using Yarn.Unity;

public class GameManager : MonoBehaviour
{
    public static GameManager instance;

    public static bool [] isScene;
    public static bool isSkip;

    private DialogueRunner dialogueRunner;
    private InMemoryVariableStorage variableStorage;

    public Image callrecord;

    public void Start()
    {
        dialogueRunner = FindObjectOfType<DialogueRunner>();
        variableStorage = FindObjectOfType<InMemoryVariableStorage>();
    }

    private void Awake()
    {
        Application.targetFrameRate = 60;

        isSkip = true;

        if (instance == null)
        {
            instance = this;
            DontDestroyOnLoad(gameObject);
            isScene = new bool[3];

            isScene[0] = true;
            isScene[1] = true;
            isScene[2] = true;

        }
        else 
            Destroy(gameObject);
    }
    

    [YarnCommand("seeScene")]
    public static void SeeScene(int index)
    {
        isScene[index] = true;
    }
    [YarnCommand("isSkip")]
    public static void IsSkip(bool i)
    {
        isSkip = i;
    }
    [YarnFunction("getSkip")]
    public static bool GetSkip()
    {
        return isSkip;
    }


    [YarnCommand("callRecord")]
    public static void CallRecord()
    {
        GameObject.Find("PhoneCanvas").transform.Find("CallApp").gameObject.SetActive(true);
        Color color;
        color = instance.callrecord.color;
        color.a = 1f;
        instance.callrecord.color = color;
    }
}
