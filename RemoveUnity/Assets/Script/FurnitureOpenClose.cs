using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class FurnitureOpenClose : MonoBehaviour
{
    public Sprite Open;
    public Sprite Close;
    public Image backGround;

    private void Awake()
    {
        //backGround = gameObject.GetComponentInParent<Image>();
        
    }
    //private void Update()
    //{
    //    if (backGround.sprite != Open && backGround.sprite != Close)
    //    {
    //        FurnitureClose();
    //    }
    //}

    public void FurnitureOpen()
    {
        backGround.sprite = Open;
        Transform[] allchildren = GetComponentsInChildren<Transform>(true);
        foreach (Transform child in allchildren)
        {
            child.gameObject.SetActive(true);
        }
    }
    public void FurnitureClose()
    {
        //backGround.sprite = Close;
        Transform[] allchildren = GetComponentsInChildren<Transform>(true);
        foreach (Transform child in allchildren)
        {
            if (child.name == transform.name)
            {
                return;
            }
            child.gameObject.SetActive(false);
        }
    }
}
