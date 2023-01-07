using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Yarn.Unity;

public enum ObjectType
{
    Bed
}

public class ObjectScriptManager : MonoBehaviour
{
    ObjectType objectType;

    private DialogueRunner dialogueRunner;
    public string objectNode;

    public void Start()
    {
        dialogueRunner = FindObjectOfType<DialogueRunner>();

    }
    public void OnObjectClick()
    {
        switch (objectType)
        {
            case ObjectType.Bed:
                dialogueRunner.StartDialogue(objectNode);
                break;
        }
    }
}
