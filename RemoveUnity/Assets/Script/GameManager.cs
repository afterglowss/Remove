using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using Yarn.Unity;

public class GameManager : MonoBehaviour
{
    public static GameManager instance;

    public static bool [] isScene;
    public static bool isSkip;

    private DialogueRunner dialogueRunner;
    private InMemoryVariableStorage variableStorage;

    public void Start()
    {
        dialogueRunner = FindObjectOfType<DialogueRunner>();
        variableStorage = FindObjectOfType<InMemoryVariableStorage>();
    }

    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
            DontDestroyOnLoad(gameObject);
            isScene = new bool[3];
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
}
