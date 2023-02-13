using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using Yarn.Unity;

//public class GalleryInteraction : MonoBehaviour
//{
//    private DialogueRunner dialogueRunner;
//    private InMemoryVariableStorage variableStorage;
//    private static GameObject photo1;
//    private static GameObject photo2;
//    private static GameObject photo3;
//    private static GameObject photo4;
//    public string objectNode;
//    private void Awake()
//    {
//        dialogueRunner = FindObjectOfType<DialogueRunner>();
//        variableStorage = FindObjectOfType<InMemoryVariableStorage>();
//        photo1 = this.gameObject;
//        photo2 = this.gameObject;
//        photo3 = this.gameObject;
//        photo4 = this.gameObject;
//    }
//    public void GalleryDialogueStart()
//    {
//        dialogueRunner.StartDialogue(objectNode);
//    }

//    [YarnCommand("photo1Delete")]
//    public static void Photo1Delete()
//    {
//        photo1.SetActive(false);
//    }
//    [YarnCommand("photo2Delete")]
//    public static void Photo2Delete()
//    {
//        photo2.SetActive(false);
//    }
//    [YarnCommand("photo3Delete")]
//    public static void Photo3Delete()
//    {
//        photo3.SetActive(false);
//    }
//    [YarnCommand("photo4Delete")]
//    public static void Photo4Delete()
//    {
//        photo4.SetActive(false);
//    }

//}
public class GalleryInteraction : MonoBehaviour
{
    private DialogueRunner dialogueRunner;
    private InMemoryVariableStorage variableStorage;
    public static GameObject photo1;
    public static GameObject photo2;
    public static GameObject photo3;
    public static GameObject photo4;
    public string objectNode;
    private void Awake()
    {
        dialogueRunner = FindObjectOfType<DialogueRunner>();
        variableStorage = FindObjectOfType<InMemoryVariableStorage>();
    }
    public void GalleryDialogueStart()
    {
        dialogueRunner.StartDialogue(objectNode);
    }

    [YarnCommand("photo1Delete")]
    public static void Photo1Delete()
    {
        photo1.SetActive(false);
    }
    [YarnCommand("photo2Delete")]
    public static void Photo2Delete()
    {
        photo2.SetActive(false);
    }
    [YarnCommand("photo3Delete")]
    public static void Photo3Delete()
    {
        photo3.SetActive(false);
    }
    [YarnCommand("photo4Delete")]
    public static void Photo4Delete()
    {
        photo4.SetActive(false);
    }

}