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
    public CanvasGroup pauseGroup;

    private DialogueRunner dialogueRunner;
    private InMemoryVariableStorage variableStorage;

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
                Debug.Log("게임시작");
                SceneManager.LoadScene("StoryStart");
                break;
            case BTNType.Option:
                Debug.Log("설정");
                CanvasGroupOn(optionGroup);
                optionGroup.alpha = 1;
                CanvasGroupOff(mainGroup);
                break;
            case BTNType.Quit:
                Application.Quit();
                Debug.Log("앱종료");
                break;
            case BTNType.Back:
                CanvasGroupOff(optionGroup);
                optionGroup.alpha = 0;
                CanvasGroupOn(mainGroup);
                Debug.Log("뒤로");
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

    [YarnCommand("fadeInOut")]
    public static void FadeInOut()
    {
        SceneManager.LoadScene("FadeInOut");
    }
}
