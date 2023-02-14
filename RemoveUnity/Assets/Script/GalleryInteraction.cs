using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using Yarn.Unity;


public class GalleryInteraction : MonoBehaviour
{
    private DialogueRunner dialogueRunner;
    private InMemoryVariableStorage variableStorage;
    public string objectNode;
    
    private string photoName;
    private void Awake()
    {
        dialogueRunner = FindObjectOfType<DialogueRunner>();
        variableStorage = FindObjectOfType<InMemoryVariableStorage>();
        photoName = this.name;
    }
    public void GalleryDialogueStart()
    {
        dialogueRunner.StartDialogue(objectNode);
    }


    [YarnCommand("getPhotoName")]
    public string GetPhotoName()
    {
        return photoName;
    }


    [YarnCommand("photoDelete")]
    public void PhotoDelete(GameObject photo)
    {
        photo.SetActive(false);
    }
    

}