using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class AlbumImageController : MonoBehaviour
{
    public Image Ending1;
    public Image Ending2;
    public Image Ending3;
    public Image Ending4;
    public Image Ending5;

    private TextMeshProUGUI text1;
    private TextMeshProUGUI text2;
    private TextMeshProUGUI text3;
    private TextMeshProUGUI text4;
    private TextMeshProUGUI text5;

    private void Awake()
    {
        text1 = Ending1.GetComponentInChildren<TextMeshProUGUI>();
        text2 = Ending2.GetComponentInChildren<TextMeshProUGUI>();
        text3 = Ending3.GetComponentInChildren<TextMeshProUGUI>();
        text4 = Ending4.GetComponentInChildren<TextMeshProUGUI>();
        text5 = Ending5.GetComponentInChildren<TextMeshProUGUI>();
    }
    private void Update()
    {
        if (DataManager.IsSawEnding(1))
        {
            Color color = Ending1.color;
            color.a = 1f;
            Ending1.color = color;
            text1.text = "#1 자수";
        }
        if (DataManager.IsSawEnding(2))
        {
            Color color = Ending2.color;
            color.a = 1f;
            Ending2.color = color;
            text2.text = "#2 끝나버린 삶";
        }
        if (DataManager.IsSawEnding(3))
        {
            Color color = Ending3.color;
            color.a = 1f;
            Ending3.color = color;
            text3.text = "#3 체포";
        }
        if (DataManager.IsSawEnding(4))
        {
            Color color = Ending4.color;
            color.a = 1f;
            Ending4.color = color;
            text4.text = "#4 음침한 소문";
        }
        if (DataManager.IsSawEnding(5))
        {
            Color color = Ending5.color;
            color.a = 1f;
            Ending5.color = color;
            text5.text = "#5 추모";
        }
    }
}
