using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public enum BTNType
{
    Start,
    Option,
    Music,
    Sound,
    Back,
    Quit,
    Pause
}

public class BTNManager : MonoBehaviour
{
    public BTNType type;

    public void OnBtnClick()
    {
        switch (type)
        {
            case BTNType.Start:
                SceneManager.LoadScene("StoryScene");
                break;
            case BTNType.Option:

                break;
            case BTNType.Music:
                break;
            case BTNType.Quit:
                Application.Quit();
                Debug.Log("╬ша╬╥А");
                break;

        }
    }
}
