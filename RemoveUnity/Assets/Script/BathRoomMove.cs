using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Yarn.Unity;

public enum BathroomBTNType
{
    Right,
    Left,
    Down,
    Up
}

public class BathRoomMove : MonoBehaviour
{
    public BathroomBTNType type;
    private Camera mainCamera;

    private InMemoryVariableStorage variableStorage;
    private DialogueRunner dialogueRunner;

    bool bathroomKey;

    private void Awake()
    {
        mainCamera = GameObject.Find("Main Camera").GetComponent<Camera>();
        variableStorage = FindObjectOfType<InMemoryVariableStorage>();
        dialogueRunner = FindObjectOfType<DialogueRunner>();
    }

    public void OnBathroomBtnClick()
    {
        switch (type)
        {
            case BathroomBTNType.Left:
                mainCamera.transform.position = new Vector3(-35.5556f, 0, -100);
                break;
            case BathroomBTNType.Right:
                mainCamera.transform.position = new Vector3(-17.7778f, 0, -100);
                break;
            case BathroomBTNType.Down:
                mainCamera.transform.position = new Vector3(0, 0, -100);
                break;
            case BathroomBTNType.Up:
                variableStorage.TryGetValue("$BathRoomKey", out bathroomKey);
                //Debug.Log(bathroomKey);
                if (bathroomKey == true)
                {
                    mainCamera.transform.position = new Vector3(-17.7778f, 0, -100);
                    dialogueRunner.StartDialogue("BathRoom");
                }
                else
                {
                    dialogueRunner.StartDialogue("BathRoomLocked");
                }
                
                break;
        }
    }
}
