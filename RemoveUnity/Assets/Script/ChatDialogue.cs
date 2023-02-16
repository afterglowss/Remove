using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Yarn.Unity;

public class ChatDialogue : MonoBehaviour
{
    private DialogueRunner dialogueRunner;
    private InMemoryVariableStorage variableStorage;
    public string objectNode;
    int a, b;

    private void Awake()
    {
        a = 0;
        b = 0;
        dialogueRunner = FindObjectOfType<DialogueRunner>();
        variableStorage = FindObjectOfType<InMemoryVariableStorage>();
    }
    public void ChatDialogueShimJaehwanStart()
    {
        if (a == 0)
        {
            dialogueRunner.StartDialogue("ShimJaehwan");
            a++;
        }
    }
    public void ChatDialogueOhHanaStart()
    {
        if (b == 0)
        {
            b++;
            dialogueRunner.StartDialogue("OhHana");
        }
    }
}
