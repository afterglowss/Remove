using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class PhoneMove : MonoBehaviour
{
    private Transform cameraTransform;
    public GameObject Phone;
    private Image phoneImage;
    private Vector3 Target;
    private Vector3 std;
    private GameObject phoneBlock;

    //public CanvasGroup runApp;
    //public Image backGround;
    //public Sprite TalkFriend;
    //public Sprite TalkConversationList;
    //public Sprite TalkConversation;


    void Awake()
    {
        cameraTransform = GameObject.Find("Main Camera").GetComponent<Transform>();
        Target = new Vector3(0, -11, 100);
        std = new Vector3(0, -11, 100);
        //phoneImage = Phone.GetComponent<Image>();
    }

    public void PhoneUp()
    {
        Target = new Vector3(0, 0, 100);
    }

    public void PhoneDown()
    {
        Target = new Vector3(0, -11, 100);
        //phoneImage.sprite = "È­¸é ´Ù²¨Áü";
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Tab))
        {
            if(std.x-Target.x==0 && std.y-Target.y == 0 && std.z-Target.z==0)
            {
                PhoneUp();
                GameObject.Find("PhoneCanvas").transform.Find("PhoneBlockImage").gameObject.SetActive(true);
            }
            else
            {
                PhoneDown();
                GameObject.Find("PhoneBlockImage").gameObject.SetActive(!true);
            }
               
        }
        Phone.transform.position = Vector3.Lerp(Phone.transform.position,
                cameraTransform.position + Target, Time.deltaTime * 5);
    }

    //public void HomeButton() 
    //{
    //    runApp.alpha = 0;
    //    runApp.blocksRaycasts = false;
    //    runApp.interactable = false; 
    //}
    //public void ClickFriendIconInTalkApp()
    //{
    //    backGround.sprite = TalkFriend;

    //}
}