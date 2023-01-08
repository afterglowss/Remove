using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Yarn.Unity;

public enum ObjectType
{
    Bed,
    Sink
}

public class ObjectDialogueManager : MonoBehaviour
{
    public ObjectType objectType;

    private DialogueRunner dialogueRunner;
    private InMemoryVariableStorage variableStorage;
    public string objectNode;

    private static bool CrimeEvidenceInStudio = true;
    bool BedBloodCleanOrNot;

    [YarnFunction("getCrimeEvidenceInStudio")]
    public static bool GetCrimeEvidenceInStudio()
    {
        return CrimeEvidenceInStudio;
    }

    public void Start()
    {
        dialogueRunner = FindObjectOfType<DialogueRunner>();
        variableStorage = FindObjectOfType<InMemoryVariableStorage>();
    }
    public void OnObjectClick()
    {
        switch (objectType)
        {
            case ObjectType.Bed:
                dialogueRunner.StartDialogue(objectNode);
                variableStorage.TryGetValue("$BloodCleanOrNot", out BedBloodCleanOrNot);
                Debug.Log(BedBloodCleanOrNot);
                break;
            case ObjectType.Sink:
                dialogueRunner.StartDialogue(objectNode);
                break;
        }
    }
}
