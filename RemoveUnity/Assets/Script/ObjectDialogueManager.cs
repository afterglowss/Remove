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
    DresserDrawer,
    DresserDrawerClose,
    StalkingPicture,
    KitchenFloor,
    KitchenKnife,
    Window,
    BookShelf,
    Basin,
    KitchenCabinet,
    TrashCan,
    KitchenDrawer,
    CakeBox,
    Water,
    Box,
    Drug,
    Plate,
    BathRoomTrashCan,
    BathRoomTrash,
    Shampoo,
    LaptopAndPencilHolder,
    RefrigeratorUp,
    Comic,
    Novel,
    Rug,

}

public class ObjectDialogueManager : MonoBehaviour
{
    public ObjectType objectType;

    private DialogueRunner dialogueRunner;
    private InMemoryVariableStorage variableStorage;
    public string objectNode;

    public void Start()
    {
        dialogueRunner = FindObjectOfType<DialogueRunner>();
        variableStorage = FindObjectOfType<InMemoryVariableStorage>();
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
                
                break;
            case ObjectType.DresserDrawer:

                break;
            case ObjectType.KitchenFloor:
                break;
        }
    }

    
    [YarnCommand("objectDelete")]
    public void ObjectDelete(GameObject obj)
    {
        obj.SetActive(false);
    }

    
}
