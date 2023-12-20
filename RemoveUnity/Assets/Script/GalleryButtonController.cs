using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Yarn.Unity;

public class GalleryButtonController : MonoBehaviour
{
    public Button [] photoButton;

    [YarnCommand("photoButtonClick")]
    public void PhotoButtonClick()
    {
        foreach(Button button in photoButton)
        {
            button.onClick.Invoke();
        }
    }

}
