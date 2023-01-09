using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LeftMove : MonoBehaviour
{
    public Image presentImage;
    private Camera mainCamera;
    private void Awake()
    {
        mainCamera = GameObject.Find("Main Camera").GetComponent<Camera>();
    }
    public void OnBtnClick()
    {
        if (presentImage.name == "Room1")
        {
            mainCamera.transform.position = new Vector3(0, -10, -100);
        }
        else if (presentImage.name == "Room2")
        {
            mainCamera.transform.position = new Vector3(0, 0, -100);
        }
        else if (presentImage.name == "Room3")
        {
            mainCamera.transform.position = new Vector3(17.78f, 0, -100);
        }
        else if (presentImage.name == "Room4")
        {
            mainCamera.transform.position = new Vector3(17.78f, -10, -100);
        }
    }

}
