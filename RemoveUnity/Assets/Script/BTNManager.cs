using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public enum BTNType
{
    Start,
    Option,
    Quit,
    Back,
    Music,
    Sound,
    SkipToHospital,
    SkipToBlack1,
    SkipToPhone,
    SkipToBlack2,
    SkipToGamescene,
    MainMenu
}
public class BTNManager : MonoBehaviour
{
    public BTNType type;
    public CanvasGroup mainGroup;
    public CanvasGroup optionGroup;
    public CanvasGroup pauseGroup;

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
                CanvasGroupOff(mainGroup);
                break;
            case BTNType.Quit:
                Application.Quit();
                Debug.Log("앱종료");
                break;
            case BTNType.Back:
                CanvasGroupOff(optionGroup);
                CanvasGroupOn(mainGroup);
                Debug.Log("뒤로");
                break;
            case BTNType.SkipToHospital:
                SceneManager.LoadScene("Hospital");
                break;
            case BTNType.SkipToBlack1:
                SceneManager.LoadScene("Black1");
                break;
            case BTNType.SkipToPhone:
                SceneManager.LoadScene("Phone");
                break;
            case BTNType.SkipToBlack2:
                SceneManager.LoadScene("Black2");
                break;
            case BTNType.SkipToGamescene:
                SceneManager.LoadScene("GameScene");
                break;
            case BTNType.MainMenu:
                SceneManager.LoadScene("StartScene");
                break;
        }
    }

    private void CanvasGroupOn(CanvasGroup cg)
    {
        cg.alpha = 1;
        cg.interactable = true;
        cg.blocksRaycasts = true;
    }
    private void CanvasGroupOff(CanvasGroup cg)
    {
        cg.alpha = 0;
        cg.interactable = false;
        cg.blocksRaycasts = false;
    }
}
