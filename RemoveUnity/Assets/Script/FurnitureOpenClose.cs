using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class FurnitureOpenClose : MonoBehaviour
{
    public Sprite Open;
    public Sprite Close;
    public Image backGround;

    public void FurnitureOpen()
    {
        backGround.sprite = Open;
    }
    public void FurnitureClose()
    {
        backGround.sprite = Close;
    }
}
