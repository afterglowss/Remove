using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OptionCanvasController : MonoBehaviour
{
    public CanvasGroup optionGroup;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (optionGroup.alpha == 1)
            {
                optionGroup.alpha = 0;
                optionGroup.interactable = false;
                optionGroup.blocksRaycasts = false;
            }
            else
            {
                optionGroup.alpha = 1;
                optionGroup.interactable = true;
                optionGroup.blocksRaycasts = true;
            }
        }        
    }
}
