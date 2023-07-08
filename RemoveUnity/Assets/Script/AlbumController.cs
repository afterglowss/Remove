using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AlbumController : MonoBehaviour
{
    public CanvasGroup album;

    public BTNManager btn;

    
    //public void Awake()
    //{
    //    btn = GetComponent<BTNManager>();
    //}

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
