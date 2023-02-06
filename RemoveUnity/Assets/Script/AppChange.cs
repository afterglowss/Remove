using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AppChange : MonoBehaviour
{
    public Image backGround;
    public Sprite first;
    public Sprite second;
    public Sprite third;

    public void First()
    {
        backGround.sprite = first;
    }
    public void Second()
    {
        backGround.sprite = second;
    }
    public void Third()
    {
        backGround.sprite = third;
    }
}
