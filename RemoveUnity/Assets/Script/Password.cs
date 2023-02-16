using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Yarn.Unity;
public class Password : MonoBehaviour
{
    public DialogueRunner runner;
    public InputField inputField;
    bool correct = false;

  
    public void OkBtn()
    {
        if (inputField.text.Equals("0828"))
        {
            Debug.Log("Log In!");
            correct = true;
            GameObject.Find("FadeCanvas").transform.Find("Password").gameObject.SetActive(false);
            runner.StartDialogue("PasswordCorrect");
        }
        else
        {
            Debug.Log("Fail!");
            GameObject.Find("FadeCanvas").transform.Find("Password").gameObject.SetActive(false);
            runner.StartDialogue("InferingPassword");
        }
    }

    [YarnCommand("PasswordIn")]
    public static void PasswordIn()
    {
        GameObject.Find("FadeCanvas").transform.Find("Password").gameObject.SetActive(true);
    }



}