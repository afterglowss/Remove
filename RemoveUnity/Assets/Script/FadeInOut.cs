using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Yarn.Unity;
using UnityEngine.UI;
using TMPro;

public class FadeInOut : MonoBehaviour
{
    GameObject image;
    TextMeshProUGUI text;
    private void Awake()
    {
        //image = GameObject.Find("FadeCanvas").transform.Find("FadeImage").gameObject;
        //text = GameObject.Find("EndingText").GetComponent<TextMeshProUGUI>();
    }




    [YarnCommand("fadeIn")]
    public void FadeIn(GameObject obj)
    {
        StartCoroutine(FadeInCoroutine(obj));
    }
    IEnumerator FadeInCoroutine(GameObject obj)
    {
        float FadeCount = 0;
        Color color;
        color = obj.GetComponent<Image>().color;
        while (FadeCount < 1.0f)
        {
            FadeCount += 0.01f;
            yield return new WaitForSeconds(0.005f);
            color.a = FadeCount;
            obj.GetComponent<Image>().color = color;
        }
    }


    [YarnCommand("fadeOut")]
    public void FadeOut(GameObject obj)
    {
        StartCoroutine(FadeOutCoroutine(obj));
    }
    IEnumerator FadeOutCoroutine(GameObject obj)
    {
        float FadeCount = 1f;
        Color color;
        color = obj.GetComponent<Image>().color;
        while (FadeCount > 0)
        {
            FadeCount -= 0.01f;
            yield return new WaitForSeconds(0.005f);
            color.a = FadeCount;
            obj.GetComponent<Image>().color = color;
        }
    }
    [YarnCommand("textFadeIn")]
    public void TextFadeIn(GameObject obj)
    {
        StartCoroutine(TextFadeInCoroutine(obj));
    }
    IEnumerator TextFadeInCoroutine(GameObject obj)
    {
        float FadeCount = 0;
        Color color;
        color = obj.GetComponent<TextMeshProUGUI>().color;
        while (FadeCount < 1.0f)
        {
            FadeCount += 0.01f;
            yield return new WaitForSeconds(0.02f);
            color.a = FadeCount;
            obj.GetComponent<TextMeshProUGUI>().color = color;
        }
    }
    [YarnCommand("textFadeOut")]
    public void TextFadeOut(GameObject obj)
    {
        StartCoroutine(TextFadeOutCoroutine(obj));
    }
    IEnumerator TextFadeOutCoroutine(GameObject obj)
    {
        float FadeCount = 1f;
        Color color;
        color = obj.GetComponent<TextMeshProUGUI>().color;
        while (FadeCount > 0)
        {
            FadeCount -= 0.01f;
            yield return new WaitForSeconds(0.02f);
            color.a = FadeCount;
            obj.GetComponent<TextMeshProUGUI>().color = color;
        }
    }
    [YarnCommand("textAppear")]
    public static void TextAppear(TextMeshProUGUI text)
    {
        Color color;
        color = text.color;
        color.a = 1f;
        text.color = color;
    }
}
