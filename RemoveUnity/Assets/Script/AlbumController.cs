using System.Collections;
using System.Collections.Generic;
//using UnityEditorInternal;
using UnityEngine;
using UnityEngine.UI;

public class AlbumController : MonoBehaviour
{
    public CanvasGroup albumCanvas;

    public BTNManager quitBtn;

    public GameObject albumBtn;

    public Sprite beforeTEndAlbumBtnSprite;
    public Sprite afterTEndAlbumBtnSprite;
    public Sprite beforeTEndChangeSprite;
    public Sprite afterTEndChangeSprite;

    private Sprite albumBtnSprite;
    private Sprite albumChangeSprite;

    public Animator startAnim;
    public RuntimeAnimatorController beforeController;
    public RuntimeAnimatorController afterController;


    public static bool isThereEnding;

    int albumTransitionOnce;

    public void Awake()
    {
        isThereEnding = false;
        startAnim.runtimeAnimatorController = beforeController;
        albumBtnSprite = beforeTEndAlbumBtnSprite;
        albumChangeSprite = beforeTEndChangeSprite;
        albumBtn.GetComponent<Image>().sprite = albumBtnSprite;
        albumTransitionOnce = 0;
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

        if (DataManager.GetSawTrueEnding() && albumTransitionOnce == 0)
        {
            //진엔딩 이후 바뀌는 것은 다 여기서 바꾸기

            //앨범 아이콘 진엔딩 이후 스프라이트로 바꾸기
            albumTransitionOnce += 1;
            albumBtnSprite = afterTEndAlbumBtnSprite;
            albumBtn.GetComponent<Image>().sprite = albumBtnSprite;
            albumChangeSprite = afterTEndChangeSprite;
            startAnim.runtimeAnimatorController = afterController;
        }
    }


    public void AlbumBtnPointerEnter()
    {
        albumBtn.GetComponent<Image>().sprite = albumChangeSprite;
    }
    public void AlbumBtnPointerDown()
    {
        albumBtn.GetComponent<Image>().sprite = albumChangeSprite;
    }
    public void AlbumBtnPointerExit()
    {
        albumBtn.GetComponent<Image>().sprite = albumBtnSprite;
    }
    public void AlbumBtnPointerUp()
    {
        albumBtn.GetComponent<Image>().sprite = albumBtnSprite;
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
        quitBtn.CanvasGroupOn(albumCanvas);
        albumCanvas.alpha = 1;
    }
    public void AlbumCanvasGroupOff()
    {
        quitBtn.CanvasGroupOff(albumCanvas);
        albumCanvas.alpha = 0;
    }

    
}
