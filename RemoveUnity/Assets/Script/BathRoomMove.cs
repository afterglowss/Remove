using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public enum BathroomBTNType
{
    Right,
    Left,
    Down,
    Up
}

public class BathRoomMove : MonoBehaviour
{
    public BathroomBTNType type;
    public Camera mainCamera;

    public void OnBathroomBtnClick()
    {
        switch (type)
        {
            case BathroomBTNType.Left:
                mainCamera.transform.position = new Vector3(-17.7778f, 10, -100);
                break;
            case BathroomBTNType.Right:
                mainCamera.transform.position = new Vector3(0, 10, -100);
                break;
            case BathroomBTNType.Down:
                mainCamera.transform.position = new Vector3(0, 0, -100);
                break;
            case BathroomBTNType.Up:
                mainCamera.transform.position = new Vector3(0, 10, -100);
                break;
        }
    }
}