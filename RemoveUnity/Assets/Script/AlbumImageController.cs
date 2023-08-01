using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using System;
using Newtonsoft.Json.Linq;

public class AlbumImageController : MonoBehaviour
{
    public Image Ending1;
    public Image Ending2;
    public Image Ending3;
    public Image Ending4;
    public Image Ending5;

    public TextMeshProUGUI hint;

    private TextMeshProUGUI[] text1;
    private TextMeshProUGUI[] text2;
    private TextMeshProUGUI[] text3;
    private TextMeshProUGUI[] text4;
    private TextMeshProUGUI[] text5;



    bool ending1Appear = false;
    bool ending2Appear = false;
    bool ending3Appear = false;
    bool ending4Appear = false;
    bool ending5Appear = false;

    private void Awake()
    {
        text1 = Ending1.GetComponentsInChildren<TextMeshProUGUI>();
        text2 = Ending2.GetComponentsInChildren<TextMeshProUGUI>();
        text3 = Ending3.GetComponentsInChildren<TextMeshProUGUI>();
        text4 = Ending4.GetComponentsInChildren<TextMeshProUGUI>();
        text5 = Ending5.GetComponentsInChildren<TextMeshProUGUI>();
    }
    private void Update()
    {
        if (DataManager.IsSawEnding(1) && !ending1Appear)
        {
            Color color = Ending1.color;
            color.a = 1f;
            Ending1.color = color;
            text1[0].text = "#1 자수";
            AlbumController.isThereEnding = true;
            ending1Appear = true;
            //Debug.Log(AlbumController.isThereEnding);
        }
        if (DataManager.IsSawEnding(2) && !ending2Appear)
        {
            Color color = Ending2.color;
            color.a = 1f;
            Ending2.color = color;
            text2[0].text = "#2 끝나버린 삶";
            AlbumController.isThereEnding = true;
            ending2Appear = true;
        }
        if (DataManager.IsSawEnding(3) && !ending3Appear)
        {
            Color color = Ending3.color;
            color.a = 1f;
            Ending3.color = color;
            text3[0].text = "#3 검거";
            AlbumController.isThereEnding = true;
            ending3Appear = true;
        }
        if (DataManager.IsSawEnding(4) && !ending4Appear)
        {
            Color color = Ending4.color;
            color.a = 1f;
            Ending4.color = color;
            text4[0].text = "#4 음침한 소문";
            AlbumController.isThereEnding = true;
            ending4Appear = true;
        }
        if (DataManager.IsSawEnding(5) & !ending5Appear)
        {
            Color color = Ending5.color;
            color.a = 1f;
            Ending5.color = color;
            text5[0].text = "#5 드러난 진실";
            AlbumController.isThereEnding = true;
            ending5Appear = true;
        }

        if (DataManager.IsSawEnding(1) && DataManager.IsSawEnding(3) &&
            DataManager.IsSawEnding(4) && DataManager.IsSawEnding(5) &&
            !DataManager.IsSawEnding(2))
        {
            Color color = hint.color;
            color.a = 1f;
            hint.color = color;
        }
        else
        {
            Color color = hint.color;
            color.a = 0f;
            hint.color = color;
        }
    }

    private TextMeshProUGUI[] text;

    public void PointerEnter(Image image)
    {
        Color color = image.color;
        if (color.a == 0f) return;

        color.r = 0.35f;
        color.g = 0.35f;
        color.b = 0.35f;
        image.color = color;

        text = image.GetComponentsInChildren<TextMeshProUGUI>();
        color = text[1].color;
        color.a = 1f;
        text[1].color = color;
    }

    public void PointerExit(Image image)
    {
        Color color = image.color;
        if (color.a == 0f) return;

        color.r = 1f;
        color.g = 1f;
        color.b = 1f;
        image.color = color;

        text = image.GetComponentsInChildren<TextMeshProUGUI>();
        color = text[1].color;
        color.a = 0f;
        text[1].color = color;
    }
}
