using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;
using Yarn;
using Yarn.Unity;
public class Password : MonoBehaviour
{
    private DialogueRunner Runner;
    public TMP_InputField inputfield_birthday;
    public Button Enter;
    public GameObject BirthdayImage;
    TMP_InputField inputfield;

    private string password = "0828";
    
    public void Start()
    {
        Runner = FindObjectOfType<DialogueRunner>();
    }

    private void Update()
    {
        if(inputfield_birthday.text.Length > 0 && Input.GetKeyUp(KeyCode.Return))
        {
            EnterClick();
        }

        if(inputfield_birthday.text.Length > 4)
        {
            inputfield_birthday.text = "";
        }
    }
    public void EnterClick()
    {
        if(inputfield_birthday.text.Equals(password) && inputfield_birthday.text.Length>0)
        {
            Debug.Log("성공");
            GameObject.Find("BirthdayImage").SetActive(false);
            Runner.StartDialogue("PasswordCorrect");
        }

        else if(inputfield_birthday.text.Length>0)
        {
            Debug.Log("실패");
            Runner.StartDialogue("InferingPassword");
            inputfield_birthday.text = "";
        }
    }

}