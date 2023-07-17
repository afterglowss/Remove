using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AlbumController : MonoBehaviour
{
    public CanvasGroup album;

    public BTNManager btn;

    public static bool isThereEnding;



    public void Awake()
    {
        isThereEnding = false;
    }
    public void Update()
    {
        if (isThereEnding)
        {
            GameObject.Find("MainCanvas").transform.Find("AlbumButton").gameObject.SetActive(true);
        }
        else
        {
            GameObject.Find("MainCanvas").transform.Find("AlbumButton").gameObject.SetActive(false);
        }
    }

    public void OnAlbumBtnClick()
    {
        AlbumCanvasGroupOn();
    }
    public void OnAlbumBackBtnClick()
    {
        AlbumCanvasGroupOff();
    }

    public void AlbumCanvasGroupOn()
    {
        btn.CanvasGroupOn(album);
        album.alpha = 1;
    }
    public void AlbumCanvasGroupOff()
    {
        btn.CanvasGroupOff(album);
        album.alpha = 0;
    }

    
}
