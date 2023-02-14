using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Yarn.Unity;
using Yarn;

public class FurnitureOpenClose : MonoBehaviour
{
    public Sprite Open;
    public Sprite Close;
    private Image backGround;

    private DialogueRunner dialogueRunner;
    private InMemoryVariableStorage variableStorage;
    private void Awake()
    {
        backGround = gameObject.transform.parent.parent.GetComponent<Image>();
        dialogueRunner = FindObjectOfType<DialogueRunner>();
        variableStorage = FindObjectOfType<InMemoryVariableStorage>();

    }
    //private void Update()
    //{
    //    if (backGround.sprite != Open && backGround.sprite != Close)
    //    {
    //        FurnitureClose();
    //    }
    //}

    public void FurnitureOpen()
    {
        backGround.sprite = Open;
        Transform[] allchildren = GetComponentsInChildren<Transform>(true);
        foreach (Transform child in allchildren)
        {
            child.gameObject.SetActive(true);
        }
    }
    public void FurnitureClose()
    {
        //backGround.sprite = Close;
        Transform[] allchildren = GetComponentsInChildren<Transform>(true);
        foreach (Transform child in allchildren)
        {
            if (child.name == transform.name)
            {
                return;
            }
            child.gameObject.SetActive(false);
        }
    }
    bool dresserKey;

    public void DresserDrawerOpenOrClose()
    {
        variableStorage.TryGetValue("$DresserKey", out dresserKey);
        if (dresserKey == true)
        {
            dialogueRunner.StartDialogue("DresserDrawerOpen");
            FurnitureOpen();
        }
        else
        {
            dialogueRunner.StartDialogue("DresserDrawerLocked");
        }
    }

    bool kitchenCabinetKey;
    public void KitchenCabinetOpenOrClose()
    {
        variableStorage.TryGetValue("$KitchenCabinetKey", out kitchenCabinetKey);
        if (kitchenCabinetKey == true)
        {
            FurnitureOpen();
        }
        else
        {
            dialogueRunner.StartDialogue("KitchenCabinetLocked");
        }
    }
}
