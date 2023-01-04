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
    Skip,
    Right,
    Left
}
public class BTNManager : MonoBehaviour
{
    public BTNType type;
    public CanvasGroup mainGroup;
    public CanvasGroup optionGroup;
    public CanvasGroup pauseGroup;
    private Transform cameraTransform;
    public Image presentImage;
    public Image rightImage;
    public Image leftImage;
    private Button rightButton;
    private Button leftButton;

    public void Start()
    {
        cameraTransform = transform.Find("Main Camera");
    }
    public void OnButtonClick()
    {
        switch (type)
        {
            case BTNType.Start:
                Debug.Log("게임시작");
                SceneManager.LoadScene("StoryScene");
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
            case BTNType.Skip:
                SceneManager.LoadScene("GameScene");
                break;
            case BTNType.Right:
                rightImage.gameObject.SetActive(true);
                leftImage.gameObject.SetActive(false);
                rightImage.rectTransform.position = new Vector3(1920,0,0);
                rightImage.rectTransform.position = Vector3.Lerp(rightImage.rectTransform.position, cameraTransform.position, 0.05f);
                presentImage.gameObject.SetActive(false);
                break;
            case BTNType.Left:
                leftImage.gameObject.SetActive(true);
                rightImage.gameObject.SetActive(false);
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
