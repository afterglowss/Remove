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
    private string input = "";

    private string DMeaning = "Date";
    private string Dmeaning_small = "date";
    public void Start()
    {
        Runner = FindObjectOfType<DialogueRunner>();
    }

    private void Update()
    {
        input = inputfield_input.text;

        if (Input.GetKeyDown(KeyCode.Return) && input.Length>0)
        {
            Entering();
        }

        if(input.Length>4)
        {
            inputfield_input.text = "";
        }
    }
    public void Entering()
    {
        if (input.Length > 0 && (input.Equals(DMeaning)||input.Equals(Dmeaning_small)||input.Equals("DATE")))
        {
            Debug.Log("성공");
            GameObject.Find("DMeaningImage").SetActive(false);
            Runner.StartDialogue("DCorrect");
        }

        else if(input.Length > 0)
        {
            inputfield_input.text = "";
            Debug.Log("실패");
            Runner.StartDialogue("DMeaning");
        }
    }
}
