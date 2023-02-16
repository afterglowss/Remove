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
    }

    public void PhoneUp()
    {
        Target = new Vector3(0, 0, 100);
        phoneBlack.SetActive(false);
        GameObject.Find("PhoneCanvas").transform.Find("PhoneBlockImage").gameObject.SetActive(true);
    }

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
                if (i == 0 || i == 2)
                {
                    return;
                }
                PhoneDown();
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