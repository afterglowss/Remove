using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using Yarn.Unity;

public enum BTNType
{
    Start,
    Option,
    Quit,
    Back,
    Music,
    Sound,
    SkipToPhone,
    SkipToStoryEnd,
    SkipToGamescene,
    MainMenu
}
public class BTNManager : MonoBehaviour
{
    public BTNType type;
    public CanvasGroup mainGroup;
    public CanvasGroup optionGroup;
    public CanvasGroup phoneGroup;
    

    private DialogueRunner dialogueRunner;
    private InMemoryVariableStorage variableStorage;

    public void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (optionGroup.alpha == 1)
            {
                OptionCanvasOff();
            }
            else
                OptionCanvasOn();
        }
    }

    public void Start()
    {
        dialogueRunner = FindObjectOfType<DialogueRunner>();
        variableStorage = FindObjectOfType<InMemoryVariableStorage>();
    }

    public void OnButtonClick()
    {
        switch (type)
        {
            case BTNType.Start:
                //Debug.Log("게임시작");
                SceneManager.LoadScene("StoryStart");
                break;
            case BTNType.Option:
                //Debug.Log("설정");
                CanvasGroupOn(optionGroup);
                optionGroup.alpha = 1;
                CanvasGroupOff(mainGroup);
                CanvasGroupOff(phoneGroup);
                phoneGroup.alpha = 0;   
                break;
            case BTNType.Quit:
                Application.Quit();
                //Debug.Log("앱종료");
                break;
            case BTNType.Back:
                CanvasGroupOff(optionGroup);
                optionGroup.alpha = 0;
                CanvasGroupOn(mainGroup);
                CanvasGroupOn(phoneGroup);
                phoneGroup.alpha = 1;
                //Debug.Log("뒤로");
                break;
            case BTNType.SkipToPhone:
                SceneManager.LoadScene("Phone");
                break;
            case BTNType.SkipToStoryEnd:
                SceneManager.LoadScene("StoryEnd");
                break;
            case BTNType.SkipToGamescene:
                SceneManager.LoadScene("GameScene");
                break;
            case BTNType.MainMenu:
                dialogueRunner.StartDialogue("GameExit");
                break;
        }
    }

    private void OptionCanvasOn()
    {
        CanvasGroupOn(optionGroup);
        optionGroup.alpha = 1;
        CanvasGroupOff(mainGroup);
        CanvasGroupOff(phoneGroup);
        phoneGroup.alpha = 0;
    }
    private void OptionCanvasOff()
    {
        CanvasGroupOff(optionGroup);
        optionGroup.alpha = 0;
        CanvasGroupOn(mainGroup);
        CanvasGroupOn(phoneGroup);
        phoneGroup.alpha = 1;
    }

    private void CanvasGroupOn(CanvasGroup cg)
    {
        //cg.alpha = 1;
        cg.interactable = true;
        cg.blocksRaycasts = true;
    }
    private void CanvasGroupOff(CanvasGroup cg)
    {
        //cg.alpha = 0;
        cg.interactable = false;
        cg.blocksRaycasts = false;
    }

    [YarnCommand("jumpMainScene")]
    public static void JumpMainScene()
    {
        SceneManager.LoadScene("StartScene");
    }
    [YarnCommand("jumpGameScene")]
    public static void JumpGameScene()
    {
        SceneManager.LoadScene("GameScene");
    }
    [YarnCommand("jumpPhone")]
    public static void JumpPhone()
    {
        SceneManager.LoadScene("Phone");
    }
    [YarnCommand("jumpStoryEnd")]
    public static void JumpStoryEnd()
    {
        SceneManager.LoadScene("StoryEnd");
    }

    [YarnCommand("fadeIn")]
    public static void FadeIn()
    {
        GameObject.Find("FadeCanvas").transform.Find("Image").gameObject.SetActive(true);
    }

    [YarnCommand("fadeOut")]
    public static void FadeOut()
    {
        GameObject.Find("FadeCanvas").transform.Find("Image").gameObject.SetActive(false);
    }

    
}
