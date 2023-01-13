using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class RightMove : MonoBehaviour
{
    private Image presentImage;
    private Camera mainCamera;

    private void Awake()
    {
        mainCamera = GameObject.Find("Main Camera").GetComponent<Camera>();
        presentImage = transform.parent.GetComponent<Image>();
    }
    public void OnBtnClick()
    {
        if (presentImage.name == "Room1")
        {
            mainCamera.transform.position = new Vector3(17.77778f,0, -100);
        }
        else if (presentImage.name == "Room2")
        {
            mainCamera.transform.position = new Vector3(35.5556f, 0, -100);
        }
        else if (presentImage.name == "Room3")
        {
            mainCamera.transform.position = new Vector3(53.3334f, 0, -100);
        }
        else if (presentImage.name == "Room4")
        {
            mainCamera.transform.position = new Vector3(0, 0, -100);
        }
    }
    
}
