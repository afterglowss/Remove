using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;
using Yarn;
using Yarn.Unity;

public class DMeaningScript : MonoBehaviour
{
    private DialogueRunner Runner;
    public TMP_InputField inputfield_input;
    public Button Enter;
    public GameObject DMeaningImage;

    private string DMeaning = "Date";
    public void Start()
    {
        Runner = FindObjectOfType<DialogueRunner>();
    }
    public void Entering()
    {
        if (inputfield_input.text.Equals(DMeaning))
        {
            Debug.Log("����");
            GameObject.Find("DMeaningImage").SetActive(false);
            Runner.StartDialogue("DCorrect");
        }

        else
        {
            Debug.Log("����");
            Runner.StartDialogue("DMeaning");
        }
    }
}
