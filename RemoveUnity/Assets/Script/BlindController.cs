using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BlindController : MonoBehaviour
{
    Sprite[] sprites = new Sprite[3];
    public Sprite blind1;
    public Sprite blind2;
    public Sprite blind3;

    public GameObject handPrint;

    private Image backGround;

    int i = 0;
    public void Awake()
    {
        sprites[0] = blind1;
        sprites[1] = blind2;
        sprites[2] = blind3;
        backGround = gameObject.transform.parent.parent.GetComponent<Image>();
        if (backGround.sprite == blind1)
        {
            i = 0;
        }
        else if (backGround.sprite == blind2)
        {
            i = 1;
        }
        else
        {
            i = 2;
        }
    }

    public void Update()
    {
        if (backGround.sprite != blind3)
        {
            handPrint.SetActive(false);
        }
    }

    public void BlindClick()
    {
        
        if (i < 2)
        {
            backGround.sprite = sprites[i++];
        }
        else
        {
            backGround.sprite = sprites[i];
            i = 0;
        }
    }
}
