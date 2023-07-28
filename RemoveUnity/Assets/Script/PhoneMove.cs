using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Yarn.Unity;

public class PhoneMove : MonoBehaviour
{
    private Transform cameraTransform;
    public GameObject Phone;
    private Image phoneImage;
    private Vector3 Target;
    private Vector3 std;
    private GameObject phoneBlock;
    public GameObject phoneBlack;

    private GameObject policeCall;
    public Sprite policeCallAnswer;
    private GameObject mentalHospital;
    public Sprite mentalHospitalAnswer;

    ObjectDialogueManager objectDialogueManager;

    private DialogueRunner dialogueRunner;
    private InMemoryVariableStorage variableStorage;


    public static int i = 1;
    [YarnCommand("setNumber")]
    public static void SetNumber(int newNumber)
    {
        i = newNumber;
    }

    void Awake()
    {
        cameraTransform = GameObject.Find("Main Camera").GetComponent<Transform>();
        Target = new Vector3(0, -11, 100);
        std = new Vector3(0, -11, 100);
        //phoneImage = Phone.GetComponent<Image>();
        policeCall = GameObject.Find("PhoneImage").transform.Find("PoliceCall").gameObject;
        mentalHospital = GameObject.Find("PhoneImage").transform.Find("MentalHospital").gameObject;
        objectDialogueManager = GetComponent<ObjectDialogueManager>();
        dialogueRunner = FindObjectOfType<DialogueRunner>();
        variableStorage = FindObjectOfType<InMemoryVariableStorage>();
    }
    [YarnCommand("phoneUp")]
    public void PhoneUp()
    {
        Target = new Vector3(0, 0, 100);
        phoneBlack.SetActive(false);
        GameObject.Find("PhoneCanvas").transform.Find("PhoneBlockImage").gameObject.SetActive(true);
    }

    [YarnCommand("phoneUpWithLOpen")]   //PhoneUp 그대로 수정하면 안될 수도 있을 것 같아서 커맨드 따로 추가함//L어플 열린채 올라옴
    public void PhoneUpWithLOpen()
    {
        Target = new Vector3(0, 0, 100);
        phoneBlack.SetActive(false);
        GameObject.Find("PhoneCanvas").transform.Find("PhoneBlockImage").gameObject.SetActive(true);
        GameObject.Find("PhoneImage").transform.Find("Password").gameObject.SetActive(true);
    }

    [YarnCommand("phoneDown")]
    public void PhoneDown()
    {
        Target = new Vector3(0, -11, 100);
        phoneBlack.SetActive(true);
        GameObject.Find("PhoneBlockImage").gameObject.SetActive(!true);
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Tab))
        {
            
            if (std.x - Target.x == 0 && std.y - Target.y == 0 && std.z - Target.z == 0)
            {
                if (i == 3) return;
                PhoneUp();
                if (i == 0)
                {
                    Invoke("PoliceCallAnswer", 1f);
                    objectDialogueManager.PoliceCallingStart();
                }
                if (i == 2)
                {
                    Invoke("MentalHospitalAnswer", 1f);
                    objectDialogueManager.DialogueStop();
                    objectDialogueManager.MentalHospitalCallStart();
                }
                
            }
            else
            {
                if (i == 0 || i == 2 || i == 5)
                {
                    return;
                }
                PhoneDown();

                if(i == 4 && PasswordManager.opened == 0)
                {
                    dialogueRunner.StartDialogue("LNotOpenedButTab");
                }
                else if(i==4 && PasswordManager.opened == 1)
                {
                    dialogueRunner.StartDialogue("Clear");

                }
                /*if(i == 4)
                {
                    dialogueRunner.StartDialogue("Clear");
                }*/
            }

        }
        Phone.transform.position = Vector3.Lerp(Phone.transform.position,
                cameraTransform.position + Target, Time.deltaTime * 5);
    }
    public void PoliceCallAnswer()
    {
        policeCall.GetComponent<Image>().sprite = policeCallAnswer;
    }
    public void MentalHospitalAnswer()
    {
        mentalHospital.GetComponent<Image>().sprite = mentalHospitalAnswer;
    }
}