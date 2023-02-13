using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Yarn.Unity;

public enum ObjectType
{
    Bed,
    Sink,
    Refrigerator,
    FrontDoor,
    Desk,
    BathRoom,
    ShoeShelfOpen,
    ShoeShelfClose,
    DresserDrawerOpen,
    DresserDrawerClose,
    StalkingPicture,
    KitchenFloor,
    KitchenKnife,
    Window,
    BookShelf,
    Basin,
    KitchenCabinet,
    TrashCan,
    KitchenDrawer

}

public class ObjectDialogueManager : MonoBehaviour
{
    public ObjectType objectType;

    private DialogueRunner dialogueRunner;
    private InMemoryVariableStorage variableStorage;
    public string objectNode;

    Image Room1;
    Image Room2;
    Image Room3;
    Image Room4;
    //public Sprite changeImage;
    //private Sprite presentImage;

    //private static bool CrimeEvidenceInStudio = true;
    //bool BedBloodCleanOrNot;

    //[YarnFunction("getCrimeEvidenceInStudio")]
    //public static bool GetCrimeEvidenceInStudio()
    //{
    //    return CrimeEvidenceInStudio;
    //}

    public void Start()
    {
        dialogueRunner = FindObjectOfType<DialogueRunner>();
        variableStorage = FindObjectOfType<InMemoryVariableStorage>();
        Room1 = GameObject.Find("Room1").GetComponent<Image>();
        Room2 = GameObject.Find("Room2").GetComponent<Image>();
        Room3 = GameObject.Find("Room3").GetComponent<Image>();
        Room4 = GameObject.Find("Room4").GetComponent<Image>();
    }
    public void OnObjectDialogueStart()
    {
        dialogueRunner.StartDialogue(objectNode);
        switch (objectType)
        {
            case ObjectType.Bed:
                //variableStorage.TryGetValue("$BloodCleanOrNot", out BedBloodCleanOrNot);
                //Debug.Log(BedBloodCleanOrNot);
                break;
            case ObjectType.Sink:
                break;
            case ObjectType.Refrigerator:
                break;
            case ObjectType.FrontDoor:
                break;
            case ObjectType.Desk:
                break;
            case ObjectType.ShoeShelfClose:
                //if (Room3.sprite == changeImage)
                //{
                //    dialogueRunner.StartDialogue(objectNode);

                //}
                //else
                //{
                //    presentImage = Room3.sprite;
                //    Room3.sprite = changeImage;
                //}
                
                break;
            case ObjectType.DresserDrawerOpen:

                break;
        }
    }
    public void ObjectInteration()
    {

    }
}
