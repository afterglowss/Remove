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
    }
    public void PoliceCallingStart()
    {
        dialogueRunner.Stop();
        dialogueRunner.StartDialogue("PoliceCalling");
    }
    public void MentalHospitalCallStart()
    {
        dialogueRunner.StartDialogue("MentalHospitalCall");
    }

    public void DialogueStop()
    {
        dialogueRunner.Stop();
    }

    [YarnCommand("objectDelete")]
    public void ObjectDelete(GameObject obj)
    {
        obj.SetActive(false);
    }
    [YarnCommand("policeCallActive")]
    public static void PoliceCallActive(GameObject obj)
    {
        obj = GameObject.Find("PhoneImage").transform.Find("PoliceCall").gameObject;
        obj.SetActive(true);
    }
    [YarnCommand("hammerActive")]
    public static void HammerActive(GameObject obj)
    {
        obj = GameObject.Find("RoomCanvas").transform.Find("Hammer").gameObject;
        obj.SetActive(true);
    }
    [YarnCommand("blockActive")]
    public static void BlockActive(GameObject obj)
    {
        obj = GameObject.Find("RoomCanvas").transform.Find("HammerBlockImage").gameObject;
        obj.SetActive(true);
    }
    [YarnCommand("mentalHospitalActive")]
    public static void MentalHospitalActive(GameObject obj)
    {
        obj = GameObject.Find("PhoneImage").transform.Find("MentalHospital").gameObject;
        obj.SetActive(true);
    }
    [YarnCommand("ringAppear")]
    public static void RingAppear(GameObject ring)
    {
        Color color;
        color = ring.GetComponent<Image>().color;
        color.a = 1f;
        ring.GetComponent<Image>().color = color;
    }
    [YarnCommand("ringDisappear")]
    public static void RingDisappear(GameObject ring)
    {
        Color color;
        color = ring.GetComponent<Image>().color;
        color.a = 0f;
        ring.GetComponent<Image>().color = color;
    }
}
