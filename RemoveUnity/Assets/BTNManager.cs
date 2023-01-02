using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public enum BTNType
{
    Start,
    Option,
    Quit,
    Back,
    Music,
    Sound
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
                Debug.Log("���ӽ���");
                break;
            case BTNType.Option:
                Debug.Log("����");
                CanvasGroupOn(optionGroup);
                CanvasGroupOff(mainGroup);
                break;
            case BTNType.Quit:
                Application.Quit();
                Debug.Log("������");
                break;
            case BTNType.Back:
                CanvasGroupOff(optionGroup);
                CanvasGroupOn(mainGroup);
                Debug.Log("�ڷ�");
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
